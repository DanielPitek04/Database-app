using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdutageApp
{
    internal class MyUsers
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Fullname { get; set; }
        public string Number { get; set; }
        public string PoCovide { get; set; }

        private static string error = "V niečom nastala chyba";

        public static void UkazChybu()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(MyUsers user1, MyUsers user2)
        {
            if (user1 == null && user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error = "Používateľské meno neexistuje";
                return false;
            }
            else if (user1.Password != user2.Password)
            {
                error = "Bohužiaľ zadali ste nesprávne heslo";
                return false;
            }
            else if(user1.Username != user2.Password && user1.Username != user2.Username)
            {
                error = "Zle udaje";
                return false;
            }
            return true;
        }


    }
}
