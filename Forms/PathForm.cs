using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LeahsPlatinumTracker
{
    public partial class PathForm : Form
    {

        private Tracker Player { get; set; }

        private const int MaxAllPaths = 3;

        // When true, a Condition gated behind an HM/story check only counts (for grouping and pathing alike)
        // while the player currently meets it - e.g. Mt Coronet Peak's two halves stay separate until Rock
        // Climb is obtained. When false, every non-fast-travel Condition counts regardless of current progress.
        private bool considerFlags = false;

        // Wraps a location (a group of one or more MapSectors, see Tracker.BuildLocationGroups) for display in
        // the location ComboBoxes. Locations that are genuinely part of the same physical place (e.g. Eterna and
        // its TG Eterna entrance, only gated behind Cut) are grouped together, while locations only reachable via
        // a fast-travel Condition (Fly/Teleport to a Pokemon Centre) or a Warp the player links stay separate.
        private class LocationItem
        {
            public string MapID;
            public string DisplayName;
            public override string ToString() => DisplayName;
        }

        // Constructor
        public PathForm(Tracker _player)
        {
            InitializeComponent();
            Player = _player;
        }

        // Methods

        private void PathForm_Load(object sender, EventArgs e)
        {
            PopulateLocations();
        }

        // Repopulates the location dropdowns from the current groupings, re-selecting the same physical
        // MapSectors as before (if given) even though their canonical location ID may have changed.
        private void PopulateLocations(string preserveFromID = null, string preserveToID = null)
        {
            Dictionary<string, string> groups = Player.BuildLocationGroups(considerFlags);

            List<LocationItem> locations = groups.Values.Distinct()
                .Select(locationID => new LocationItem { MapID = locationID, DisplayName = Player.GetLocationDisplayName(locationID, groups) })
                .OrderBy(item => item.DisplayName)
                .ToList();

            comboFrom.Items.Clear();
            comboTo.Items.Clear();
            comboFrom.Items.AddRange(locations.ToArray());
            comboTo.Items.AddRange(locations.ToArray());

            if (preserveFromID != null && groups.TryGetValue(preserveFromID, out string newFromID))
            {
                comboFrom.SelectedItem = locations.FirstOrDefault(item => item.MapID == newFromID);
            }

            if (preserveToID != null && groups.TryGetValue(preserveToID, out string newToID))
            {
                comboTo.SelectedItem = locations.FirstOrDefault(item => item.MapID == newToID);
            }
        }

        /// <summary>
        /// Re-runs the currently displayed search, if any. Called by the main tracker window whenever a <see cref="Warp"/> is linked/unlinked or a check/flag is toggled, so the pathfinder stays up to date while the player keeps exploring.
        /// </summary>
        public void Reload()
        {
            if (comboFrom.SelectedItem != null && comboTo.SelectedItem != null) btnFindPath_Click(this, EventArgs.Empty);
        }

        private void btnFlagsConsidered_Click(object sender, EventArgs e)
        {
            considerFlags = !considerFlags;

            if (considerFlags)
            {
                btnFlagsConsidered.Text = "Flags Considered: On";
                btnFlagsConsidered.BackColor = Color.FromArgb(255, 160, 183, 214);
                btnFlagsConsidered.ForeColor = Color.FromArgb(255, 54, 82, 129);
                btnFlagsConsidered.FlatAppearance.BorderColor = Color.FromArgb(255, 112, 146, 190);
            }
            else
            {
                btnFlagsConsidered.Text = "Flags Considered: Off";
                btnFlagsConsidered.BackColor = Color.FromArgb(255, 209, 209, 209);
                btnFlagsConsidered.ForeColor = Color.FromArgb(255, 155, 155, 155);
                btnFlagsConsidered.FlatAppearance.BorderColor = Color.FromArgb(255, 155, 155, 155);
            }

            string previousFrom = (comboFrom.SelectedItem as LocationItem)?.MapID;
            string previousTo = (comboTo.SelectedItem as LocationItem)?.MapID;

            PopulateLocations(previousFrom, previousTo);
            Reload();
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            LocationItem from = comboFrom.SelectedItem as LocationItem;
            LocationItem to = comboTo.SelectedItem as LocationItem;

            listAllPaths.Items.Clear();

            if (from == null || to == null)
            {
                txtShortest.Text = "Please select both a starting and destination location.";
                return;
            }

            if (from.MapID == to.MapID)
            {
                txtShortest.Text = "Please select two different locations.";
                return;
            }

            Dictionary<string, string> groups = Player.BuildLocationGroups(considerFlags);

            List<string> shortestPath = Player.FindShortestPath(from.MapID, to.MapID, considerFlags);

            if (shortestPath == null)
            {
                txtShortest.Text = "No path exists between these locations.";
                listAllPaths.Items.Add("No paths found.");
                return;
            }

            txtShortest.Text = StringifyPath(shortestPath, groups);

            List<List<string>> allPaths = Player.FindAllPaths(from.MapID, to.MapID, MaxAllPaths, considerFlags: considerFlags);
            foreach (List<string> path in allPaths)
            {
                listAllPaths.Items.Add(StringifyPath(path, groups));
            }

            if (allPaths.Count >= MaxAllPaths)
            {
                listAllPaths.Items.Add($"(showing first {MaxAllPaths} paths found)");
            }
        }

        private string StringifyPath(List<string> path, Dictionary<string, string> groups)
        {
            return string.Join(" → ", path.Select(id => Player.GetLocationDisplayName(id, groups)));
        }

    }
}
