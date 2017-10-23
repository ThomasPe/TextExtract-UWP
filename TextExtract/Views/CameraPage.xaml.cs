using TextExtract.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TextExtract.Views
{
    public sealed partial class CameraPage : Page
    {
        private CameraViewModel ViewModel
        {
            get { return DataContext as CameraViewModel; }
        }

        public CameraPage()
        {
            InitializeComponent();
        }
    }
}
