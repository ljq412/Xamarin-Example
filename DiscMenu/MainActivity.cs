﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace DiscMenu {
    [Activity(Label = "DiscMenu", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);


            var menu = new DiscMenu(this, BitmapFactory.DecodeResource(this.Resources, Resource.Drawable.xling) );
            this.AddContentView(menu, new ViewGroup.LayoutParams(400, 400));
            menu.SetMenus(new Dictionary<string, Drawable>() {
                {"Add", this.Resources.GetDrawable(Resource.Drawable.add) },
                {"Call", this.Resources.GetDrawable( Resource.Drawable.call) },
                {"Camera", this.Resources.GetDrawable(Resource.Drawable.camara) },
                {"Favorates", this.Resources.GetDrawable(Resource.Drawable.Favs) },
                {"Setting", this.Resources.GetDrawable(Resource.Drawable.setting) },
                {"Mail", this.Resources.GetDrawable(Resource.Drawable.mail) },
            });
        }
    }
}

