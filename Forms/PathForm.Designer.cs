namespace LeahsPlatinumTracker
{
    partial class PathForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listAllPaths = new System.Windows.Forms.ListBox();
            this.lblAllPathsHeader = new System.Windows.Forms.Label();
            this.txtShortest = new System.Windows.Forms.TextBox();
            this.lblShortestHeader = new System.Windows.Forms.Label();
            this.btnFlagsConsidered = new System.Windows.Forms.Button();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.listAllPaths);
            this.panel1.Controls.Add(this.lblAllPathsHeader);
            this.panel1.Controls.Add(this.txtShortest);
            this.panel1.Controls.Add(this.lblShortestHeader);
            this.panel1.Controls.Add(this.btnFlagsConsidered);
            this.panel1.Controls.Add(this.btnFindPath);
            this.panel1.Controls.Add(this.comboTo);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.comboFrom);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 406);
            this.panel1.TabIndex = 0;
            //
            // lblFrom
            //
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblFrom.Location = new System.Drawing.Point(5, 5);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            //
            // comboFrom
            //
            this.comboFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(5, 23);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(306, 23);
            this.comboFrom.TabIndex = 1;
            //
            // lblTo
            //
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblTo.Location = new System.Drawing.Point(5, 55);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            //
            // comboTo
            //
            this.comboTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(5, 73);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(306, 23);
            this.comboTo.TabIndex = 3;
            //
            // btnFindPath
            //
            this.btnFindPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(183)))), ((int)(((byte)(214)))));
            this.btnFindPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.btnFindPath.FlatAppearance.BorderSize = 2;
            this.btnFindPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPath.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFindPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(129)))));
            this.btnFindPath.Location = new System.Drawing.Point(5, 105);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(120, 25);
            this.btnFindPath.TabIndex = 4;
            this.btnFindPath.Text = "Find Path";
            this.btnFindPath.UseVisualStyleBackColor = false;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            //
            // btnFlagsConsidered
            //
            this.btnFlagsConsidered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnFlagsConsidered.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnFlagsConsidered.FlatAppearance.BorderSize = 2;
            this.btnFlagsConsidered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlagsConsidered.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFlagsConsidered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnFlagsConsidered.Location = new System.Drawing.Point(135, 105);
            this.btnFlagsConsidered.Name = "btnFlagsConsidered";
            this.btnFlagsConsidered.Size = new System.Drawing.Size(176, 25);
            this.btnFlagsConsidered.TabIndex = 9;
            this.btnFlagsConsidered.Text = "Flags Considered: Off";
            this.btnFlagsConsidered.UseVisualStyleBackColor = false;
            this.btnFlagsConsidered.Click += new System.EventHandler(this.btnFlagsConsidered_Click);
            //
            // lblShortestHeader
            //
            this.lblShortestHeader.AutoSize = true;
            this.lblShortestHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblShortestHeader.Location = new System.Drawing.Point(5, 140);
            this.lblShortestHeader.Name = "lblShortestHeader";
            this.lblShortestHeader.Size = new System.Drawing.Size(80, 15);
            this.lblShortestHeader.TabIndex = 5;
            this.lblShortestHeader.Text = "Shortest path:";
            //
            // txtShortest
            //
            this.txtShortest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtShortest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShortest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txtShortest.Location = new System.Drawing.Point(5, 158);
            this.txtShortest.Multiline = true;
            this.txtShortest.Name = "txtShortest";
            this.txtShortest.ReadOnly = true;
            this.txtShortest.Size = new System.Drawing.Size(306, 42);
            this.txtShortest.TabIndex = 6;
            this.txtShortest.TabStop = false;
            //
            // lblAllPathsHeader
            //
            this.lblAllPathsHeader.AutoSize = true;
            this.lblAllPathsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblAllPathsHeader.Location = new System.Drawing.Point(5, 206);
            this.lblAllPathsHeader.Name = "lblAllPathsHeader";
            this.lblAllPathsHeader.Size = new System.Drawing.Size(63, 15);
            this.lblAllPathsHeader.TabIndex = 7;
            this.lblAllPathsHeader.Text = "All paths:";
            //
            // listAllPaths
            //
            this.listAllPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.listAllPaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listAllPaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listAllPaths.FormattingEnabled = true;
            this.listAllPaths.HorizontalScrollbar = true;
            this.listAllPaths.ItemHeight = 15;
            this.listAllPaths.Location = new System.Drawing.Point(5, 224);
            this.listAllPaths.Name = "listAllPaths";
            this.listAllPaths.Size = new System.Drawing.Size(306, 182);
            this.listAllPaths.TabIndex = 8;
            this.listAllPaths.TabStop = false;
            //
            // PathForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(340, 430);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Path";
            this.Load += new System.EventHandler(this.PathForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblFrom;
        private ComboBox comboFrom;
        private Label lblTo;
        private ComboBox comboTo;
        private Button btnFindPath;
        private Button btnFlagsConsidered;
        private Label lblShortestHeader;
        private TextBox txtShortest;
        private Label lblAllPathsHeader;
        private ListBox listAllPaths;
    }
}
