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
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace z_uwp
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class HomePage : Page
	{

		public ObservableCollection<Meeting> Items
		{
			get
			{
				return ((App) Application.Current).idfkman;
			}
		}

		public HomePage()
		{
			this.InitializeComponent();
		}

		private void addMeeting(object sender, RoutedEventArgs e)
		{
			((App)App.Current).idfkman.Add(new Meeting("Wot", "Wot", "Wot", "Wot"));
			((App)App.Current).idfkman.Add(new Meeting("Kristy Harlin - European Literature Period 3", "", "Wot", "Wot"));
			((App)App.Current).idfkman.Add(new Meeting("Bradley Fulk - APCS A", "AP Computer Science A", "Wot", "Wot"));
			((App)App.Current).idfkman.Add(new Meeting("Test Meeting", "This meeting tile exists simply so that the description is long enough that it can demonstrate word wrapping and \nnew lines", "Wot", "Wot"));
			((App)App.Current).idfkman.Add(new Meeting("Test Meeting but this time the name is quite long now isn't it?", "This meeting tile exists simply so that the description is long enough that it can demonstrate word wrapping and \nnew lines", "Wot", "Wot"));
		}
	}
}
