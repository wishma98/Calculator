namespace Calculator
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
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnSub = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblSymbol = new Label();
            lblAnswer = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(20, 115);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 23);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(101, 115);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 23);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(191, 115);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(281, 115);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 3;
            btnSub.Text = "/";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(20, 74);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(129, 23);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(227, 74);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(129, 23);
            txtNum2.TabIndex = 4;
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Font = new Font("Segoe UI", 14F);
            lblSymbol.Location = new Point(187, 77);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(0, 25);
            lblSymbol.TabIndex = 5;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 18F);
            lblAnswer.Location = new Point(430, 90);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 32);
            lblAnswer.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(383, 90);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 6;
            label1.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(20, 21);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 5;
            label2.Text = "Calculator";
            // 
            // button1
            // 
            button1.Location = new Point(29, 148);
            button1.Name = "button1";
            button1.Size = new Size(327, 40);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 199);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblAnswer);
            Controls.Add(label2);
            Controls.Add(lblSymbol);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnSub);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnSub;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblSymbol;
        private Label lblAnswer;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
