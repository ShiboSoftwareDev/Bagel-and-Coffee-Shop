namespace Bagel_and_Coffee_Shop
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pick a Bagel";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 51);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Whole wheat ($1.50)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "White ($1.25)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(29, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pick Your Toppings";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Location = new Point(650, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Want Coffee with That?";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(650, 232);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Price";
            // 
            // button1
            // 
            button1.Location = new Point(699, 373);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 2;
            button1.Text = "Calculate Total";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(708, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Reset Form";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(725, 460);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Cream cheese ($.50)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 31);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Butter ($.25)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(14, 74);
            checkBox3.Name = "checkBox3";
            checkBox3.RightToLeft = RightToLeft.No;
            checkBox3.Size = new Size(131, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Blueberry jam ($.75)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 99);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(133, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Raspberry jam ($.75)";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(14, 124);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(114, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Peach jelly ($.75)";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(9, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "None";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(9, 35);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(141, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Regular Coffee ($1.25)";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(9, 56);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(127, 19);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "Cappuccino ($2.00)";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(5, 76);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(122, 19);
            radioButton6.TabIndex = 3;
            radioButton6.TabStop = true;
            radioButton6.Text = "Cafe au lait ($1.75)";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(112, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(112, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(112, 72);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 28);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 45);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 70);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(883, 516);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
