using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LeahsPlatinumTracker
{
    public partial class PathForm : Form
    {

        private Tracker Player { get; set; }

        private const int MaxAllPaths = 250;

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
            Dictionary<string, string> groups = Player.BuildLocationGroups();

            List<LocationItem> locations = groups.Values.Distinct()
                .Select(locationID => new LocationItem { MapID = locationID, DisplayName = Player.GetLocationDisplayName(locationID, groups) })
                .OrderBy(item => item.DisplayName)
                .ToList();

            comboFrom.Items.AddRange(locations.ToArray());
            comboTo.Items.AddRange(locations.ToArray());
        }

        /// <summary>
        /// Re-runs the currently displayed search, if any. Called by the main tracker window whenever a <see cref="Warp"/> is linked/unlinked or a check/flag is toggled, so the pathfinder stays up to date while the player keeps exploring.
        /// </summary>
        public void Reload()
        {
            if (comboFrom.SelectedItem != null && comboTo.SelectedItem != null) btnFindPath_Click(this, EventArgs.Empty);
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

            List<string> shortestPath = Player.FindShortestPath(from.MapID, to.MapID);

            if (shortestPath == null)
            {
                txtShortest.Text = "No path exists between these locations.";
                listAllPaths.Items.Add("No paths found.");
                return;
            }

            txtShortest.Text = StringifyPath(shortestPath);

            List<List<string>> allPaths = Player.FindAllPaths(from.MapID, to.MapID, MaxAllPaths);
            foreach (List<string> path in allPaths)
            {
                listAllPaths.Items.Add(StringifyPath(path));
            }

            if (allPaths.Count >= MaxAllPaths)
            {
                listAllPaths.Items.Add($"(showing first {MaxAllPaths} paths found)");
            }
        }

        private string StringifyPath(List<string> path)
        {
            return string.Join(" → ", path.Select(id => Player.GetLocationDisplayName(id)));
        }

    }
}
