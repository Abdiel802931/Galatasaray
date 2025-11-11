using Galatasaray.Services;
using Galatasaray.ViewModels;

namespace Galatasaray.Views
{
    public partial class SensorsPage : ContentPage
    {
        public SensorsPage()
        {
            InitializeComponent();
            BindingContext = new SensorViewModel(new SensorsService());

        }
    }
}
