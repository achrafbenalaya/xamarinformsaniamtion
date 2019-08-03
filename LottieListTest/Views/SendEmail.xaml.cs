using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieListTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendEmail : ContentPage
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        async void btnSend_Clicked(object sender, System.EventArgs e)
        {
            List<string> toAddress = new List<string>();
            toAddress.Add(txtTo.Text);
            //await SendEmailTest(txtSubject.Text, txtBody.Text, toAddress);
            await PopupNavigation.PushAsync(new PopupPageSentEmail());
            await Task.Delay(3000);
            await PopupNavigation.PopAsync(true);

        }

        public async Task SendEmailTest(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients,
                };
                await Email.ComposeAsync(message);
            
            }
        
            catch (Exception ex)
            {
                // Some other exception occurred  
            }
        }
    }
}