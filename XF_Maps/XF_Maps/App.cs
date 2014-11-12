﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XF_Maps
{
    public class App
    {
        public static Page GetMainPage() {	

            var tabs = new TabbedPage();

            tabs.Children.Add(new ButtonPage { Title = "ボタンで移動" });
            tabs.Children.Add(new InputPage { Title = "緯度経度で移動" });

            return tabs;

        }

    }
}
