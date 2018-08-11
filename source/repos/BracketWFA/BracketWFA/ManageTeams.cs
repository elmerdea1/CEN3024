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
    public partial class ManageTeams : Form
    {
        public ManageTeams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nav f1 = new Nav();
            this.Hide();
            f1.Show();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bracketDBDataSet);

        }

        private void ManageTeams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bracketDBDataSet.TeamRoster' table. You can move, or remove it, as needed.
            this.teamRosterTableAdapter.Fill(this.bracketDBDataSet.TeamRoster);

            // TODO: This line of code loads data into the 'bracketDBDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.bracketDBDataSet.Teams);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.peopleTeamsTableAdapter.FillBy(this.bracketDBDataSet.PeopleTeams);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.teamsTableAdapter.FillBy(this.bracketDBDataSet.Teams);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
