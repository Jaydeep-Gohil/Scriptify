namespace MDI_Form
{
    partial class hello_world
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            tb1 = new TextBox();
            SuspendLayout();
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.ImageAlign = ContentAlignment.MiddleRight;
            l1.Location = new Point(376, 186);
            l1.Name = "l1";
            l1.Size = new Size(0, 20);
            l1.TabIndex = 0;
            l1.TextAlign = ContentAlignment.MiddleCenter;
            l1.Click += l1_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(298, 99);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 1;
            btn1.Text = "Print";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(417, 100);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 2;
            btn2.Text = "Clear";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(537, 100);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 3;
            btn3.Text = "UserName";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(376, 43);
            tb1.Name = "tb1";
            tb1.Size = new Size(167, 27);
            tb1.TabIndex = 4;
            // 
            // hello_world
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 450);
            Controls.Add(tb1);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(l1);
            Name = "hello_world";
            Text = "hello_world";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private TextBox tb1;
    }
}