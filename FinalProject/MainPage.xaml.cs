﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FinalProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesPage());
        }
        private async void NextButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NextMonthPage());
        }
        private async void PrevButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrevMonthPage());
        }
    }
}
