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
    public partial class ManageTournaments : Form
    {
        public ManageTournaments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nav f1 = new Nav();
            this.Hide();
            f1.Show();
        }

        private void ManageTournaments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bracketDBDataSet.Tournament' table. You can move, or remove it, as needed.
            this.tournamentTableAdapter.Fill(this.bracketDBDataSet.Tournament);
            // TODO: This line of code loads data into the 'bracketDBDataSet.Tournament' table. You can move, or remove it, as needed.
            this.tournamentTableAdapter.Fill(this.bracketDBDataSet.Tournament);
            // TODO: This line of code loads data into the 'bracketDBDataSet.TournamentListing' table. You can move, or remove it, as needed.
            this.tournamentListingTableAdapter.Fill(this.bracketDBDataSet.TournamentListing);

        }
    }
}
