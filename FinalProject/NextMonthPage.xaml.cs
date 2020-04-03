using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextMonthPage : ContentPage
    {
        public NextMonthPage()
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