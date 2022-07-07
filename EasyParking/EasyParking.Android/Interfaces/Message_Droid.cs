using Android.Widget;
using EasyParking.Droid.Interfaces;
using EasyParking.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Message_Droid))]

namespace EasyParking.Droid.Interfaces
{
    public class Message_Droid : IMessage
    {
        public void Longtime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }

        public void Shorttime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}