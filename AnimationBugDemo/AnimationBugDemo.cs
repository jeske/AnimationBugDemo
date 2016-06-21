using System;

using Xamarin.Forms;

namespace AnimationBugDemo
{
	public class App : Application
	{
		public App()
		{

			var page = new FirstPage();
			NavigationPage.SetHasNavigationBar(page, false);

			MainPage = new NavigationPage(page);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

