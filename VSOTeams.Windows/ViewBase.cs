﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSOTeams.Interfaces;
using VSOTeams.ViewModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace VSOTeams
{
    public class ViewBase : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var navigableViewModel = this.DataContext as INavigable;
            if (navigableViewModel != null)
                navigableViewModel.Activate(e.Parameter);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            var navigableViewModel = this.DataContext as INavigable;
            if (navigableViewModel != null)
                navigableViewModel.Deactivate(e.Parameter);
        }

    }
}
