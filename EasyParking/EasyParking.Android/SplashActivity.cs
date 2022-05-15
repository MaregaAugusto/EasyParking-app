using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace EasyParking.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", Label ="xx",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //System.Threading.Thread.Sleep(3000);
            StartActivity(typeof(MainActivity));
        }
    }
}