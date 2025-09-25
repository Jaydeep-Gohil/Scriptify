namespace MDI_Form
{
    partial class mdi
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
            menuStrip1 = new MenuStrip();
            unit4ToolStripMenuItem = new ToolStripMenuItem();
            simpleHelloToolStripMenuItem = new ToolStripMenuItem();
            simpleInterstToolStripMenuItem = new ToolStripMenuItem();
            calculatorToolStripMenuItem = new ToolStripMenuItem();
            factorialToolStripMenuItem = new ToolStripMenuItem();
            unit5ToolStripMenuItem = new ToolStripMenuItem();
            listboxToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { unit4ToolStripMenuItem, unit5ToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1351, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // unit4ToolStripMenuItem
            // 
            unit4ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { simpleHelloToolStripMenuItem, simpleInterstToolStripMenuItem, calculatorToolStripMenuItem, factorialToolStripMenuItem, formToolStripMenuItem });
            unit4ToolStripMenuItem.Name = "unit4ToolStripMenuItem";
            unit4ToolStripMenuItem.Size = new Size(72, 24);
            unit4ToolStripMenuItem.Text = "Unit - 4";
            // 
            // simpleHelloToolStripMenuItem
            // 
            simpleHelloToolStripMenuItem.Name = "simpleHelloToolStripMenuItem";
            simpleHelloToolStripMenuItem.Size = new Size(224, 26);
            simpleHelloToolStripMenuItem.Text = "Simple Hello";
            simpleHelloToolStripMenuItem.Click += simpleHelloToolStripMenuItem_Click;
            // 
            // simpleInterstToolStripMenuItem
            // 
            simpleInterstToolStripMenuItem.Name = "simpleInterstToolStripMenuItem";
            simpleInterstToolStripMenuItem.Size = new Size(224, 26);
            simpleInterstToolStripMenuItem.Text = "Simple Interst";
            simpleInterstToolStripMenuItem.Click += simpleInterstToolStripMenuItem_Click;
            // 
            // calculatorToolStripMenuItem
            // 
            calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            calculatorToolStripMenuItem.Size = new Size(224, 26);
            calculatorToolStripMenuItem.Text = "Calculator";
            calculatorToolStripMenuItem.Click += calculatorToolStripMenuItem_Click;
            // 
            // factorialToolStripMenuItem
            // 
            factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            factorialToolStripMenuItem.Size = new Size(224, 26);
            factorialToolStripMenuItem.Text = "Factorial";
            factorialToolStripMenuItem.Click += factorialToolStripMenuItem_Click;
            // 
            // unit5ToolStripMenuItem
            // 
            unit5ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listboxToolStripMenuItem });
            unit5ToolStripMenuItem.Name = "unit5ToolStripMenuItem";
            unit5ToolStripMenuItem.Size = new Size(72, 24);
            unit5ToolStripMenuItem.Text = "Unit - 5";
            unit5ToolStripMenuItem.Click += unit5ToolStripMenuItem_Click;
            // 
            // listboxToolStripMenuItem
            // 
            listboxToolStripMenuItem.Name = "listboxToolStripMenuItem";
            listboxToolStripMenuItem.Size = new Size(224, 26);
            listboxToolStripMenuItem.Text = "Listbox";
            listboxToolStripMenuItem.Click += listboxToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // formToolStripMenuItem
            // 
            formToolStripMenuItem.Name = "formToolStripMenuItem";
            formToolStripMenuItem.Size = new Size(224, 26);
            formToolStripMenuItem.Text = "Form";
            formToolStripMenuItem.Click += formToolStripMenuItem_Click;
            // 
            // mdi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 512);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mdi";
            Text = "Jaydeep 14";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem unit4ToolStripMenuItem;
        private ToolStripMenuItem unit5ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem simpleHelloToolStripMenuItem;
        private ToolStripMenuItem simpleInterstToolStripMenuItem;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private ToolStripMenuItem factorialToolStripMenuItem;
        private ToolStripMenuItem listboxToolStripMenuItem;
        private ToolStripMenuItem formToolStripMenuItem;
    }
}
