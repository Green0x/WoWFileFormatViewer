namespace WoWFileFormats
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
            button1 = new Button();
            button2 = new Button();
            litNameBox = new ListBox();
            lgtRadius = new TextBox();
            lgtDropoff = new TextBox();
            yCoordBox = new TextBox();
            xCoordBox = new TextBox();
            zCoordBox = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(355, 534);
            button1.Name = "button1";
            button1.Size = new Size(124, 76);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(626, 533);
            button2.Name = "button2";
            button2.Size = new Size(122, 77);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // litNameBox
            // 
            litNameBox.FormattingEnabled = true;
            litNameBox.ItemHeight = 15;
            litNameBox.Location = new Point(754, 134);
            litNameBox.Name = "litNameBox";
            litNameBox.Size = new Size(428, 394);
            litNameBox.TabIndex = 3;
            litNameBox.SelectedIndexChanged += litNameBox_SelectedIndexChanged;
            // 
            // lgtRadius
            // 
            lgtRadius.Location = new Point(96, 49);
            lgtRadius.Name = "lgtRadius";
            lgtRadius.ReadOnly = true;
            lgtRadius.Size = new Size(100, 23);
            lgtRadius.TabIndex = 7;
            // 
            // lgtDropoff
            // 
            lgtDropoff.Location = new Point(202, 49);
            lgtDropoff.Name = "lgtDropoff";
            lgtDropoff.ReadOnly = true;
            lgtDropoff.Size = new Size(100, 23);
            lgtDropoff.TabIndex = 8;
            // 
            // yCoordBox
            // 
            yCoordBox.Location = new Point(149, 154);
            yCoordBox.Name = "yCoordBox";
            yCoordBox.ReadOnly = true;
            yCoordBox.Size = new Size(100, 23);
            yCoordBox.TabIndex = 9;
            // 
            // xCoordBox
            // 
            xCoordBox.Location = new Point(43, 154);
            xCoordBox.Name = "xCoordBox";
            xCoordBox.ReadOnly = true;
            xCoordBox.Size = new Size(100, 23);
            xCoordBox.TabIndex = 10;
            // 
            // zCoordBox
            // 
            zCoordBox.Location = new Point(255, 155);
            zCoordBox.Name = "zCoordBox";
            zCoordBox.ReadOnly = true;
            zCoordBox.Size = new Size(100, 23);
            zCoordBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(zCoordBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(xCoordBox);
            groupBox1.Controls.Add(lgtDropoff);
            groupBox1.Controls.Add(yCoordBox);
            groupBox1.Controls.Add(lgtRadius);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(355, 326);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 202);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Light Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 103);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 14;
            label6.Text = "Light Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 22);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 13;
            label5.Text = "Light Drop Off";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 137);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 9;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 137);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 10;
            label2.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 22);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 12;
            label4.Text = "Light Radius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 137);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 11;
            label3.Text = "Z";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 681);
            Controls.Add(litNameBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ListBox litNameBox;
        public TextBox lgtRadius;
        public TextBox lgtDropoff;
        public TextBox yCoordBox;
        public TextBox xCoordBox;
        public TextBox zCoordBox;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}
