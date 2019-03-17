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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labyrinth
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index;
        public MainWindow()
        {
            InitializeComponent();
            DockPanel form = this.Content as DockPanel;
            int iter = 10;
            bool key;
            index = 1;
            Button bt = new Button { Content = index++, Background = Brushes.Black, BorderBrush = Brushes.Black, Foreground = Brushes.White };
            DockPanel.SetDock(bt, Dock.Left);
            form.Children.Add(bt);

            for (int i = 0; i < iter; i++)
            {
                key = i % 2 == 1;
                addButtons(form, key);
            }

        }

        private void addButtons(DockPanel form, bool key)
        {
            Dock[] dock = { Dock.Bottom, Dock.Right, Dock.Left, Dock.Top };
            Brush[] br1 = { Brushes.Black, Brushes.Black, Brushes.White,  Brushes.Black };
            Brush[] br2 = { Brushes.White, Brushes.White, Brushes.Black,  Brushes.White };
            Button btn;
            for (int i = 0; i < 4; i++)
            {
                if (key)
                {
                    btn = new Button { Content = index++, Background = br2[i], BorderBrush = br2[i], Foreground = br1[i] };
                }
                else
                {
                    btn = new Button { Content = index++, Background = br1[i], BorderBrush = br1[i], Foreground = br2[i] };
                }
                DockPanel.SetDock(btn, dock[i]);
                form.Children.Add(btn);
            }
        }
    }
}
