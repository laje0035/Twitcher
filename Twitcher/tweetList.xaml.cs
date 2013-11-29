using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Twitcher
{
    public partial class tweetList : PhoneApplicationPage
    {
        public tweetList()
        {
            InitializeComponent();
        }
        private void tweetDetail(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/tweetDetails.xaml", UriKind.Relative));
        }
    }
}