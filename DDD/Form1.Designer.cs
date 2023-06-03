namespace DDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            diaryEntry = new TextBox();
            addPict = new Button();
            createButton = new Button();
            closeButton = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox3 = new CheckBox();
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            label2 = new Label();
            memOrMeh = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memOrMeh).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MistyRose;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(593, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // diaryEntry
            // 
            diaryEntry.BackColor = Color.MistyRose;
            diaryEntry.BorderStyle = BorderStyle.FixedSingle;
            diaryEntry.Location = new Point(26, 155);
            diaryEntry.Multiline = true;
            diaryEntry.Name = "diaryEntry";
            diaryEntry.Size = new Size(527, 180);
            diaryEntry.TabIndex = 3;
            diaryEntry.Text = " ";
            // 
            // addPict
            // 
            addPict.BackColor = Color.Snow;
            addPict.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addPict.ForeColor = Color.Black;
            addPict.Location = new Point(664, 280);
            addPict.Name = "addPict";
            addPict.Size = new Size(94, 29);
            addPict.TabIndex = 5;
            addPict.Text = "Add";
            addPict.UseVisualStyleBackColor = false;
            addPict.Click += addPict_Click;
            addPict.MouseHover += addPict_MouseHover;
            // 
            // createButton
            // 
            createButton.BackgroundImageLayout = ImageLayout.None;
            createButton.FlatAppearance.BorderColor = Color.Sienna;
            createButton.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(594, 358);
            createButton.Name = "createButton";
            createButton.Size = new Size(104, 53);
            createButton.TabIndex = 6;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += button3_Click;
            createButton.MouseHover += button3_MouseHover;
            // 
            // closeButton
            // 
            closeButton.BackgroundImageLayout = ImageLayout.None;
            closeButton.FlatAppearance.BorderColor = Color.Sienna;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeButton.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(732, 358);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(104, 53);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += button4_Click;
            closeButton.MouseHover += button4_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 8;
            label1.Text = "Today's Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(641, 34);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 10;
            label3.Text = "Today's Vibes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 188);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(743, 9);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Sienna;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MistyRose;
            label6.Location = new Point(12, 121);
            label6.Name = "label6";
            label6.Size = new Size(145, 30);
            label6.TabIndex = 13;
            label6.Text = "Today's Moves:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 306);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(415, 314);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(432, 338);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(311, 387);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(216, 25);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Creativity/Inspiration";
            checkBox1.TextAlign = ContentAlignment.TopCenter;
            checkBox1.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox1.ThreeState = true;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackgroundImageLayout = ImageLayout.Center;
            checkBox2.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(26, 387);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(107, 25);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Self-Care";
            checkBox2.TextAlign = ContentAlignment.TopCenter;
            checkBox2.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBox2.ThreeState = true;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(255, 192, 192);
            radioButton1.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Sienna;
            radioButton1.Location = new Point(56, 82);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 29);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Memorable!";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(255, 192, 192);
            radioButton2.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Sienna;
            radioButton2.Location = new Point(281, 82);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 29);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Meh.\r\n";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(163, 387);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(131, 25);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Family Time";
            checkBox3.TextImageRelation = TextImageRelation.TextBeforeImage;
            checkBox3.ThreeState = true;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.InitialDirectory = "@\"C:\\Users\\lexim\\VS Projects\"";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton3, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(848, 27);
            toolStrip1.TabIndex = 24;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = SystemColors.Control;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ForeColor = Color.FromArgb(192, 192, 255);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Diary Index";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "New File";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "Save Entry";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 86);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 27;
            label2.Text = "OR";
            // 
            // memOrMeh
            // 
            memOrMeh.Location = new Point(432, 34);
            memOrMeh.Name = "memOrMeh";
            memOrMeh.Size = new Size(100, 100);
            memOrMeh.TabIndex = 28;
            memOrMeh.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.MenuBar;
            dateTimePicker1.Location = new Point(151, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Ink Free", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(128, 64, 64);
            label10.Location = new Point(157, 349);
            label10.Name = "label10";
            label10.Size = new Size(203, 27);
            label10.TabIndex = 25;
            label10.Text = "Today I prioritized:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            CancelButton = closeButton;
            ClientSize = new Size(848, 467);
            Controls.Add(dateTimePicker1);
            Controls.Add(memOrMeh);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(checkBox3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(createButton);
            Controls.Add(addPict);
            Controls.Add(pictureBox1);
            Controls.Add(diaryEntry);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Dear Digital Diary";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memOrMeh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox diaryEntry;
        private Button addPict;
        private Button createButton;
        private Button closeButton;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox3;
        private SaveFileDialog saveFileDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog3;
        private Label label2;
        private PictureBox memOrMeh;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private ToolStripButton toolStripButton3;
    }
}