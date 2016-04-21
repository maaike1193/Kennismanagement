using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WorQit
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAccount : Page
    {
        //private ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public CreateAccount()
        {
            this.InitializeComponent();
        }

        private async void registerbtn_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(passwordtxt.Password) && !String.IsNullOrWhiteSpace(usernametxt.Text))
            {
                bool check = false;

                //var gebruikers = await client.GetAllGebruikersAsync();
                //foreach (var user in gebruikers)
                {
                    //if (usernametxt.Text == user.GebruikerNaam)
                    {
                        check = true;
                    }
                }

                if (!check)
                {
                    //ServiceReference1.User newUser = new ServiceReference1.User();
                    //newUser.GebruikerNaam = usernametxt.Text;
                    //newUser.GebruikersPW = passwordtxt.Password;

                    //await client.AddGebruikerAsync(newUser);

                    var dialogCreated = new MessageDialog("User: " + usernametxt.Text + " successfully created");
                    await dialogCreated.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("Username bestaat al");
                    await dialog.ShowAsync();
                }
            }
            else
            {
                var dialog = new MessageDialog("Velden mogen niet leeg zijn");
                await dialog.ShowAsync();
            }
        }

        private void bk_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
    }
}
