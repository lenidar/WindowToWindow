using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WindowToWindow
{
    internal static class wMan
    {
        public static void displayMain()
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        public static void displayAnother()
        {
            AnotherWindow aw = new AnotherWindow();
            aw.Show();
        }
    }
}
