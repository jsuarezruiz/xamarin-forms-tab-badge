﻿namespace Plugin.Badge.Sample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Sample.App());
        }
    }
}