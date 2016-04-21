using System;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WorQit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        //private ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        //public static ServiceReference1.User user = new ServiceReference1.User();
        ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

        public Login()
        {
            this.InitializeComponent();
        }

        /// <summary>
		///  Methode voor button inloggen.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private async void loginbtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            try
            {
                //user = await client.InlogMethodeAsync(usrTxt.Text, pswTxt.Password);
                //User currentUser = new User() { gebruikersID = user.GebruikerID, gebruikersNaam = user.GebruikerNaam, gebruikersPW = user.GebruikersPW };
                //localSettings.Values["currentUser"] = currentUser.gebruikersID;
                Frame.Navigate(typeof(Main));
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog("Niet gelukt in te loggen! Verkeerde gebruiker en/of wachtwoord!" + ex);
                await dialog.ShowAsync();
            }
        }


        /// <summary>
        /// Methode voor klikken op register, refereert naar de Register Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccount_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateAccount));
        }
    }
}
