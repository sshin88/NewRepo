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

namespace Command
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

    public class AddCommand : ICommand
    {
        private string desc = "add";
        public string Desc
        {
            get { return desc; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            System.Diagnostics.Debug.WriteLine("add명령 실행");
        }
    }

    public class DeleteCommand<T> : ICommand
    {
        Action<T> m_ExecuteTargets = delegate { };
        Func<bool> m_CanExecuteTargets = delegate { return false; };

        bool m_Enable = false;

        public bool CanExecute(object parameter)
        {
            Delegate[] targets = m_CanExecuteTargets.GetInvocationList();
            foreach(Func<bool> target in targets)
            {
                m_Enable = false;

                bool localenable = target.Invoke();
                if(localenable)
                {
                    m_Enable = true;
                    break;
                }
            }

            return m_Enable;
        }

        public void Execute(object parameter)
        {
            if(CanExecute(parameter) == true)
            {
                m_ExecuteTargets(parameter != null ? (T)parameter : default(T));
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


    }


}
