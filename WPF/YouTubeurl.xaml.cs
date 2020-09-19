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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// YouTubeurl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class YouTubeurl : Window
    {
        public YouTubeurl()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // YouTubeService 객체 생성
            var youtube = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBWV70c3cKsAPE9fbZEVmv767QyaC0TCP8", // 키 지정
                ApplicationName = "My YouTube Search"
            });

            // Search용 Request 생성
            var request = youtube.Search.List("snippet");
            request.Q = txtSearch.Text;  //ex: "양희은"
            request.MaxResults = 25;

            // Search용 Request 실행
            var result = await request.ExecuteAsync();

            // Search 결과를 리스트뷰에 담기
            foreach (var item in result.Items)
            {
                if (item.Id.Kind == "youtube#video")
                {
                    listView1.Items.Add(item.Id.VideoId.ToString() + item.Snippet.Title + 0);
                }
            }
        }

            private void listView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    // YouTube 비디오 Play를 위한 URL 생성 
                    string videoId = listView1.SelectedItems[0].ToString();
                    string youtubeUrl = "http://youtube.com/watch?v=" + videoId;

                    // 디폴트 브라우져에서 실행
                    Process.Start(youtubeUrl);
                }
            }
        }
}
