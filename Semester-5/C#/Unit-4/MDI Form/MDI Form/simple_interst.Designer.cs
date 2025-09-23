namespace MDI_Form
{
    partial class simple_interst
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
            txtPrincipal = new TextBox();
            lable2 = new Label();
            label2 = new Label();
            txtRate = new TextBox();
            txtTime = new TextBox();
            Calculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 62);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Principal";
            // 
            // txtPrincipal
            // 
            txtPrincipal.Location = new Point(245, 60);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(125, 27);
            txtPrincipal.TabIndex = 1;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(141, 98);
            lable2.Name = "lable2";
            lable2.Size = new Size(65, 20);
            lable2.TabIndex = 2;
            lable2.Text = "Rate (%)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 136);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Time (Year)";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(246, 101);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(125, 27);
            txtRate.TabIndex = 4;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(247, 139);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 5;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(137, 209);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(94, 29);
            Calculate.TabIndex = 6;
            Calculate.Text = "Calculat";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(101, 302);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result :";
            // 
            // simple_interst
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 468);
            Controls.Add(lblResult);
            Controls.Add(Calculate);
            Controls.Add(txtTime);
            Controls.Add(txtRate);
            Controls.Add(label2);
            Controls.Add(lable2);
            Controls.Add(txtPrincipal);
            Controls.Add(label1);
            Name = "simple_interst";
            Text = "simple_interst";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrincipal;
        private Label lable2;
        private Label label2;
        private TextBox txtRate;
        private TextBox txtTime;
        private Button Calculate;
        private Label lblResult;
    }
}