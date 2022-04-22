﻿using GittiGidiyor1.ViewModels;
using GittiGidiyor1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GittiGidiyor1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
