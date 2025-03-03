﻿using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            Container = new Panel();
            Menu = new MenuStrip();
            informacionToolStripMenuItem = new ToolStripMenuItem();
            trabajosToolStripMenuItem = new ToolStripMenuItem();
            cargarToolStripMenuItem = new ToolStripMenuItem();
            estadisticasToolStripMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Container
            // 
            Container.BackColor = Color.FromArgb(10, 16, 25);
            Container.Location = new Point(12, 104);
            Container.Name = "Container";
            Container.Size = new Size(1239, 518);
            Container.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(20, 26, 35);
            Menu.Items.AddRange(new ToolStripItem[] { informacionToolStripMenuItem, trabajosToolStripMenuItem, estadisticasToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1263, 24);
            Menu.TabIndex = 1;
            Menu.Text = "menuStrip1";
            // 
            // informacionToolStripMenuItem
            // 
            informacionToolStripMenuItem.BackColor = Color.FromArgb(20, 26, 35);
            informacionToolStripMenuItem.ForeColor = Color.White;
            informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            informacionToolStripMenuItem.Size = new Size(89, 20);
            informacionToolStripMenuItem.Text = "ServiciosWeb";
            informacionToolStripMenuItem.Click += informacionToolStripMenuItem_Click;
            informacionToolStripMenuItem.Paint += ToolStripMenuItem_Paint;
            // 
            // trabajosToolStripMenuItem
            // 
            trabajosToolStripMenuItem.BackColor = Color.FromArgb(20, 26, 35);
            trabajosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarToolStripMenuItem });
            trabajosToolStripMenuItem.ForeColor = Color.White;
            trabajosToolStripMenuItem.Name = "trabajosToolStripMenuItem";
            trabajosToolStripMenuItem.Size = new Size(63, 20);
            trabajosToolStripMenuItem.Text = "Trabajos";
            trabajosToolStripMenuItem.Paint += ToolStripMenuItem_Paint;
            // 
            // cargarToolStripMenuItem
            // 
            cargarToolStripMenuItem.BackColor = Color.FromArgb(20, 26, 35);
            cargarToolStripMenuItem.ForeColor = Color.White;
            cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            cargarToolStripMenuItem.Size = new Size(172, 22);
            cargarToolStripMenuItem.Text = "Cargar y Modificar";
            cargarToolStripMenuItem.Click += cargarToolStripMenuItem_Click;
            cargarToolStripMenuItem.Paint += ToolStripMenuItem_Paint;
            // 
            // estadisticasToolStripMenuItem
            // 
            estadisticasToolStripMenuItem.BackColor = Color.FromArgb(20, 26, 35);
            estadisticasToolStripMenuItem.ForeColor = Color.White;
            estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            estadisticasToolStripMenuItem.Size = new Size(79, 20);
            estadisticasToolStripMenuItem.Text = "Estadisticas";
            estadisticasToolStripMenuItem.Click += estadisticasToolStripMenuItem_Click;
            estadisticasToolStripMenuItem.Paint += ToolStripMenuItem_Paint;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 16, 25);
            ClientSize = new Size(1263, 634);
            Controls.Add(Container);
            Controls.Add(Menu);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem trabajosToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem estadisticasToolStripMenuItem;
    }
}
