using BeautyShop.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Messages
{
    public class LoggedInClientMessage : ValueChangedMessage<Client>
    {
        public LoggedInClientMessage(Client client) : base(client) { }
    }
}
