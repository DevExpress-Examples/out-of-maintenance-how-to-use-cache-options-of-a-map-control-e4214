Imports System.Net
Imports System.Windows

Namespace MapCacheOptions

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        End Sub

        Private Sub OpenStreetMapDataProvider_WebRequest(ByVal sender As Object, ByVal e As DevExpress.Xpf.Map.MapWebRequestEventArgs)
            e.UserAgent = "DevExpress OpenStreetMapProvider example"
        End Sub
    End Class
End Namespace
