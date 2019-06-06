using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Carol_FileIO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PracticeDataBinding : Page
    {
        public PracticeDataBinding()
        {
            this.InitializeComponent();
        }
    
    private void OnClick1(object sender, RoutedEventArgs e)
    {
        btn1.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
        text1.Text = "Click event occurs on Hover.";
        text2.Text = "";
        text3.Text = "";
    }

    void OnClick2(object sender, RoutedEventArgs e)
    {
        btn2.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
        text1.Text = "";
        text2.Text = "Click event occurs on Press.";
        text3.Text = "";
    }

    void OnClick3(object sender, RoutedEventArgs e)
    {
        btn1.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
        btn2.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
        text1.Text = "";
        text2.Text = "";
        text3.Text = "Click event occurs on Release.";
    }
    }
}
