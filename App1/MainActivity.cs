using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Distribute;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            MobileCenter.Start("374739fe-487d-47e1-8c1d-307d7ef79a2f",typeof(Analytics), typeof(Crashes), typeof(Distribute)); //sample
            /*var x=crash().ToString();
            object crash() {
                return null;
            }*/
            
          //  throw new System.StackOverflowException("this is crash");
            // Set our view from the "main" layout resource sample
            // SetContentView (Resource.Layout.Main);
        }
    }
}

