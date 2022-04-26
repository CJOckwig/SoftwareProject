using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JackrabbitPromotionSoftware
{
    class Customer
    {
        public Customer()
        {
        }
        public Customer(string f, string l, string p,string e)
        {
            fName = f;
            lName = l;
            phone_Num = p;
            e_mail = e;
            drinker = false;

        }
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone_Num { get; set; }
        public bool drinker { get; set; }
        public int point { get; set; }
        public string e_mail { get; set; }
        public Reservation[] resList = new Reservation[5];

        // Code borrowed from https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address 
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }


        // regex borrowed from https://www.abstractapi.com/guides/c-validate-phone-number
        public static bool IsValidPhone(string phone)
        {
            string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            if (phone != null) return Regex.IsMatch(phone, motif);
            else return false;
        }

    }
}
