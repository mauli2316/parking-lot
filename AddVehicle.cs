using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParking
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'names5DataSet.Table5' table. You can move, or remove it, as needed.
            this.table5TableAdapter.Fill(this.names5DataSet.Table5);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table5BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vehicle Successfully Added ", "Yes", MessageBoxButtons.YesNo) == DialogResult.No)
                Process.Start("Yes");
            table5BindingSource.EndEdit();
            table5TableAdapter.Update(names5DataSet.Table5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vehicle is Deleted ", "Yes", MessageBoxButtons.YesNo) == DialogResult.No)
                Process.Start("Yes");
            table5BindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExitParking mainform = new ExitParking();
            mainform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllDetail  mainform = new AllDetail();
            mainform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void Member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
