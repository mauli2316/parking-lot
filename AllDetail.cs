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
    public partial class AllDetail : Form
    {
        public AllDetail()
        {
            InitializeComponent();
        }

        private void AllDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'names5DataSet2.Table5' table. You can move, or remove it, as needed.
            this.table5TableAdapter.Fill(this.names5DataSet2.Table5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExitParking mainform = new ExitParking();
            mainform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddVehicle mainform = new AddVehicle();
            mainform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
