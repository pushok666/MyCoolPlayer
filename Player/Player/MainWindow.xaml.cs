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
using Player.BL;

namespace Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Music music;
        public MainWindow()
        {
            music = new Music();
            InitializeComponent();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void CloseEvent(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void DropFile(object sender, DragEventArgs e)
        {
            music.PlayMusic(sender, e);
            //MessageBox.Show($"drop file {data}");


            int a = 10;
        }
    }
}
