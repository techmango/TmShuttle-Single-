using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TmShuttle
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew = false;
            using (System.Threading.Mutex m = new System.Threading.Mutex(true, Application.ProductName, out createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FrmMain());
                }
                else
                {
                    MessageBox.Show("Only one instance of this application is allowed!");
                }
            } 
            
        }
    }
}
