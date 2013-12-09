using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Twitcher.Resources;

namespace Twitcher
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public static MenuData menuData;
        //public static MenuDetail menuItemList;
        public MainPage()
        {
            InitializeComponent();
            menuData = new MenuData();
            DataContext = MenuData.menuJsonData;
            
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }
       
        private void longListTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MenuData.CategoryItem item = ((FrameworkElement)e.OriginalSource).DataContext as MenuData.CategoryItem;
            menuData.selectedItem = item; // save the category item selected here
            if (item != null) // if fast-clicking, it is possible to get here with nothing selected.  Ignore
                NavigationService.Navigate(new Uri("/tweetDetails.xaml", UriKind.Relative));
        }
        













        private void mapViewTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetMap.xaml", UriKind.Relative));
        }
        private void listViewTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetList.xaml", UriKind.Relative));
        }
        private void InputField_GotFocus(object sender, System.Windows.Input.GestureEventArgs e)
        {
            InputField.Text = "";
        }
        private void AppBarIconBtn(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }
        private void closeKB(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void fetchData(object sender, EventArgs e)
        {

        }

        private void tweetDetail(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetDetails.xaml", UriKind.Relative));
        }
    }
}