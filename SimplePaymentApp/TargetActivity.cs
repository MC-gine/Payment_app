using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Craftman.Cardform;

namespace SimplePaymentApp
{
    [Activity(Label = "TargetActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class TargetActivity : AppCompatActivity, IOnPayBtnClickListner
    {
        public void OnClick(Card card)
        {
            //If everything is correct
            Toast.MakeText(ApplicationContext, "Payment was successful", ToastLength.Short).Show();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Target);


            var cardForm = FindViewById<CardForm>(Resource.Id.card_form);
            var txt_amount = FindViewById<TextView>(Resource.Id.payment_amount);
            var btnPay = FindViewById<Button>(Resource.Id.btn_pay);


            txt_amount.Text = "1 Euro";
            btnPay.Text = $"Payer {txt_amount.Text}";

            cardForm.SetPayBtnClickListner(this);
        }
    }
}