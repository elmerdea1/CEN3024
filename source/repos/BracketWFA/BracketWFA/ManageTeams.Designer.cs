namespace BracketWFA
{
    partial class ManageTeams
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
            System.Windows.Forms.Label teamNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeams));
            this.button1 = new System.Windows.Forms.Button();
            this.bracketDBDataSet = new BracketWFA.BracketDBDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.TeamsTableAdapter();
            this.tableAdapterManager = new BracketWFA.BracketDBDataSetTableAdapters.TableAdapterManager();
            this.peopleTeamsTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.PeopleTeamsTableAdapter();
            this.teamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.teamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teamsComboBox = new System.Windows.Forms.ComboBox();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.peopleTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamRosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamRosterTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.TeamRosterTableAdapter();
            this.teamRosterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamRosterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            teamNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bracketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).BeginInit();
            this.teamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRosterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRosterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRosterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new System.Drawing.Point(61, 74);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(89, 17);
            teamNameLabel.TabIndex = 6;
            teamNameLabel.Text = "Team Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bracketDBDataSet
            // 
            this.bracketDBDataSet.DataSetName = "BracketDBDataSet";
            this.bracketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.bracketDBDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.PeopleTeamsTableAdapter = this.peopleTeamsTableAdapter;
            this.tableAdapterManager.TeamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.TournamentsTeamsTableAdapter = null;
            this.tableAdapterManager.TournamentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BracketWFA.BracketDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleTeamsTableAdapter
            // 
            this.peopleTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // teamsBindingNavigator
            // 
            this.teamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teamsBindingNavigator.BindingSource = this.teamsBindingSource;
            this.teamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.teamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.teamsBindingNavigatorSaveItem});
            this.teamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamsBindingNavigator.Name = "teamsBindingNavigator";
            this.teamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamsBindingNavigator.Size = new System.Drawing.Size(882, 27);
            this.teamsBindingNavigator.TabIndex = 4;
            this.teamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // teamsBindingNavigatorSaveItem
            // 
            this.teamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamsBindingNavigatorSaveItem.Image")));
            this.teamsBindingNavigatorSaveItem.Name = "teamsBindingNavigatorSaveItem";
            this.teamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.teamsBindingNavigatorSaveItem.Text = "Save Data";
            this.teamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamsBindingNavigatorSaveItem_Click);
            // 
            // teamsComboBox
            // 
            this.teamsComboBox.DataSource = this.teamsBindingSource;
            this.teamsComboBox.DisplayMember = "TeamName";
            this.teamsComboBox.FormattingEnabled = true;
            this.teamsComboBox.Location = new System.Drawing.Point(44, 38);
            this.teamsComboBox.Name = "teamsComboBox";
            this.teamsComboBox.Size = new System.Drawing.Size(300, 24);
            this.teamsComboBox.TabIndex = 4;
            this.teamsComboBox.ValueMember = "Id";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamName", true));
            this.teamNameTextBox.Location = new System.Drawing.Point(156, 74);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.teamNameTextBox.TabIndex = 7;
            // 
            // peopleTeamsBindingSource
            // 
            this.peopleTeamsBindingSource.DataMember = "PeopleTeams";
            this.peopleTeamsBindingSource.DataSource = this.bracketDBDataSet;
            // 
            // teamRosterBindingSource
            // 
            this.teamRosterBindingSource.DataSource = this.bracketDBDataSet;
            this.teamRosterBindingSource.Position = 0;
            // 
            // teamRosterTableAdapter
            // 
            this.teamRosterTableAdapter.ClearBeforeFill = true;
            // 
            // teamRosterBindingSource1
            // 
            this.teamRosterBindingSource1.DataMember = "TeamRoster";
            this.teamRosterBindingSource1.DataSource = this.bracketDBDataSet;
            // 
            // teamRosterDataGridView
            // 
            this.teamRosterDataGridView.AutoGenerateColumns = false;
            this.teamRosterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamRosterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.teamRosterDataGridView.DataSource = this.teamRosterBindingSource1;
            this.teamRosterDataGridView.Location = new System.Drawing.Point(350, 38);
            this.teamRosterDataGridView.Name = "teamRosterDataGridView";
            this.teamRosterDataGridView.RowTemplate.Height = 24;
            this.teamRosterDataGridView.Size = new System.Drawing.Size(485, 303);
            this.teamRosterDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn2.HeaderText = "Role";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ManageTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 353);
            this.Controls.Add(this.teamRosterDataGridView);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamsComboBox);
            this.Controls.Add(this.teamsBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "ManageTeams";
            this.Text = "Manage Teams";
            this.Load += new System.EventHandler(this.ManageTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bracketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).EndInit();
            this.teamsBindingNavigator.ResumeLayout(false);
            this.teamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRosterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRosterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamRosterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BracketDBDataSet bracketDBDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private BracketDBDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private BracketDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton teamsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox teamsComboBox;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private BracketDBDataSetTableAdapters.PeopleTeamsTableAdapter peopleTeamsTableAdapter;
        private System.Windows.Forms.BindingSource peopleTeamsBindingSource;
        private System.Windows.Forms.BindingSource teamRosterBindingSource;
        private BracketDBDataSetTableAdapters.TeamRosterTableAdapter teamRosterTableAdapter;
        private System.Windows.Forms.BindingSource teamRosterBindingSource1;
        private System.Windows.Forms.DataGridView teamRosterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}