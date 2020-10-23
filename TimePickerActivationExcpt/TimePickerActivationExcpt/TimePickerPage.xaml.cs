using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimePickerActivationExcpt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePickerPage : ContentPage
    {
        public TimePickerPage()
        {
            InitializeComponent();

            TimePickerControl.DialogShown += TimePickerControl_DialogShown;
        }

        private void TimePickerControl_DialogShown(object sender, System.EventArgs e)
        {
            TimePickerControl.DialogShown -= TimePickerControl_DialogShown;

            MyLayout.Children.RemoveAt(0);
        }
    }
}