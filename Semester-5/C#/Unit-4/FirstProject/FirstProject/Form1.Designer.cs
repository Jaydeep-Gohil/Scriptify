namespace FirstProject
{
    partial class Form1
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
            l1 = new Label();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            SuspendLayout();
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(355, 45);
            l1.Name = "l1";
            l1.Size = new Size(0, 20);
            l1.TabIndex = 0;
            // 
            // b1
            // 
            b1.Location = new Point(264, 129);
            b1.Name = "b1";
            b1.Size = new Size(94, 29);
            b1.TabIndex = 1;
            b1.Text = "Print";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(395, 132);
            b2.Name = "b2";
            b2.Size = new Size(94, 29);
            b2.TabIndex = 2;
            b2.Text = "clear";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(521, 132);
            b3.Name = "b3";
            b3.Size = new Size(94, 29);
            b3.TabIndex = 3;
            b3.Text = "Print Name ";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(l1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l1;
        private Button b1;
        private Button b2;
        private Button b3;
    }
}