using WinFormsApp1.forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_logOff_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (form_Dashboard fd = new form_Dashboard())
            {
                fd.ShowDialog();
            };
        }
    }
}