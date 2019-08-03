using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LottieListTest.Models;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieListTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPageSample : PopupPage
    {
        public PopupPageSample()
        {
            InitializeComponent();
            
        }
        NewItemPage itemPage = new NewItemPage();
        async void Save_ClickedConfirm(object sender, EventArgs e)
        {
            AnimationFrame.IsVisible = false;
            //await Navigation.PopModalAsync();
            await PopupNavigation.PopAsync(true);
            


        }
    }
}