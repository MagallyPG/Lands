namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
      
        #region Atributes
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                SetValue(ref this.password, value);
            }
        }

        public bool IsRunning
        {
            get
            { return this.isRunning;
            }
            set
            {
                SetValue(ref this.isRunning, value);
            }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnable;
            }
            set
            { 
                SetValue(ref this.isEnable, value);
            }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "You must enter an Email", 
                    "Acept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a Password",
                    "Acept");
                return;
            }

            this.isRunning = true;
            this.IsEnabled = false;

            if (this.Email != "mapagu_1995@hotmail.com" || this.Password != "1234" )
            {
                this.isRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert(
                 "Error",
                 "Email or password incorrect",
                 "Acept");
                this.Password = string.Empty;
                return;
            }

            this.isRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                 "Ok",
                 "entering",
                 "Acept");
            return;
        
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
        }
        #endregion
    }
}
