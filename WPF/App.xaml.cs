using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private readonly Mutex _mutex;

        public App()
        {
            if (Mutex.TryOpenExisting("YouTube Downloader", out Mutex _))
            {
                MessageBox.Show("Another instance of YouTube Downloader is already open.", "Instance Already Open", MessageBoxButton.OK, MessageBoxImage.Warning);
                Current.Shutdown();
                return;
            }

            _mutex = new Mutex(true, "YouTube Downloader");

            Dispatcher.UnhandledException += (sender, e) =>
            {
                e.Handled = true;
                MessageBox.Show($"Operation unsuccessful.\n\n{e.Exception.Message}", "An Error Occurred", MessageBoxButton.OK, MessageBoxImage.Error);
            };
        }
    }
}
}
