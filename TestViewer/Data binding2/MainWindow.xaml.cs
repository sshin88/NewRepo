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
using System.ComponentModel;

namespace Data_binding2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {           
        public MainWindow()
        {
            InitializeComponent();

            NotifyTest NotiTest = new NotifyTest();

            this.DataContext = NotiTest;
        }
    }

    //view model
    public class NotifyTest : INotifyPropertyChanged
    {   
        ColorName Color = new ColorName();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return Color.Name; }
            set
            {
                Color.Name = value;
                OnPropertyChanged("Name");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    //model
    public class ColorName
    {
        private string name = "red";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

    }
}
