using ClicarApp2.Customs;
using ClicarApp2.Droid.Customs;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonAndroid))]

namespace ClicarApp2.Droid.Customs
{
    class CustomButtonAndroid : ButtonRenderer
    {
        public CustomButtonAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (this.Control == null) return;
            this.Control.SetAllCaps(false);
        }

    }
}