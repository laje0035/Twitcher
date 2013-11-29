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
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
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
    }
}