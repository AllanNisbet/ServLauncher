using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UOFans_Launcher.Controls
{
    public class TabItemExit : TabItem
    {
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}