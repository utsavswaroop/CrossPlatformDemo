using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using SharedLayer;

namespace Droid
{
	[Activity (Label = "Droid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
//			Button button = FindViewById<Button> (Resource.Id.myButton);
//			button.Click += delegate {
//				button.Text = string.Format ("{0} clicks!", count++);
//			};

			Button button = FindViewById<Button> (Resource.Id.clickButton);
			TextView text = FindViewById<TextView> (Resource.Id.displayText);

			MyClass myClass = new MyClass ();

			button.Click += delegate {
				text.Text = myClass.NameString;


			};
		}
	}
}


