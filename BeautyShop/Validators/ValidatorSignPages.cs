using BeautyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Validators
{
    public static class ValidatorSignPages
    {
        public static bool ValidateProperty(string name)
        {
            return name != null && name.Length < 30 && name.Length > 2;
        }

        public static bool ValidateClient(Client client)
        {
            return ValidateProperty(client.Surname) 
                   && ValidateProperty(client.Name)
                   && ValidateProperty(client.Patronymic)
                   && ValidateProperty(client.Email)
                   && ValidateProperty(client.PhoneNumber);
        }
    }
}
