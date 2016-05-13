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

namespace Dependency_Property
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //1. UserProperty 등록
        public static readonly DependencyProperty UserProperty = DependencyProperty.Register(
            "TextChange",
            typeof(String),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(new PropertyChangedCallback(OnTextChangePropertyChanged)));

        //2. callback 구현
        private static void OnTextChangePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MainWindow userNameControl = d as MainWindow;
            string newText = (string)e.NewValue;
            string oldText = (string)e.OldValue;

            userNameControl.txtNewText.Text = newText;
            userNameControl.txtOldText.Text = oldText;
        }

        //3. Dependency Property 의 Property 생성
        public String UserText
        {
            get { return (String)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            UserText = textBox1.Text;
        }
    }
}
