namespace ServicesMuoqa
{
    partial class Inicio
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
            Container = new Panel();
            Menu = new MenuStrip();
            informacionToolStripMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Container
            // 
            Container.BackColor = Color.FromArgb(43, 44, 51);
            Container.Location = new Point(12, 104);
            Container.Name = "Container";
            Container.Size = new Size(1239, 518);
            Container.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackColor = Color.Transparent;
            Menu.Items.AddRange(new ToolStripItem[] { informacionToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1263, 24);
            Menu.TabIndex = 1;
            Menu.Text = "menuStrip1";
            // 
            // informacionToolStripMenuItem
            // 
            informacionToolStripMenuItem.ForeColor = Color.White;
            informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            informacionToolStripMenuItem.Size = new Size(89, 20);
            informacionToolStripMenuItem.Text = "ServiciosWeb";
            informacionToolStripMenuItem.Click += informacionToolStripMenuItem_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 44, 51);
            ClientSize = new Size(1263, 634);
            Controls.Add(Container);
            Controls.Add(Menu);
            ForeColor = Color.White;
            MainMenuStrip = Menu;
            Name = "Inicio";
            Text = "Inicio";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private new Panel Container;
        private MenuStrip Menu;
        private ToolStripMenuItem informacionToolStripMenuItem;
    }
}
