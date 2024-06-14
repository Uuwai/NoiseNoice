namespace NoiseNoice
{
    partial class Form2
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 19);
            button1.Name = "button1";
            button1.Size = new Size(271, 53);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 75);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Background Color";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new Point(12, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 75);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Size x*y";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(268, 53);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Location = new Point(137, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(128, 47);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Height";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new Point(3, 19);
            numericUpDown2.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(122, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 512, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(128, 47);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Width";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(3, 19);
            numericUpDown1.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(122, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 512, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(214, 178);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(12, 178);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.Color = Color.White;
            colorDialog1.FullOpen = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 213);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Create Image";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox4;
        private NumericUpDown numericUpDown2;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button button3;
        private ColorDialog colorDialog1;
    }
}