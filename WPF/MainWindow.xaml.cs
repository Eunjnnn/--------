using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnmain_Click(object sender, RoutedEventArgs e)
        {
            //YouTube_Frame.Visibility = System.Windows.Visibility.Hidden;
            //MainWindow();
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            //YouTube_Frame.Visibility = System.Windows.Visibility.Hidden;
            //DownloadSub subWindow = new DownloadSub();
            //subWindow.ShowDialog();

            Views.ShellView shellView = new Views.ShellView();
            shellView.ShowDialog();
            
        }

        private void btnYouTube_Click(object sender, RoutedEventArgs e)
        {
            YouTubeurl youTube = new YouTubeurl();
            youTube.ShowDialog();
            //YouTube_Frame.Visibility = System.Windows.Visibility.Visible;
            //YouTube_Frame.Source = new Uri("https://www.youtube.com/");
        }

        private void btnVideos_Click(object sender, RoutedEventArgs e)
        {
            //YouTube_Frame.Visibility = System.Windows.Visibility.Hidden;
            MyVideo myVideo = new MyVideo();
            myVideo.Title = "Video";
            this.Content = myVideo;
        }
    }
}
