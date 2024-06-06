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
    public partial class ExitParking : Form
    {
        public ExitParking()
        {
            InitializeComponent();
        }

        private void ExitParking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'names5DataSet1.Table5' table. You can move, or remove it, as needed.
            this.table5TableAdapter.Fill(this.names5DataSet1.Table5);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table5BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vehicle Slot Successfully Added ", "Yes", MessageBoxButtons.YesNo) == DialogResult.No)
                Process.Start("Yes","No");
            table5BindingSource.EndEdit();
            table5TableAdapter.Update(names5DataSet1.Table5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vehicle is Delete ", "Yes", MessageBoxButtons.YesNo) == DialogResult.No)
                Process.Start("Yes");
            table5BindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddVehicle mainform = new AddVehicle();
            mainform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllDetail mainform = new AllDetail();
            mainform.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AllDetail fm2 = new AllDetail();
            fm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm fm2 = new MainForm();
            fm2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
