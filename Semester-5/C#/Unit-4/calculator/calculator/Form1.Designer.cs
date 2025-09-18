namespace calculator
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
            tb1 = new TextBox();
            operation = new Label();
            tb2 = new TextBox();
            label2 = new Label();
            l3 = new Label();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            l1 = new Label();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Location = new Point(282, 82);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 0;
            tb1.TextChanged += textBox1_TextChanged;
            // 
            // operation
            // 
            operation.AutoSize = true;
            operation.Location = new Point(432, 85);
            operation.Name = "operation";
            operation.Size = new Size(0, 20);
            operation.TabIndex = 1;
            // 
            // tb2
            // 
            tb2.Location = new Point(504, 82);
            tb2.Name = "tb2";
            tb2.Size = new Size(125, 27);
            tb2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(659, 85);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 3;
            label2.Text = "=";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(732, 85);
            l3.Name = "l3";
            l3.Size = new Size(0, 20);
            l3.TabIndex = 4;
            // 
            // b1
            // 
            b1.Location = new Point(279, 172);
            b1.Name = "b1";
            b1.Size = new Size(94, 29);
            b1.TabIndex = 5;
            b1.Text = "+";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(398, 175);
            b2.Name = "b2";
            b2.Size = new Size(94, 29);
            b2.TabIndex = 6;
            b2.Text = "-";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(516, 175);
            b3.Name = "b3";
            b3.Size = new Size(94, 29);
            b3.TabIndex = 7;
            b3.Text = "*";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Location = new Point(644, 175);
            b4.Name = "b4";
            b4.Size = new Size(94, 29);
            b4.TabIndex = 8;
            b4.Text = "/";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(433, 88);
            l1.Name = "l1";
            l1.Size = new Size(0, 20);
            l1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 520);
            Controls.Add(l1);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(l3);
            Controls.Add(label2);
            Controls.Add(tb2);
            Controls.Add(operation);
            Controls.Add(tb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private Label operation;
        private TextBox tb2;
        private Label label2;
        private Label l3;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Label l1;
    }
}
