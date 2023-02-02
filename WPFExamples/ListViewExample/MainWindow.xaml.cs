using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using System.Configuration;

namespace ListViewExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Info Info { get; set; }
        public RelayCommand<string> TestCommand { get; set; }

        public ObservableCollection<Info> Infos { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Infos = new ObservableCollection<Info> { new Info { Name = "asee-asdfs", Yield = "14.8%" }, new Info { Name = "asee-asdfs", Yield = "35.8%" } };
            this.DataContext = this;
            TestCommand = new RelayCommand<string>(i => { MessageBox.Show(i); });
        }

        private void TestChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = Info;
            TestCommand.Execute(a.Yield);
        }
    }

    public class Info : ObservableObject
    {
        public string Name
        {
            get;
            set;
        }

        public string Yield { get; set; }


    }


}
