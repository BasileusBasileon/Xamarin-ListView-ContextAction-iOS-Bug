using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContextActionRepro
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private int _tapCount = 0;

		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			_tapCount++;
			tapCount.Text = "Taps on Items: " + _tapCount;
		}
	}
}
