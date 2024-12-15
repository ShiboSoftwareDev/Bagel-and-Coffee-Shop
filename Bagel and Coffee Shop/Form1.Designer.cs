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
            radWheat = new RadioButton();
            radWhite = new RadioButton();
            groupBox2 = new GroupBox();
            chkPeach = new CheckBox();
            chkRaspberry = new CheckBox();
            chkBlueberry = new CheckBox();
            chkButter = new CheckBox();
            chkCreamCheese = new CheckBox();
            groupBox3 = new GroupBox();
            radCafeAuLait = new RadioButton();
            radCappuccino = new RadioButton();
            radRegCoffee = new RadioButton();
            radNoCoffee = new RadioButton();
            groupBox4 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblTotal = new Label();
            lblTax = new Label();
            lblSubtotal = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radWheat);
            groupBox1.Controls.Add(radWhite);
            groupBox1.ForeColor = Color.FromArgb(53, 26, 0);
            groupBox1.Location = new Point(26, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pick a Bagel";
            // 
            // radWheat
            // 
            radWheat.AutoSize = true;
            radWheat.Font = new Font("Segoe UI", 12F);
            radWheat.Location = new Point(14, 66);
            radWheat.Name = "radWheat";
            radWheat.Size = new Size(172, 25);
            radWheat.TabIndex = 1;
            radWheat.Text = "Whole wheat ($1.50)";
            radWheat.UseVisualStyleBackColor = true;
            radWheat.CheckedChanged += radWheat_CheckedChanged;
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Checked = true;
            radWhite.Font = new Font("Segoe UI", 12F);
            radWhite.Location = new Point(14, 35);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(122, 25);
            radWhite.TabIndex = 0;
            radWhite.TabStop = true;
            radWhite.Text = "White ($1.25)";
            radWhite.UseVisualStyleBackColor = true;
            radWhite.CheckedChanged += radWhite_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkPeach);
            groupBox2.Controls.Add(chkRaspberry);
            groupBox2.Controls.Add(chkBlueberry);
            groupBox2.Controls.Add(chkButter);
            groupBox2.Controls.Add(chkCreamCheese);
            groupBox2.ForeColor = Color.FromArgb(53, 26, 0);
            groupBox2.Location = new Point(26, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pick Your Toppings";
            // 
            // chkPeach
            // 
            chkPeach.AutoSize = true;
            chkPeach.Font = new Font("Segoe UI", 12F);
            chkPeach.Location = new Point(14, 163);
            chkPeach.Name = "chkPeach";
            chkPeach.Size = new Size(145, 25);
            chkPeach.TabIndex = 4;
            chkPeach.Text = "Peach jelly ($.75)";
            chkPeach.UseVisualStyleBackColor = true;
            chkPeach.CheckedChanged += chkPeach_CheckedChanged;
            // 
            // chkRaspberry
            // 
            chkRaspberry.AutoSize = true;
            chkRaspberry.Font = new Font("Segoe UI", 12F);
            chkRaspberry.Location = new Point(14, 132);
            chkRaspberry.Name = "chkRaspberry";
            chkRaspberry.Size = new Size(174, 25);
            chkRaspberry.TabIndex = 3;
            chkRaspberry.Text = "Raspberry jam ($.75)";
            chkRaspberry.UseVisualStyleBackColor = true;
            chkRaspberry.CheckedChanged += chkRaspberry_CheckedChanged;
            // 
            // chkBlueberry
            // 
            chkBlueberry.AutoSize = true;
            chkBlueberry.Font = new Font("Segoe UI", 12F);
            chkBlueberry.Location = new Point(14, 101);
            chkBlueberry.Name = "chkBlueberry";
            chkBlueberry.RightToLeft = RightToLeft.No;
            chkBlueberry.Size = new Size(170, 25);
            chkBlueberry.TabIndex = 2;
            chkBlueberry.Text = "Blueberry jam ($.75)";
            chkBlueberry.UseVisualStyleBackColor = true;
            chkBlueberry.CheckedChanged += chkBlueberry_CheckedChanged;
            // 
            // chkButter
            // 
            chkButter.AutoSize = true;
            chkButter.Font = new Font("Segoe UI", 12F);
            chkButter.Location = new Point(14, 70);
            chkButter.Name = "chkButter";
            chkButter.Size = new Size(115, 25);
            chkButter.TabIndex = 1;
            chkButter.Text = "Butter ($.25)";
            chkButter.UseVisualStyleBackColor = true;
            chkButter.CheckedChanged += chkButter_CheckedChanged;
            // 
            // chkCreamCheese
            // 
            chkCreamCheese.AutoSize = true;
            chkCreamCheese.Font = new Font("Segoe UI", 12F);
            chkCreamCheese.Location = new Point(14, 39);
            chkCreamCheese.Name = "chkCreamCheese";
            chkCreamCheese.Size = new Size(170, 25);
            chkCreamCheese.TabIndex = 0;
            chkCreamCheese.Text = "Cream cheese ($.50)";
            chkCreamCheese.UseVisualStyleBackColor = true;
            chkCreamCheese.CheckedChanged += chkCreamCheese_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radCafeAuLait);
            groupBox3.Controls.Add(radCappuccino);
            groupBox3.Controls.Add(radRegCoffee);
            groupBox3.Controls.Add(radNoCoffee);
            groupBox3.ForeColor = Color.FromArgb(53, 26, 0);
            groupBox3.Location = new Point(641, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 185);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Want Coffee with That?";
            // 
            // radCafeAuLait
            // 
            radCafeAuLait.AutoSize = true;
            radCafeAuLait.Font = new Font("Segoe UI", 12F);
            radCafeAuLait.Location = new Point(18, 128);
            radCafeAuLait.Name = "radCafeAuLait";
            radCafeAuLait.Size = new Size(158, 25);
            radCafeAuLait.TabIndex = 3;
            radCafeAuLait.Text = "Cafe au lait ($1.75)";
            radCafeAuLait.UseVisualStyleBackColor = true;
            radCafeAuLait.CheckedChanged += radCafeAuLait_CheckedChanged;
            // 
            // radCappuccino
            // 
            radCappuccino.AutoSize = true;
            radCappuccino.Font = new Font("Segoe UI", 12F);
            radCappuccino.Location = new Point(18, 97);
            radCappuccino.Name = "radCappuccino";
            radCappuccino.Size = new Size(162, 25);
            radCappuccino.TabIndex = 2;
            radCappuccino.Text = "Cappuccino ($2.00)";
            radCappuccino.UseVisualStyleBackColor = true;
            radCappuccino.CheckedChanged += radCappuccino_CheckedChanged;
            // 
            // radRegCoffee
            // 
            radRegCoffee.AutoSize = true;
            radRegCoffee.Font = new Font("Segoe UI", 12F);
            radRegCoffee.Location = new Point(18, 66);
            radRegCoffee.Name = "radRegCoffee";
            radRegCoffee.Size = new Size(184, 25);
            radRegCoffee.TabIndex = 1;
            radRegCoffee.Text = "Regular Coffee ($1.25)";
            radRegCoffee.UseVisualStyleBackColor = true;
            radRegCoffee.CheckedChanged += radRegCoffee_CheckedChanged;
            // 
            // radNoCoffee
            // 
            radNoCoffee.AutoSize = true;
            radNoCoffee.Checked = true;
            radNoCoffee.Font = new Font("Segoe UI", 12F);
            radNoCoffee.Location = new Point(18, 35);
            radNoCoffee.Name = "radNoCoffee";
            radNoCoffee.Size = new Size(66, 25);
            radNoCoffee.TabIndex = 0;
            radNoCoffee.TabStop = true;
            radNoCoffee.Text = "None";
            radNoCoffee.UseVisualStyleBackColor = true;
            radNoCoffee.CheckedChanged += radNoCoffee_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(lblTotal);
            groupBox4.Controls.Add(lblTax);
            groupBox4.Controls.Add(lblSubtotal);
            groupBox4.ForeColor = Color.FromArgb(53, 26, 0);
            groupBox4.Location = new Point(641, 242);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(209, 127);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(49, 87);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 9;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(60, 56);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 8;
            label5.Text = "Tax";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 25);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 7;
            label4.Text = "Subtotal";
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(112, 85);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "$0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTax
            // 
            lblTax.BorderStyle = BorderStyle.FixedSingle;
            lblTax.Font = new Font("Segoe UI", 12F);
            lblTax.Location = new Point(112, 54);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(60, 25);
            lblTax.TabIndex = 5;
            lblTax.Text = "$0.00";
            lblTax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Font = new Font("Segoe UI", 12F);
            lblSubtotal.Location = new Point(112, 23);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(60, 25);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "$0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.ForeColor = Color.FromArgb(53, 26, 0);
            btnCalculate.Location = new Point(670, 406);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 25);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.ForeColor = Color.FromArgb(53, 26, 0);
            btnReset.Location = new Point(690, 437);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 25);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.FromArgb(53, 26, 0);
            btnExit.Location = new Point(709, 468);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 25);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(883, 516);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bagel and Coffee Price Calculator";
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
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private RadioButton radWheat;
        private RadioButton radWhite;
        private CheckBox chkPeach;
        private CheckBox chkRaspberry;
        private CheckBox chkBlueberry;
        private CheckBox chkButter;
        private CheckBox chkCreamCheese;
        private RadioButton radCafeAuLait;
        private RadioButton radCappuccino;
        private RadioButton radRegCoffee;
        private RadioButton radNoCoffee;
        private Label lblTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
