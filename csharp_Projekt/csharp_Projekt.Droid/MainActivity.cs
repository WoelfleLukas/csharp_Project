﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace csharp_Projekt.Droid
{
	[Activity (Label = "csharp_Projekt.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.kampf);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.buttonAngriff);

            button.Click += delegate {
               
            };
        }
	}
}


