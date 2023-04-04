using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.forms
{
    public partial class form_Dashboard : Form
    {
        int panelWidth;
        bool isCollapsed;
        public form_Dashboard()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
            time_timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)

        {


            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;

                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }

            }
            else
            {
                panelLeft.Width = panelLeft.Width-10 ;

                if (panelLeft.Width <= 58)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btn_dropDown_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_logOff2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }
        private void moveSidePanel(Control btn)
        {
            sidePanel.Top = btn.Top;

        }
        // Top property :Gets or sets the distance, in pixels, between the top edge of the control and the top edge of its container's client area.
        // sidepanel distance from the parent container will equal to home btn distance from parent container.

        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
        }

        private void btn_saleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_saleBooks);
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_purchase);
        }

        private void btn_expenses_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_expenses);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_sales);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_settings);
        }

        private void time_timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_time.Text = dt.ToString("HH:MM:ss");
        }
    }
}
