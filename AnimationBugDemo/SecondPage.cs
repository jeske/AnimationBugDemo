using System;

using Xamarin.Forms;

namespace AnimationBugDemo
{
	public class SecondPage : ContentPage
	{
		public SecondPage()
		{
			Title = "Second Page";
			// The root page of your application
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Second Page!"
						}
					}
			};
		}
	}
}

