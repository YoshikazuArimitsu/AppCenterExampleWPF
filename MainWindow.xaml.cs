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
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterExampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // https://appcenter.ms/
            AppCenter.Start("{secrets}",
                              typeof(Analytics), typeof(Crashes));
        }

        private void OutputLog(object sender, RoutedEventArgs e)
        {
            Analytics.TrackEvent("サンプルログメッセージ", new Dictionary<string, string> {
                    { "サンプルパラメータキー", "サンプルパラメータ値" }
                });
        }

        private void Crash(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
