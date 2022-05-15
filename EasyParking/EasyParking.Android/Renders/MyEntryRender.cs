using Android.Content;
using EasyParking.Droid.Renders;
using Xamarin.Forms;

using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Entry), typeof(MyEntryRender))]

namespace EasyParking.Droid.Renders
{

    public class MyEntryRender : EntryRenderer
    {

        public MyEntryRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;
            Control.SetTextSize(Android.Util.ComplexUnitType.Dip, (float)e.NewElement.FontSize);

        }
    }

}