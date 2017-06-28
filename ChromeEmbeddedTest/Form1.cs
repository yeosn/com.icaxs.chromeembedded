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

namespace ChromeEmbeddedTest
{
    public partial class Form1 : Form
    {
        //private MyChromium browser = null;
        private WebKit browser = null;
        public Form1()
        {
            InitializeComponent();

            browser = new WebKit();
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.LoadUrl("www.baidu.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Shutdown();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            //browser.LoadUrl("www.360.cn");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = this.textBox1.Text.Trim();
            browser.LoadUrl(url);
        }
    }
}
