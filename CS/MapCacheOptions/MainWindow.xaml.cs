using System.Net;
using System.Windows;

namespace MapCacheOptions {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void OpenStreetMapDataProvider_WebRequest(object sender, DevExpress.Xpf.Map.MapWebRequestEventArgs e) {
            e.UserAgent = "DevExpress OpenStreetMapProvider example";
        }
    }
}
