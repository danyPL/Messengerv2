﻿namespace Messengerv2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 1400;
            const int newHeight = 945;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}
