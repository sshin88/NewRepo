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
using System.IO;
using Microsoft.Win32;

namespace TestViewer
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

        private void LoadRawImageBtn_clicked(object sender, RoutedEventArgs e)
        {
            //show open dialog
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Raw Files(*.raw)|*.raw";

            Nullable<bool> bOpen = openDialog.ShowDialog();
            if(bOpen == true)
            {
                string fileName = openDialog.FileName;
                
                //load raw file
                FileStream fs = new FileStream(fileName, FileMode.Open);

                BinaryReader br = new BinaryReader(fs);
                ushort UPixel = 0;

                long iTotalSize = br.BaseStream.Length;
                int iNumPixelCount = (int)(iTotalSize / 2);

                canvas.Width = 2560;
                canvas.Height = 3072;

                image.Width = 2560;
                image.Height = 3072;

                ushort[] pixel16 = null;
                pixel16 = new ushort[iNumPixelCount];

                for(int i = 0; i < iNumPixelCount; i++)
                {
                    pixel16[i] = (ushort)br.ReadInt16();
                }
                br.Close();


                int bitsPerPixel = 16;
                int stride = (2560 * bitsPerPixel + 7) / 8;

                BitmapSource bmps = BitmapSource.Create(2560, 3072, 96, 96, PixelFormats.Gray16, null, pixel16, stride);
                image.Source = bmps;
            }           
        }

        private void image_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            canvas.Width = image.ActualWidth;
            canvas.Height = image.ActualHeight;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //scroll.Width = win.Width - 100;
            //scroll.Height = win.Height - 100;
        }
    }
}
