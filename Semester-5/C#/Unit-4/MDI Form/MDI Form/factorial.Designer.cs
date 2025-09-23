namespace MDI_Form
{
    partial class factorial
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
            label1 = new Label();
            txtNumber = new TextBox();
            btnFactorial = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Number :";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(215, 44);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 1;
            // 
            // btnFactorial
            // 
            btnFactorial.Location = new Point(212, 97);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(94, 29);
            btnFactorial.TabIndex = 2;
            btnFactorial.Text = "Factorial";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += btnFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(147, 200);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result :";
            lblResult.Click += lblResult_Click;
            // 
            // factorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnFactorial);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "factorial";
            Text = "factorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private Button btnFactorial;
        private Label lblResult;
    }
}