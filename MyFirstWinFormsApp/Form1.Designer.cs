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
            btnNoSeven = new Button();
            btnNoEight = new Button();
            BtnNoNine = new Button();
            BtnNoFour = new Button();
            BtnNoFive = new Button();
            btnNoThree = new Button();
            btnNoOne = new Button();
            btnNoTwo = new Button();
            btnNoSix = new Button();
            txtEquation = new TextBox();
            SuspendLayout();
            // 
            // btnNoSeven
            // 
            btnNoSeven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoSeven.Location = new Point(4, 84);
            btnNoSeven.Name = "btnNoSeven";
            btnNoSeven.Size = new Size(75, 23);
            btnNoSeven.TabIndex = 0;
            btnNoSeven.Text = "7";
            btnNoSeven.UseVisualStyleBackColor = true;
            btnNoSeven.Click += btnNoSeven_Click;
            // 
            // btnNoEight
            // 
            btnNoEight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoEight.Location = new Point(85, 84);
            btnNoEight.Name = "btnNoEight";
            btnNoEight.Size = new Size(75, 23);
            btnNoEight.TabIndex = 1;
            btnNoEight.Text = "8";
            btnNoEight.UseMnemonic = false;
            btnNoEight.UseVisualStyleBackColor = true;
            btnNoEight.Click += btnNoEight_Click;
            // 
            // BtnNoNine
            // 
            BtnNoNine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNoNine.Location = new Point(166, 84);
            BtnNoNine.Name = "BtnNoNine";
            BtnNoNine.Size = new Size(75, 23);
            BtnNoNine.TabIndex = 2;
            BtnNoNine.Text = "9";
            BtnNoNine.UseVisualStyleBackColor = true;
            BtnNoNine.Click += BtnNoNine_Click;
            // 
            // BtnNoFour
            // 
            BtnNoFour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNoFour.Location = new Point(4, 113);
            BtnNoFour.Name = "BtnNoFour";
            BtnNoFour.Size = new Size(75, 23);
            BtnNoFour.TabIndex = 3;
            BtnNoFour.Text = "4";
            BtnNoFour.UseVisualStyleBackColor = true;
            BtnNoFour.Click += BtnNoFour_Click_1;
            // 
            // BtnNoFive
            // 
            BtnNoFive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnNoFive.Location = new Point(85, 113);
            BtnNoFive.Name = "BtnNoFive";
            BtnNoFive.Size = new Size(75, 23);
            BtnNoFive.TabIndex = 4;
            BtnNoFive.Text = "5";
            BtnNoFive.UseVisualStyleBackColor = true;
            BtnNoFive.Click += button1_Click;
            // 
            // btnNoThree
            // 
            btnNoThree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoThree.Location = new Point(166, 142);
            btnNoThree.Name = "btnNoThree";
            btnNoThree.Size = new Size(75, 23);
            btnNoThree.TabIndex = 5;
            btnNoThree.Text = "3";
            btnNoThree.UseVisualStyleBackColor = true;
            btnNoThree.Click += btnNoThree_Click;
            // 
            // btnNoOne
            // 
            btnNoOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoOne.Location = new Point(4, 142);
            btnNoOne.Name = "btnNoOne";
            btnNoOne.Size = new Size(75, 23);
            btnNoOne.TabIndex = 6;
            btnNoOne.Text = "1";
            btnNoOne.UseVisualStyleBackColor = true;
            btnNoOne.Click += btnNoOne_Click;
            // 
            // btnNoTwo
            // 
            btnNoTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoTwo.Location = new Point(85, 142);
            btnNoTwo.Name = "btnNoTwo";
            btnNoTwo.Size = new Size(75, 23);
            btnNoTwo.TabIndex = 7;
            btnNoTwo.Text = "2";
            btnNoTwo.UseVisualStyleBackColor = true;
            btnNoTwo.Click += btnNoTwo_Click;
            // 
            // btnNoSix
            // 
            btnNoSix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNoSix.Location = new Point(166, 113);
            btnNoSix.Name = "btnNoSix";
            btnNoSix.Size = new Size(75, 23);
            btnNoSix.TabIndex = 8;
            btnNoSix.Text = "6";
            btnNoSix.UseVisualStyleBackColor = true;
            btnNoSix.Click += btnNoSix_Click;
            // 
            // txtEquation
            // 
            txtEquation.Location = new Point(37, 23);
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(180, 23);
            txtEquation.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 276);
            Controls.Add(txtEquation);
            Controls.Add(btnNoSix);
            Controls.Add(btnNoTwo);
            Controls.Add(btnNoOne);
            Controls.Add(btnNoThree);
            Controls.Add(BtnNoFive);
            Controls.Add(BtnNoFour);
            Controls.Add(BtnNoNine);
            Controls.Add(btnNoEight);
            Controls.Add(btnNoSeven);
            Name = "Form1";
            Text = "Taschenrechner";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnNoFour_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnNoSeven;
        private Button btnNoEight;
        private Button BtnNoNine;
        private Button BtnNoFour;
        private Button BtnNoFive;
        private Button btnNoThree;
        private Button btnNoOne;
        private Button btnNoTwo;
        private Button btnNoSix;
        private TextBox txtEquation;
    }
}