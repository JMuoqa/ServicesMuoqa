using Microsoft.Extensions.DependencyInjection;
using Serilog;
using ServicesMuoqa.Views;
using System.Windows.Forms.DataVisualization.Charting;
namespace ServicesMuoqa
{
    public partial class Inicio : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Inicio(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            CallView(typeof(MainView));
        }
        private void CallView(Type view)
        {
            try
            {
                foreach (Control control in this.Container.Controls)
                {
                    if (control is Form)
                    {
                        control.Dispose();
                        this.Container.Controls.Remove(control);
                        break;
                    }
                }
                //Para obtener el servicio
                Form fh = _serviceProvider.GetService(view) as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Container.Controls.Add(fh);
                this.Container.Tag = fh;
                fh.Show();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallView(typeof(MainView));
        }
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallView(typeof(UploadJob));
        }
        private void ToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item.Selected)
            {
                // Color cuando se selecciona o pasa el ratón por encima
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(40, 46, 55)), e.ClipRectangle);
                item.ForeColor = Color.White;
            }
            else
            {
                // Color normal
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 26, 35)), e.ClipRectangle);
                item.ForeColor = Color.White;
            }

            // Dibuja el texto del ToolStripMenuItem
            TextRenderer.DrawText(e.Graphics, item.Text, item.Font, e.ClipRectangle, item.ForeColor);
        }
        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallView(typeof(StatisticsView));
        }
    }
}