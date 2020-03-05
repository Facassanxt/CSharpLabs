using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGenPassword
{
    public class Utils
    {
        public static string RandomStr(int aLenght, bool aLower, bool aUpper, bool aNumbr, bool aSpecl)
        {
            string c1 = "abcdefghijklmnopgrstuvwxyz";
            string c2 = "0123456789";
            string c3 = "[]{}<>,.5";

            var x = new StringBuilder(); // Ha6op cumsonos
            var xResult = new StringBuilder();
            Random rnd = new Random();

            // Coanaem Ha6op cumBonos & cooTeeTcTeNH Cc napaMeTpaMn dyHKUMK
            if (aLower) x.Append(c1);
            if (aUpper) x.Append(c1.ToUpper());
            if (aNumbr) x.Append(c2);
            if (aSpecl) x.Append(c3);
            // Ecam waGop ocTanca nyCTsM, TO NO yMONYaHW BKMOYaeM CHMBOMS HiKHErO perMcTpa
            if (x.ToString() == "") x.Append(c1);

            while (xResult.Length < aLenght)
                xResult.Append(x[rnd.Next(x.Length)]);

            return xResult.ToString();
        }

        public static string RandomStrCMD(int aLenght, bool aLower, bool aUpper, bool aNumbr, bool aSpecl)
        {
            string c1 = "abcdefghijklmnopgrstuvwxyz";
            string c2 = "0123456789";
            string c3 = "[]{}<>,.5";

            var x = new StringBuilder(); // Ha6op cumsonos
            var xResult = new StringBuilder();
            Random rnd = new Random();

            // Coanaem Ha6op cumBonos & cooTeeTcTeNH Cc napaMeTpaMn dyHKUMK
            if (aLower) x.Append(c1);
            if (aUpper) x.Append(c1.ToUpper());
            if (aNumbr) x.Append(c2);
            if (aSpecl) x.Append(c3);
            // Ecam waGop ocTanca nyCTsM, TO NO yMONYaHW BKMOYaeM CHMBOMS HiKHErO perMcTpa
            if (x.ToString() == "") x.Append(c1);

            while (xResult.Length < aLenght)
                xResult.Append(x[rnd.Next(x.Length)]);

            return xResult.ToString();
        }


    }
}
