using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Validator
{
    public class RegisterValidator
    {
        public static String isValidRegister(string username, string password, string name, string surname)
        {
            if(username == null || password == null || name == null || surname == null)
            {
                return "Lütfen boş kalan alanları doldurunuz.";
            }

            if(username.Length < 3)
            {
                return "Kullanıcı Adı en az 3 karakter olmalıdır.";
            }

            if (password.Length < 6)
            {
                return "Şifre en az 6 karakter olmalıdır.";
            }

            if (!password.Any(char.IsUpper))
            {
                return "Şifrede en az 1 adet büyük karakter olmalıdır";
            }

            return null;
        } 
    }
}