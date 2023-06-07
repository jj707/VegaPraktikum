namespace MyFirstWinFormsApp
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
            txtEquation = new TextBox();
            btnMin = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btnNoSix = new Button();
            btnNoTwo = new Button();
            btnNoOne = new Button();
            btnNoThree = new Button();
            BtnNoFive = new Button();
            BtnNoFour = new Button();
            BtnNoNine = new Button();
            btnNoEight = new Button();
            btnDel = new Button();
            btnZero = new Button();
            btnEqual = new Button();
            btnPlus = new Button();
            btnSeven = new Button();
            SuspendLayout();
            // 
            // txtEquation
            // 
            txtEquation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEquation.BackColor = SystemColors.Control;
            txtEquation.BorderStyle = BorderStyle.None;
            txtEquation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEquation.Location = new Point(45, 36);
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(257, 26);
            txtEquation.TabIndex = 9;
            txtEquation.TextChanged += txtEquation_TextChanged;
            txtEquation.KeyPress += txtEquation_KeyPress;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMin.Location = new Point(255, 236);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(75, 52);
            btnMin.TabIndex = 24;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.Location = new Point(255, 178);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 52);
            btnDiv.TabIndex = 23;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(255, 120);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 52);
            btnMult.TabIndex = 22;
            btnMult.Text = "X";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnNoSix
            // 
            btnNoSix.Location = new Point(174, 178);
            btnNoSix.Name = "btnNoSix";
            btnNoSix.Size = new Size(75, 52);
            btnNoSix.TabIndex = 21;
            btnNoSix.Text = "6";
            btnNoSix.UseVisualStyleBackColor = true;
            btnNoSix.Click += btnNoSix_Click;
            // 
            // btnNoTwo
            // 
            btnNoTwo.Location = new Point(93, 236);
            btnNoTwo.Name = "btnNoTwo";
            btnNoTwo.Size = new Size(75, 52);
            btnNoTwo.TabIndex = 20;
            btnNoTwo.Text = "2";
            btnNoTwo.UseVisualStyleBackColor = true;
            btnNoTwo.Click += btnNoTwo_Click;
            // 
            // btnNoOne
            // 
            btnNoOne.Location = new Point(12, 236);
            btnNoOne.Name = "btnNoOne";
            btnNoOne.Size = new Size(75, 52);
            btnNoOne.TabIndex = 19;
            btnNoOne.Text = "1";
            btnNoOne.UseVisualStyleBackColor = true;
            btnNoOne.Click += btnNoOne_Click;
            // 
            // btnNoThree
            // 
            btnNoThree.Location = new Point(174, 236);
            btnNoThree.Name = "btnNoThree";
            btnNoThree.Size = new Size(75, 52);
            btnNoThree.TabIndex = 18;
            btnNoThree.Text = "3";
            btnNoThree.UseVisualStyleBackColor = true;
            btnNoThree.Click += btnNoThree_Click;
            // 
            // BtnNoFive
            // 
            BtnNoFive.Location = new Point(93, 178);
            BtnNoFive.Name = "BtnNoFive";
            BtnNoFive.Size = new Size(75, 52);
            BtnNoFive.TabIndex = 17;
            BtnNoFive.Text = "5";
            BtnNoFive.UseVisualStyleBackColor = true;
            BtnNoFive.Click += button1_Click;
            // 
            // BtnNoFour
            // 
            BtnNoFour.Location = new Point(12, 178);
            BtnNoFour.Name = "BtnNoFour";
            BtnNoFour.Size = new Size(75, 52);
            BtnNoFour.TabIndex = 16;
            BtnNoFour.Text = "4";
            BtnNoFour.UseVisualStyleBackColor = true;
            BtnNoFour.Click += BtnNoFour_Click_1;
            // 
            // BtnNoNine
            // 
            BtnNoNine.Location = new Point(174, 120);
            BtnNoNine.Name = "BtnNoNine";
            BtnNoNine.Size = new Size(75, 52);
            BtnNoNine.TabIndex = 15;
            BtnNoNine.Text = "9";
            BtnNoNine.UseVisualStyleBackColor = true;
            BtnNoNine.Click += BtnNoNine_Click;
            // 
            // btnNoEight
            // 
            btnNoEight.Location = new Point(93, 120);
            btnNoEight.Name = "btnNoEight";
            btnNoEight.Size = new Size(75, 52);
            btnNoEight.TabIndex = 14;
            btnNoEight.Text = "8";
            btnNoEight.UseMnemonic = false;
            btnNoEight.UseVisualStyleBackColor = true;
            btnNoEight.Click += btnNoEight_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(12, 294);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 52);
            btnDel.TabIndex = 25;
            btnDel.Text = "C";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(93, 294);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 52);
            btnZero.TabIndex = 26;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(174, 294);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 52);
            btnEqual.TabIndex = 27;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(255, 294);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 52);
            btnPlus.TabIndex = 28;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(12, 120);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 52);
            btnSeven.TabIndex = 29;
            btnSeven.Text = "7";
            btnSeven.UseMnemonic = false;
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnNoSeven_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 362);
            Controls.Add(btnSeven);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(btnZero);
            Controls.Add(btnDel);
            Controls.Add(btnMin);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnNoSix);
            Controls.Add(btnNoTwo);
            Controls.Add(btnNoOne);
            Controls.Add(btnNoThree);
            Controls.Add(BtnNoFive);
            Controls.Add(BtnNoFour);
            Controls.Add(BtnNoNine);
            Controls.Add(btnNoEight);
            Controls.Add(txtEquation);
            Name = "Form1";
            Text = "Taschenrechner";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox txtEquation;
        private Button btnMin;
        private Button btnDiv;
        private Button btnMult;
        private Button btnNoSix;
        private Button btnNoTwo;
        private Button btnNoOne;
        private Button btnNoThree;
        private Button BtnNoFive;
        private Button BtnNoFour;
        private Button BtnNoNine;
        private Button btnNoEight;
        private Button btnNoSeven;
        private Button btnDel;
        private Button btnZero;
        private Button btnEqual;
        private Button btnPlus;
        private Button btnSeven;
    }
}