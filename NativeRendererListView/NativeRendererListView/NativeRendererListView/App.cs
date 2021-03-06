﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NativeRendererListView.View;
using Xamarin.Forms;

namespace NativeRendererListView
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = GetMainPage();
        }

        private static Page GetMainPage()
        {
            var mainNav = new NavigationPage(new NativeListViewPage());
            return mainNav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
