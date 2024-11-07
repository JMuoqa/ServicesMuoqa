using Serilog;
using ServicesMuoqa.Views;

namespace ServicesMuoqa
{
    public partial class Inicio : Form
    {
        private readonly ViewMain _viewMain;
        public Inicio(ViewMain viewMain)
        {
            _viewMain = viewMain ?? throw new ArgumentNullException(nameof(viewMain));
            InitializeComponent();
            CallView(_viewMain);
        }
        private void CallView(object view)
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
                Form fh = view as Form;
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
            CallView(_viewMain);
        }
    }
}