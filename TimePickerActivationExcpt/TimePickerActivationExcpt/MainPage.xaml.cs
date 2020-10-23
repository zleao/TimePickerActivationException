using Xamarin.Forms;

namespace TimePickerActivationExcpt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TimePickerPage(), true);
        }
    }
}
