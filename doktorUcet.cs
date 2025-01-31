using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdutageApp
{
    internal class doktorUcet
    {

        public string Username1 { get; set; }
        public string Password1 { get; set; }
        public string Gender1 { get; set; }
        public string Fullname1 { get; set; }
        public string Number1 { get; set; }

        private static string error = "V niečom nastala chyba";

        public static void UkazChybu()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(doktorUcet userT, doktorUcet userQ)
        {
            if (userT == null && userQ == null) { return false; }

            if (userT.Username1 != userQ.Username1)
            {
                error = "Používateľské meno neexistuje";
                return false;
            }
            else if (userT.Password1 != userQ.Password1)
            {
                error = "Bohužiaľ zadali ste nesprávne heslo";
                return false;
            }

            return true;
        }
    }
}
