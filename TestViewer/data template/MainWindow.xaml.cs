﻿using System;
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
using System.Collections.ObjectModel;

namespace data_template
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
    }

    

    public class CarList
    {
        private string name;
        private string desc;

        public CarList() { }
        public CarList(string name, string desc)
        {
            this.Name = name;
            this.Desc = desc;
        }

        public string Name
        {
            get; set;
        }

        public string Desc
        {
            get; set;
        }
    }

    public class Cars : ObservableCollection<CarList>
    {
        public Cars() : base()
        {
            Add(new CarList("a", "b"));
        }   
    }
}


