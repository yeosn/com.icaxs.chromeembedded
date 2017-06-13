using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.icaxs.chromeembedded;

namespace ChromeEmbeddedTest
{
    public partial class Form1 : Form
    {
        private MyChromium browser = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new MyChromium("www.360.cn");

            this.Controls.Add(browser.GetBrowser());

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Shutdown();
        }
    }
}
