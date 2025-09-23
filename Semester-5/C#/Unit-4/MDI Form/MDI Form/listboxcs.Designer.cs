namespace MDI_Form
{
    partial class listboxcs
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
            lstWife = new ListBox();
            cmbHusband = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            cmdAdd = new Button();
            cmdRemove = new Button();
            cmdShow = new Button();
            groupBox1 = new GroupBox();
            rdoWife = new RadioButton();
            rdoHus = new RadioButton();
            lbl3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstWife
            // 
            lstWife.FormattingEnabled = true;
            lstWife.Items.AddRange(new object[] { "Sita", "Urmila", "Mandvi", "Shrutakiriti" });
            lstWife.Location = new Point(115, 72);
            lstWife.Name = "lstWife";
            lstWife.Size = new Size(150, 104);
            lstWife.TabIndex = 0;
            lstWife.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cmbHusband
            // 
            cmbHusband.FormattingEnabled = true;
            cmbHusband.Items.AddRange(new object[] { "Ram", "Laxman", "Bharat", "Shatruganj" });
            cmbHusband.Location = new Point(480, 72);
            cmbHusband.Name = "cmbHusband";
            cmbHusband.Size = new Size(151, 28);
            cmbHusband.TabIndex = 1;
            cmbHusband.SelectedIndexChanged += Husand_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 216);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Name :";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(344, 216);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // cmdAdd
            // 
            cmdAdd.Location = new Point(130, 392);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(107, 44);
            cmdAdd.TabIndex = 6;
            cmdAdd.Text = "Add";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdRemove
            // 
            cmdRemove.Location = new Point(263, 392);
            cmdRemove.Name = "cmdRemove";
            cmdRemove.Size = new Size(107, 44);
            cmdRemove.TabIndex = 7;
            cmdRemove.Text = "Remove";
            cmdRemove.UseVisualStyleBackColor = true;
            cmdRemove.Click += cmdRemove_Click;
            // 
            // cmdShow
            // 
            cmdShow.Location = new Point(411, 392);
            cmdShow.Name = "cmdShow";
            cmdShow.Size = new Size(107, 44);
            cmdShow.TabIndex = 8;
            cmdShow.Text = "Show";
            cmdShow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoWife);
            groupBox1.Controls.Add(rdoHus);
            groupBox1.Location = new Point(203, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 96);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoWife
            // 
            rdoWife.AutoSize = true;
            rdoWife.Location = new Point(58, 50);
            rdoWife.Name = "rdoWife";
            rdoWife.Size = new Size(61, 24);
            rdoWife.TabIndex = 1;
            rdoWife.TabStop = true;
            rdoWife.Text = "Wife";
            rdoWife.UseVisualStyleBackColor = true;
            // 
            // rdoHus
            // 
            rdoHus.AutoSize = true;
            rdoHus.Location = new Point(57, 17);
            rdoHus.Name = "rdoHus";
            rdoHus.Size = new Size(80, 24);
            rdoHus.TabIndex = 0;
            rdoHus.TabStop = true;
            rdoHus.Text = "Husand";
            rdoHus.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            lbl3.BackColor = Color.Pink;
            lbl3.Location = new Point(12, 9);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(759, 45);
            lbl3.TabIndex = 10;
            // 
            // listboxcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl3);
            Controls.Add(groupBox1);
            Controls.Add(cmdShow);
            Controls.Add(cmdRemove);
            Controls.Add(cmdAdd);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(cmbHusband);
            Controls.Add(lstWife);
            Name = "listboxcs";
            Text = "listboxcs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstWife;
        private ComboBox cmbHusband;
        private Label label1;
        private TextBox txtName;
        private Button cmdAdd;
        private Button cmdRemove;
        private Button cmdShow;
        private GroupBox groupBox1;
        private RadioButton rdoWife;
        private RadioButton rdoHus;
        private Label lbl3;
    }
}