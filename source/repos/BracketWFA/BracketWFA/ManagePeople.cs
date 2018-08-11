using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BracketWFA
{
    public partial class Manage_People : Form
    {
        public Manage_People()
        {
            InitializeComponent();
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bracketDBDataSet);

        }

        private void Manage_People_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bracketDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.bracketDBDataSet.People);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nav f1 = new Nav();
            this.Hide();
            f1.Show();
            

        }
    }
}
