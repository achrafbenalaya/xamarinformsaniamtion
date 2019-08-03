using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace LottieListTest.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://achrafbenalayablog.azurewebsites.net/index.php/2019/08/03/animations-with-lottie-in-xamarin-forms/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}