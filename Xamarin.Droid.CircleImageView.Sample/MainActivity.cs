using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.Droid.CircleImageView.Sample
{
    [Activity(Label = "@string/app_name",
        Icon = "@drawable/ic_launcher",
        Theme = "@style/AppTheme",
        MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}

