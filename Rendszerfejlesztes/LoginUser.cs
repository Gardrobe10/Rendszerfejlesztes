using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendszerfejlesztes
{
    class LoginUser
    {

        public string Username { get; set; }
        public string Password { get; set; }

        private static string error = "Hiba";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(LoginUser user1, LoginUser user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.Username != user2.Username)
            {
                error = "Nem létező emailcím";
                return false;
            }

            else if (user1.Password != user2.Password)
            {
                error = "Név és jelszó nem egyezik";
                return false;
            }

            return true;
        }

    }
}
