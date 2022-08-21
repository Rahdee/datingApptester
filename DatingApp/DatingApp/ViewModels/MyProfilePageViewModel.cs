using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingApp.ViewModels
{
    public class MyProfilePageViewModel : ViewModelBase
    {
        public MyProfilePageViewModel(INavigationService nav) : base(nav)
        {
            Title = "Profile";
        }
    }
}
