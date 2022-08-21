﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DatingApp.ViewModels
{
    public class MatchesContentPageViewModel : ViewModelBase
    {
        public MatchesContentPageViewModel(INavigationService nav) : base(nav)
        {
            Title = "Likes";
        }
    }
}
