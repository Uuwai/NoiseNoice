namespace NoiseNoice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            propertyGrid1 = new PropertyGrid();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            splitContainer2 = new SplitContainer();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            openjsonToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            savejsonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            randomValueToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            view100ToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutNoiseNoiceToolStripMenuItem = new ToolStripMenuItem();
            githubRepositoryToolStripMenuItem = new ToolStripMenuItem();
            trackBar1 = new TrackBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(233, 275);
            propertyGrid1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(794, 382);
            splitContainer1.SplitterDistance = 551;
            splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 382);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += panel1_MouseDown;
            pictureBox1.MouseMove += panel1_MouseMove;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(239, 382);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.Location = new Point(3, 356);
            button1.Name = "button1";
            button1.Size = new Size(233, 23);
            button1.TabIndex = 1;
            button1.Text = "Set Noise";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(propertyGrid1);
            splitContainer2.Size = new Size(233, 347);
            splitContainer2.SplitterDistance = 68;
            splitContainer2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.Dock = DockStyle.Fill;
            textBox1.HideSelection = false;
            textBox1.Location = new Point(0, 0);
            textBox1.MaxLength = 0;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Image Properties";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(233, 68);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openImageToolStripMenuItem, openjsonToolStripMenuItem, toolStripSeparator1, saveImageToolStripMenuItem, savejsonToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(139, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(139, 22);
            openImageToolStripMenuItem.Text = "Open Image";
            openImageToolStripMenuItem.Click += openImageToolStripMenuItem_Click;
            // 
            // openjsonToolStripMenuItem
            // 
            openjsonToolStripMenuItem.Name = "openjsonToolStripMenuItem";
            openjsonToolStripMenuItem.Size = new Size(139, 22);
            openjsonToolStripMenuItem.Text = "Open .json";
            openjsonToolStripMenuItem.Click += openjsonToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(136, 6);
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(139, 22);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // savejsonToolStripMenuItem
            // 
            savejsonToolStripMenuItem.Name = "savejsonToolStripMenuItem";
            savejsonToolStripMenuItem.Size = new Size(139, 22);
            savejsonToolStripMenuItem.Text = "Save .json";
            savejsonToolStripMenuItem.Click += savejsonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { randomValueToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // randomValueToolStripMenuItem
            // 
            randomValueToolStripMenuItem.Name = "randomValueToolStripMenuItem";
            randomValueToolStripMenuItem.Size = new Size(150, 22);
            randomValueToolStripMenuItem.Text = "Random Value";
            randomValueToolStripMenuItem.Click += randomValueToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { view100ToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // view100ToolStripMenuItem
            // 
            view100ToolStripMenuItem.Name = "view100ToolStripMenuItem";
            view100ToolStripMenuItem.Size = new Size(130, 22);
            view100ToolStripMenuItem.Text = "View 100%";
            view100ToolStripMenuItem.Click += view100ToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutNoiseNoiceToolStripMenuItem, githubRepositoryToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutNoiseNoiceToolStripMenuItem
            // 
            aboutNoiseNoiceToolStripMenuItem.Name = "aboutNoiseNoiceToolStripMenuItem";
            aboutNoiseNoiceToolStripMenuItem.Size = new Size(171, 22);
            aboutNoiseNoiceToolStripMenuItem.Text = "About NoiseNoice";
            aboutNoiseNoiceToolStripMenuItem.Click += aboutNoiseNoiceToolStripMenuItem_Click;
            // 
            // githubRepositoryToolStripMenuItem
            // 
            githubRepositoryToolStripMenuItem.Name = "githubRepositoryToolStripMenuItem";
            githubRepositoryToolStripMenuItem.Size = new Size(171, 22);
            githubRepositoryToolStripMenuItem.Text = "GitHub Repository";
            githubRepositoryToolStripMenuItem.Click += githubRepositoryToolStripMenuItem_Click;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Fill;
            trackBar1.Enabled = false;
            trackBar1.LargeChange = 25;
            trackBar1.Location = new Point(109, 3);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(682, 26);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 3;
            trackBar1.TickFrequency = 25;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(trackBar1, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 391);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 32);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 4;
            label1.Text = "100%";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(800, 426);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "NoiseNoice";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PropertyGrid propertyGrid1;
        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem openjsonToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem randomValueToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private SplitContainer splitContainer2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem savejsonToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem view100ToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutNoiseNoiceToolStripMenuItem;
        private ToolStripMenuItem githubRepositoryToolStripMenuItem;
        private TextBox textBox1;
    }
}
