using System;

using TextExtract.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TextExtract.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
