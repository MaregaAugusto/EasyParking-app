using Android.Content;
using EasyParking.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MyButtonRender))]

namespace EasyParking.Droid.Renders
{

    public class MyButtonRender : ButtonRenderer
    {

        public MyButtonRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;
            Control.SetTextSize(Android.Util.ComplexUnitType.Dip, (float)e.NewElement.FontSize);

        }
    }
}