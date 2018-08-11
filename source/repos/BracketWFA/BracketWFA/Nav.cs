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
    public partial class Nav : Form
    {
        public Nav()
        {
            InitializeComponent();
        }

        private void tournamentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tournamentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bracketDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_People mp = new Manage_People();
            mp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageTeams mt = new ManageTeams();
            this.Hide();
            mt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageTournaments mt = new ManageTournaments();
            this.Hide();
            mt.Show();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
