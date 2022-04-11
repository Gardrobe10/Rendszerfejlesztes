using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Rendszerfejlesztes
{

    public partial class LoginForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0Q0wg5lav2LpBjy1IR0fDbYCEb2VKnKBft6Rbtsz",
            BasePath = "https://rf-project-d9d14-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }

            catch
            {
                MessageBox.Show("Hiba!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Users/" + usernamebox.Text);
            LoginUser ResUser = res.ResultAs<LoginUser>();// database result

            LoginUser CurUser = new LoginUser() // USER GIVEN INFO
            {
                Username = usernamebox.Text,
                Password = passwordbox.Text
            };

            if (LoginUser.IsEqual(ResUser, CurUser))
            {
                Eszkozkezelo ujablak = new Eszkozkezelo();
                ujablak.ShowDialog();
            }
            else
            {
                LoginUser.ShowError();
            }

        }
    }
}
