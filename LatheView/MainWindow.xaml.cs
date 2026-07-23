using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace LatheView
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
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "NC (*.nc)|*.nc|TXT (*.txt)|*.txt|모든파일|*.*";

            if (dlg.ShowDialog() == true)
            {
                txtNC.Text = File.ReadAllText(dlg.FileName);
            }
        }
    }
}