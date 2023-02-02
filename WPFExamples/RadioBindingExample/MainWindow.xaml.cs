using CommunityToolkit.Mvvm.ComponentModel;
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

namespace RadioBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }
    }

    public class MainWindowVM : ObservableObject
    {
        private int _sexSwitch;

        public int SexSwitch
        {
            get => _sexSwitch;
            set { SetProperty(ref _sexSwitch, value); }
        }

        private Sex _sexSwitch1;

        public Sex SexSwitch1
        {
            get => _sexSwitch1;
            set { SetProperty(ref _sexSwitch1, value); }
        }

    }
    public enum Sex
    {
        男,
        女
    }
}
