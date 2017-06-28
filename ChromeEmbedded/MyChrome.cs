using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace ChromeEmbedded
{
    public class MyChromium : Control
    {
        /*
         * 当前的webkit的问题：
         *      如果在一个窗体中加载多个内容的话，则会使得内存增加过多，无法释放
         * 解决方法：
         *      可以将其设置为单独的程序，每次进行调用，调用前再将其关闭；
         *      类似于通力的报表程序
         */
        //private ControlCollection _parentControlCollection;
        //private CefSettings s_setting;
        private ChromiumWebBrowser chromeBrowser;
        //private void InitialSetting()
        //{
        //    if(s_setting==null)
        //    {
        //        s_setting = new CefSettings();
        //        // Initialize cef with the provided settings
        //        //Setting is initialized only once!
        //        Cef.Initialize(s_setting);
        //     }
        //}

        public void LoadUrl(String url)
        {
            chromeBrowser.Load(url);
        }

        public MyChromium(string url)
        {
            //InitialSetting();
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            //Setting is initialized only once!
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser(url);

            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        public Control GetBrowser()
        {
            return chromeBrowser;
        }


        public void Shutdown()
        {
            Cef.Shutdown();
        }
    }
}
