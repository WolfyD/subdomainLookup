using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subdomainLookup
{
    public partial class f_Demo : Form
    {
        public string url { get; set; }

        public f_Demo()
        {
            InitializeComponent();

            Load += F_Demo_Load;
        }

        private void F_Demo_Load(object sender, EventArgs e)
        {
            tb_Url.Width = toolStrip1.Width - (btn_Close.Width + btn_Refresh.Width + 10);

            if(url != null && url != "")
            {
                tb_Url.Text = url;
                webBrowser1.Url = new Uri(url);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f_Demo_SizeChanged(object sender, EventArgs e)
        {
            tb_Url.Width = toolStrip1.Width - (btn_Close.Width + btn_Refresh.Width + 10);
        }
    }
}
