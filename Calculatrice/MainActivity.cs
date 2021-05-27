using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;

namespace Calculatrice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            var result = FindViewById<TextView>(Resource.Id.textView2);

            button1.Click += (sender, e) => {
                // Perform action on click
                var inputA = FindViewById<EditText>(Resource.Id.editText1);
                var inputB = FindViewById<EditText>(Resource.Id.editText2);

                

                var num = int.Parse(inputA.Text);
                var num2 = int.Parse(inputB.Text);

                result.Text =Convert.ToString( num + num2);


            };

            button2.Click += (sender, e) => {
                // Perform action on click
                var inputA = FindViewById<EditText>(Resource.Id.editText1);
                var inputB = FindViewById<EditText>(Resource.Id.editText2);



                var num = int.Parse(inputA.Text);
                var num2 = int.Parse(inputB.Text);

                result.Text = Convert.ToString(num - num2);


            };

            button3.Click += (sender, e) => {
                // Perform action on click
                var inputA = FindViewById<EditText>(Resource.Id.editText1);
                var inputB = FindViewById<EditText>(Resource.Id.editText2);



                var num = int.Parse(inputA.Text);
                var num2 = int.Parse(inputB.Text);

                result.Text = Convert.ToString(num * num2);


            };

            button4.Click += (sender, e) => {
                // Perform action on click
                var inputA = FindViewById<EditText>(Resource.Id.editText1);
                var inputB = FindViewById<EditText>(Resource.Id.editText2);



                var num = int.Parse(inputA.Text);
                var num2 = int.Parse(inputB.Text);

                result.Text = Convert.ToString(num / num2);


            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
