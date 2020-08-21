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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace z_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

		public static string initheader = "Welcome Back";

        public MainPage()
        {
            this.InitializeComponent();
        }

		private void nvLoaded(object sender, RoutedEventArgs e)
		{
			// you can also add items in code behind
			//NavView.MenuItems.Add(new NavigationViewItemSeparator());
			//NavView.MenuItems.Add(new NavigationViewItem()
			//{ Content = "My content", Icon = new SymbolIcon(Symbol.Folder), Tag = "content" });

			// set the initial SelectedItem 
			foreach (NavigationViewItemBase item in NavView.MenuItems)
			{
				if (item is NavigationViewItem && item.Tag.ToString() == "Home")
				{
					NavView.SelectedItem = item;
					break;
				}
			}
			contentFrame.Navigate(typeof(HomePage));
			setHeader(initheader);
		}

		private void nvInvoke(NavigationView sender, NavigationViewItemInvokedEventArgs args)
		{
			if (args.IsSettingsInvoked)
			{
				//contentFrame.Navigate(typeof(SettingsPage));
				Console.WriteLine("wot");
			}
			else
			{
				// find NavigationViewItem with Content that equals InvokedItem
				var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
				nav(item as NavigationViewItem);
			}
		}

		public void nav(NavigationViewItem item)
		{
			switch (item.Tag)
			{
				case "Home":
					contentFrame.Navigate(typeof(HomePage));
					break;
				case "Add":
					contentFrame.Navigate(typeof(AddPage));
					break;
				case "Info":
					contentFrame.Navigate(typeof(InfoPage));
					break;
				default:
					break;
			}
			setHeader((string)item.Content);
			//NavView.SelectedItem = item;
		}

		public  void setHeader(string s)
		{
			NavView.Header = s;
		}
	}
}
