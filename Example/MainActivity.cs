﻿using Android.App;
using Android.OS;
using Material_Range_Bar_Wrapper.Views;

namespace Example
{
    [Activity(Label = "Example", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, RangeBar.IOnRangeBarChangeListener
    {
        #region lifecycle

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            this.SetContentView(Resource.Layout.Main);

            var rangeBar = this.FindViewById<RangeBar>(Resource.Id.rangebar);
            var notRangeBar = this.FindViewById<RangeBar>(Resource.Id.notrangebar);

            rangeBar.SetOnRangeBarChangeListener(this);
            notRangeBar.SetOnRangeBarChangeListener(this);
        }

        #endregion

        #region IOnRangeBarChangeListener

        public void OnRangeChangeListener(RangeBar rangeBar, int leftPinIndex, int rightPinIndex, string leftPinValue,
            string rightPinValue)
        {

        }

        #endregion
    }
}
