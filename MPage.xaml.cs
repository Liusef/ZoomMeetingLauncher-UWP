using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Windows.ApplicationModel.DataTransfer;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace z_uwp
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MPage : Page
	{

		public static string name { get; set; }
		public static string desc { get; set; }
		public static string code { get; set; }
		public static string pass { get; set; }

		public string nameInst;
		public string descInst;
		public string codeInst;
		public string passInst;

		public MPage()
		{
			nameInst = name;
			descInst = desc;
			codeInst = code;
			passInst = pass;
			this.InitializeComponent();
		}

		public static void setParams(string n, string d, string c, string p)
		{
			name = n;
			desc = d;
			code = c;
			pass = p;
		}

		public void launchMeeting()
		{
			Meeting temp = new Meeting(name, desc, code, pass);
			Console.WriteLine(temp.url);
			Utils.OpenBrowser(temp.url);
		}

		public void delEntry()
		{
			Meeting temp = new Meeting(name, desc, code, pass);
			Meeting[] arr = ((App)App.Current).idfkman.ToArray<Meeting>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Equals(temp))
				{
					((App)App.Current).idfkman.RemoveAt(i);
					break;
				}
			}
		}

		private void Join_Click(object sender, RoutedEventArgs e)
		{
			launchMeeting();
		}

		private void Del_Click(object sender, RoutedEventArgs e)
		{
			delEntry();
			MainPage.mainFrame.Navigate(typeof(HomePage), null, new DrillInNavigationTransitionInfo());
			((Window.Current.Content as Frame).Content as MainPage).setHeader("Launcher");
		}

		private void Copy_Click(object sender, RoutedEventArgs e)
		{
			Meeting temp = new Meeting(name, desc, code, pass);
			DataPackage dp = new DataPackage();
			dp.RequestedOperation = DataPackageOperation.Copy;
			dp.SetText(temp.url);
			Clipboard.SetContent(dp);
		}
	}
}
