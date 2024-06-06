using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddVehicle Add = new AddVehicle();
            Add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExitParking fm2 = new ExitParking();
            fm2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllDetail fm2 = new AllDetail();
            fm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login fm2 = new Login();
            fm2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
