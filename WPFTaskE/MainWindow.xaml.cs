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
using System.Threading;
using System.Net.Http;
using System.Diagnostics;

namespace WPFTaskE
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

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/5MB.zip").Result;

                MyButton.Dispatcher.Invoke(() => 
                {
                    Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} own my button");
                    MyButton.Content = "Done";
                });
                
            });
        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () => {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/5MB.zip").Result;
            });
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} after await task");
            MyButton.Content = "Done Downloading";
        }
    }


}
