using Android.App;
using Android.Content;
using Java.Lang;
using System.Threading.Tasks;
using TimePickerActivationExcpt.Controls;
using TimePickerActivationExcpt.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyTimePicker), typeof(MyTimePickerRenderer))]
namespace TimePickerActivationExcpt.Droid.Renderers
{
    public class MyTimePickerRenderer : TimePickerRenderer
    {
        TimePickerDialog _dialog = null;
        
        public MyTimePickerRenderer(Context context) : base(context)
        {
        }

        protected override TimePickerDialog CreateTimePickerDialog(int hours, int minutes)
        {
            _dialog = base.CreateTimePickerDialog(hours, minutes);

            _dialog.ShowEvent += _dialog_ShowEvent;
            return _dialog;
        }

        private void _dialog_ShowEvent(object sender, System.EventArgs e)
        {
            _dialog.ShowEvent -= _dialog_ShowEvent;
            Task.Run(() =>
            {
                Thread.Sleep(500);
                (Context as Activity)?.RunOnUiThread(() => (Element as MyTimePicker)?.OnDialogShown());
            });
        }

        protected override void Dispose(bool disposing)
        {
            // Uncomment these lines to ensure the timepicker dialog is hidden and we won't get activation failed issues
            //if(_dialog != null && _dialog.IsShowing)
            //{
            //    _dialog.Hide();
            //}

            base.Dispose(disposing);
        }
    }
}
