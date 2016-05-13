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
using System.Collections;

namespace DataSourceBinding
{
    /// <summary>
    /// Interaction logic for ObjectDataProvider.xaml
    /// </summary>
    public partial class ObjectDataProvider : Window
    {
        public ObjectDataProvider()
        {
            InitializeComponent();
        }
    }

    public class MyStrings : List
    {
        public MyStrings()
        {   
//             this.Add("hellow");
//             this.Add("GoodBye");
//             this.Add("Heya");
        }
    }
}
