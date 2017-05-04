using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace UOFans_Launcher.Controls
{
    public class TabItemLink : TabItem
    {
        public string Link { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            e.Handled = true;
            Process.Start(Link);
        }
    }
}
