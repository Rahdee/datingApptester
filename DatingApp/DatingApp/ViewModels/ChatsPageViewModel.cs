using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.ViewModels
{
    public class ChatsPageViewModel : ViewModelBase
    {
        public ChatsPageViewModel(INavigationService nav) : base(nav)
        {
            Title = "Chats";
        }
    }
}
