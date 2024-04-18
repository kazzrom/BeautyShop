using BeautyShop.Messages;
using BeautyShop.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.ViewModels
{
    public partial class ClientViewModel : ObservableObject, IRecipient<LoggedInClientMessage>
    {
        public ClientViewModel()
        {
            WeakReferenceMessenger.Default.Register(this);
        }
        
        [ObservableProperty]
        private Client _client;

        public void Receive(LoggedInClientMessage message)
        {
            Client = message.Value;
            WeakReferenceMessenger.Default.UnregisterAll(this);
        }
    }
}
