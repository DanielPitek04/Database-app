using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdutageApp
{
    internal class adminUcet
    {
        public string Username2 { get; set; }
        public string Password2 { get; set; }
        public string Gender2 { get; set; }
        public string Fullname2 { get; set; }
        public string Number2 { get; set; }

        private static string error = "V niečom nastala chyba";

        public static void UkazChybu()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(adminUcet userTT, adminUcet userGG)
        {
            if (userTT == null && userGG == null) { return false; }

            if (userTT.Username2 != userGG.Username2)
            {
                error = "Používateľské meno neexistuje";
                return false;
            }
            else if (userTT.Password2 != userGG.Password2)
            {
                error = "Bohužiaľ zadali ste nesprávne heslo";
                return false;
            }

            return true;
        }
    }
}
    
