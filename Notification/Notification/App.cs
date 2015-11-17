﻿using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Notification.ViewModels;
using Notification.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Notification {
    public class App : FormsApplication {

        private SimpleContainer Container = null;

        public App(SimpleContainer container) {

            this.Container = container;

            this.Container
                .Singleton<HomeViewModel>();

            this.DisplayRootView<HomeView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage) {
            this.Container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }
    }
}