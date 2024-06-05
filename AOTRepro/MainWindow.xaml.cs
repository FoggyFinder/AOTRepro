using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AOTRepro
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        ObservableCollection<Image> images;
        public MainWindow()
        {
            this.InitializeComponent();
            images = [];
        }

        private void Gallery_Loaded(object sender, RoutedEventArgs e)
        {
            Image cha = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/charlatan.png")
                }
            };

            Image roast = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/roast.jpg")
                }
            };

            Image year = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/year.png")
                }
            };

            images.Add(cha);
            images.Add(roast);
            images.Add(year);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (images.Count > 0)
            //    images.RemoveAt(0);
            Image cha = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/charlatan.png")
                }
            };

            images.Add(cha);
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateList();
        }

        private void Repeater_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateList();
        }

        private void FlipViewImages_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            Image charytin = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/charlatan.png")
                }
            };

            Image roast = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/roast.jpg")
                }
            };

            Image year = new()
            {
                Source = new BitmapImage()
                {
                    UriSource = new("ms-appx:///Assets/year.png")
                }
            };

            images.Add(charytin);
            images.Add(roast);
            images.Add(year);

            //FlipViewImages.ItemsSource = images;
            //ListViewImages.ItemsSource = images;
            //RepeaterImages.ItemsSource = images;
        }

        
    }
}
