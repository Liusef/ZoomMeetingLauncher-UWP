using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
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

		public MPage()
		{
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
			System.Diagnostics.Process.Start(temp.url);
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
	}
}
