using System;

using Xamarin.Forms;

namespace AnimationBugDemo
{
	public class FirstPage : ContentPage
	{
		public FirstPage()
		{
			Title = "First Page";

			var mybutton = new Button
			{
				Text = "Goto Second Page",
				BackgroundColor = Color.Gray, 
			};
			mybutton.Clicked += Handle_Click;

			var mylayout = new RelativeLayout
			{
				Padding = 0,

			};

			mylayout.Children.Add(
				new Image()
				{
					Aspect = Aspect.AspectFill,
					Source = "bg-login_1242x2208.png",
				},
				Constraint.Constant(0),
				Constraint.Constant(0),
				Constraint.RelativeToParent((parent) => { return parent.Width; }),
				Constraint.RelativeToParent((parent) => { return parent.Height; }));
			mylayout.Children.Add(
				mybutton,
				Constraint.RelativeToParent((parent) => { return parent.Width / 4; }),
				Constraint.RelativeToParent((parent) => { return parent.Height / 6; }),
				Constraint.RelativeToParent((parent) => { return parent.Width / 2; }),
				Constraint.RelativeToParent((parent) => { return parent.Height / 6; }));


			Content = mylayout;
		}

		private async void Handle_Click(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new SecondPage());
		}
	}
}

