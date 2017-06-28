using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace ChromeEmbedded
{
    public partial class WebKit : UserControl
    {
        private ChromiumWebBrowser _webkit;

        public WebKit()
        {
            InitializeComponent();
            InitialSetting();
        }

        public void LoadUrl(String url)
        {
            if(this._webkit == null)
            {
                InitialBrowser(url);
            }
            else
            {
                _webkit.Load(url);
            }            
        }

        public WebKit(string url)
        {
            InitialSetting();
            InitialBrowser(url);
        }

        private void InitialSetting()
        {
            if (!Cef.IsInitialized)
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }
        }

        private void InitialBrowser(string url)
        {
            _webkit = new ChromiumWebBrowser(url);
            this.Controls.Add(_webkit);
            _webkit.Dock = DockStyle.Fill;
        }

        public Control GetBrowser()
        {
            return _webkit;
        }


        public void Shutdown()
        {
            Cef.Shutdown();
        }
    }
}
