using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace z_uwp
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class AddPage : Page
	{
		public AddPage()
		{
			this.InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(nom.Text) && !String.IsNullOrWhiteSpace(mcode.Text))
			{
				((App)App.Current).idfkman.Add(new Meeting(nom.Text, descr.Text, mcode.Text, mpass.Text));
				MainPage.mainFrame.Navigate(typeof(HomePage), null, new DrillInNavigationTransitionInfo());
				((Window.Current.Content as Frame).Content as MainPage).setHeader("Launcher");
			}
		}
	}
}
