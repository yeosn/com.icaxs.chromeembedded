using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromeEmbedded;

namespace ChromiumInvoke
{
    public partial class InvokeForm : Form
    {
        private WebKit browser = null;
        public InvokeForm()
        {
            InitializeComponent();

            browser = new WebKit();
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.LoadUrl("www.baidu.com");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Shutdown();
        }

        private void btn_GO_Click(object sender, EventArgs e)
        {
            string url = this.textBox1.Text.Trim();
            browser.LoadUrl(url);
        }
    }
}
