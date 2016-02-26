using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string ImagePath { get; set; }
        public MainWindow()
        {
            ImagePath = @"Images\Background.jpg";
            InitializeComponent();
        }

        private void LiveTV_MouseDown(object sender, MouseButtonEventArgs e)
        {
           // AllChannel allChannel = new AllChannel();
           // allChannel.Show();
            LiveTV liveTV = new LiveTV();
            liveTV.Show();
            this.Close();
        }

        private void PaidChannel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }


    }
}
