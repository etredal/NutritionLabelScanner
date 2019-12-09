﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NutritionLabelScanner.Services;
using NutritionLabelScanner.Views;

namespace NutritionLabelScanner
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
