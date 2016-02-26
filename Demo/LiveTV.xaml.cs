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
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for LiveTV.xaml
    /// </summary>
    public partial class LiveTV : Window
    {
        public LiveTV()
        {
            InitializeComponent();
          
        }

        private void UpdateButtons()
        {
           
        }


        private void BtnClick(object sender, RoutedEventArgs e)
        {
            startVideo();
        }
        private void startVideo()
        {
            System.Uri uri = new System.Uri("http://www.androidbegin.com/tutorial/AndroidCommercial.3gp");
            _streamPlayerControl.StartPlay(uri);
        }

        private void HandlePlayerEvent(object sender, RoutedEventArgs e)
        {
            UpdateButtons();

            if (e.RoutedEvent.Name == "StreamStarted")
            {
                ////_statusLabel.Text = "Playing";
            }
            else if (e.RoutedEvent.Name == "StreamFailed")
            {
                ////_statusLabel.Text = "Failed";

                MessageBox.Show(
                    ((WebEye.StreamFailedEventArgs)e).Error,
                    "Stream Player Demo",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            else if (e.RoutedEvent.Name == "StreamStopped")
            {
               // _statusLabel.Text = "Stopped";
            }
        }

    }
}
