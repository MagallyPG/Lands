namespace Lands
{
    using Views;
    using Xamarin.Forms;

    public partial class App : Application
	{
        #region Constructors
        public App ()
		{
			InitializeComponent();

			this.MainPage = new NavigationPage(new LoginPage()); //MainPage(Pagina principal)

        }
        #endregion

        #region Methods
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep () //Es cuando la aplicacion se duerme
		{
			// Handle when your app sleeps
		}

		protected override void OnResume () //Es cuando uno vuelve a la aplicaccion
		{
			// Handle when your app resumes
		}
        #endregion
    }
}
