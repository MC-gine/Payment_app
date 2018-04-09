using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using System.Drawing;
using Android.Views;
using System;


namespace SimplePaymentApp
{
    [Activity(Label = "SimplePaymentApp", MainLauncher = true, Icon ="@drawable/Icon", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Show splash screen
            var config = new EasySplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(TargetActivity)))
                .WithSplashTimeOut(5000)
                //.WithBackgroundResource(android.R.color.holo_red_light)
                .WithLogo(Resource.Drawable.Logo)
                .WithHeaderText("Wellcome to Simple Payment App")
                .WithFooterText("copyright st.d.i 2018");


            //Set Color for text
            //config.getHeaderTextView().setTextColor(Color.White);
            //config.getFooterTextView().setTextColor(Color.White);

            //Create View
            View view = config.Create();
            SetContentView(view);
        }
    }
}

