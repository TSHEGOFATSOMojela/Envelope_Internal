using System;
using Plugin.Permissions;

using Android.App;
using Android.Content.PM;
using Envelope_Internal.Indigent.Accepted;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Envelope_Internal.Droid
{
    [Activity(Label = "Envelope_Internal", Icon = "@drawable/Ekurhulen", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity = this;
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
      
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}

