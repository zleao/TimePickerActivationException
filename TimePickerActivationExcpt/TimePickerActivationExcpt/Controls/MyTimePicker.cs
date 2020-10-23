using System;
using Xamarin.Forms;

namespace TimePickerActivationExcpt.Controls
{
    public class MyTimePicker : TimePicker
    {
        public event EventHandler DialogShown;

        public void OnDialogShown()
        {
            DialogShown?.Invoke(this, null);
        }
    }
}
