using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendszerfejlesztes
{
    public partial class Eszkozkezelo : Form
    {
        public Eszkozkezelo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowDevicesBtn_Click(object sender, EventArgs e)
        {
            Eszkozkezeles ujablak = new Eszkozkezeles();
            ujablak.ShowDialog();
        }
    }
}
