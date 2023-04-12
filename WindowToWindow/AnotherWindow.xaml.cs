using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WindowToWindow
{
    /// <summary>
    /// Interaction logic for AnotherWindow.xaml
    /// </summary>
    public partial class AnotherWindow : Window
    {
        public AnotherWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            wMan.displayMain();
        }
    }
}
