namespace Image_Processing
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            openFileDialog4 = new OpenFileDialog();
            openFileDialog5 = new OpenFileDialog();
            button8 = new Button();
            button9 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 483);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1229, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(531, 483);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1818, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openImageToolStripMenuItem, saveImageToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(73, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(213, 34);
            openImageToolStripMenuItem.Text = "Open Image";
            openImageToolStripMenuItem.Click += openImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(213, 34);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(43, 628);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 3;
            button1.Text = "Copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 667);
            button2.Name = "button2";
            button2.Size = new Size(111, 33);
            button2.TabIndex = 4;
            button2.Text = "GreyScale";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 706);
            button3.Name = "button3";
            button3.Size = new Size(111, 33);
            button3.TabIndex = 5;
            button3.Text = "Invert";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(190, 628);
            button4.Name = "button4";
            button4.Size = new Size(111, 33);
            button4.TabIndex = 6;
            button4.Text = "Histogram";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(190, 667);
            button5.Name = "button5";
            button5.Size = new Size(111, 33);
            button5.TabIndex = 7;
            button5.Text = "Sepia";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(643, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(531, 483);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(206, 538);
            button6.Name = "button6";
            button6.Size = new Size(116, 33);
            button6.TabIndex = 9;
            button6.Text = "Load Image";
            button6.TextAlign = ContentAlignment.BottomLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(811, 538);
            button7.Name = "button7";
            button7.Size = new Size(160, 33);
            button7.TabIndex = 10;
            button7.Text = "Load Background";
            button7.TextAlign = ContentAlignment.BottomLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog1";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog1";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog1";
            // 
            // openFileDialog5
            // 
            openFileDialog5.FileName = "openFileDialog5";
            openFileDialog5.FileOk += openFileDialog5_FileOk;
            // 
            // button8
            // 
            button8.Location = new Point(190, 706);
            button8.Name = "button8";
            button8.Size = new Size(111, 33);
            button8.TabIndex = 11;
            button8.Text = "Subtraction";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(368, 668);
            button9.Name = "button9";
            button9.Size = new Size(168, 33);
            button9.TabIndex = 12;
            button9.Text = "Turn on Camera";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Copy", "GreyScale", "Invert", "Sepia", "Subtraction" });
            comboBox1.Location = new Point(368, 629);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 33);
            comboBox1.TabIndex = 13;
            // 
            // button10
            // 
            button10.Location = new Point(368, 707);
            button10.Name = "button10";
            button10.Size = new Size(168, 33);
            button10.TabIndex = 14;
            button10.Text = "Turn Off Camera";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 590);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 15;
            label1.Text = "Buttons for DIP 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 590);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 16;
            label2.Text = "Buttons for DIP 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 632);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 17;
            label3.Text = "Choose a Process";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1818, 764);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(comboBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(pictureBox3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private SaveFileDialog saveFileDialog1;
        private Button button5;
        private PictureBox pictureBox3;
        private Button button6;
        private Button button7;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
        private OpenFileDialog openFileDialog5;
        private Button button8;
        private Button button9;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Button button10;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}