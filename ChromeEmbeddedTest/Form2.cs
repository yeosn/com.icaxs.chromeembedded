using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromiumInvoke;
using System.Reflection;

namespace ChromeEmbeddedTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ChromimuInvoke invoke = new ChromimuInvoke();
            //new ChromiumInvoke.InvokeForm().Show();
            Assembly asm = Assembly.LoadFrom(@"C:\Users\iCAE\Desktop\icads\ChromeEmbedded\ChromeEmbedded\bin\x86\Debug\ChromiumInvoke.dll");            
            string className = "ChromiumInvoke.InvokeForm";
            Type t = null;
            t = asm.GetType(className);
            object obj = t.Assembly.CreateInstance(className, true, BindingFlags.Default, null, null, null, null);
            ((Form)obj).Show();
                
         }
    }
}
