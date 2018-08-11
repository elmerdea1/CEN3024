namespace BracketWFA
{
    partial class Nav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bracketDBDataSet = new BracketWFA.BracketDBDataSet();
            this.tournamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.TournamentTableAdapter();
            this.tableAdapterManager = new BracketWFA.BracketDBDataSetTableAdapters.TableAdapterManager();
            this.peopleTeamsTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.PeopleTeamsTableAdapter();
            this.teamsTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.TeamsTableAdapter();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bracketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleTeamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bracketDBDataSet
            // 
            this.bracketDBDataSet.DataSetName = "BracketDBDataSet";
            this.bracketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tournamentBindingSource
            // 
            this.tournamentBindingSource.DataMember = "Tournament";
            this.tournamentBindingSource.DataSource = this.bracketDBDataSet;
            // 
            // tournamentTableAdapter
            // 
            this.tournamentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.PeopleTeamsTableAdapter = this.peopleTeamsTableAdapter;
            this.tableAdapterManager.TeamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.TournamentsTeamsTableAdapter = null;
            this.tableAdapterManager.TournamentTableAdapter = this.tournamentTableAdapter;
            this.tableAdapterManager.UpdateOrder = BracketWFA.BracketDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleTeamsTableAdapter
            // 
            this.peopleTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(382, 253);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(382, 253);
            this.toolStripContainer1.TabIndex = 15;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Tournaments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage People";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.bracketDBDataSet;
            // 
            // peopleTeamsBindingSource
            // 
            this.peopleTeamsBindingSource.DataMember = "PeopleTeams";
            this.peopleTeamsBindingSource.DataSource = this.bracketDBDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bracketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleTeamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BracketDBDataSet bracketDBDataSet;
        private System.Windows.Forms.BindingSource tournamentBindingSource;
        private BracketDBDataSetTableAdapters.TournamentTableAdapter tournamentTableAdapter;
        private BracketDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private BracketDBDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private BracketDBDataSetTableAdapters.PeopleTeamsTableAdapter peopleTeamsTableAdapter;
        private System.Windows.Forms.BindingSource peopleTeamsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

