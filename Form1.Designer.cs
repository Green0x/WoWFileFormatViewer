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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 529);
            button1.Name = "button1";
            button1.Size = new Size(124, 76);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(752, 528);
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 681);
            Controls.Add(litNameBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ListBox litNameBox;
    }
}
