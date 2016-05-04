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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string id { get; set; }
        private string pw { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += OnLoad;
            //this.DataContext = viewmodel;
        }
        
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(ID);
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            id = ID.Text;
            pw = Passwd.Text;

            if(string.IsNullOrEmpty(id))
            {
                MessageBox.Show("id를 넣어주세요.");
                Keyboard.Focus(ID);
            }

            if(string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("pw를 넣어주세요.");
                Keyboard.Focus(Passwd);
            }

            doLogin();
        }

        private bool doLogin()
        {
            MessageBox.Show(string.Format("아이디={0}, 패스워드={1}", id, pw));
            return true;
        }
    }

//     public class viewmodel : INotifyPropertyChanged
//     {
// 
//         private void OnPropertyUpdate(string propertyName)
//         {
// 
//         }
//     }
}
