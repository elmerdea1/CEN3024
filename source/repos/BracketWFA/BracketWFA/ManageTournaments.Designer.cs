namespace BracketWFA
{
    partial class ManageTournaments
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sportLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label organizer_IDLabel;
            System.Windows.Forms.Label locationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTournaments));
            this.button1 = new System.Windows.Forms.Button();
            this.bracketDBDataSet = new BracketWFA.BracketDBDataSet();
            this.tournamentListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentListingTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.TournamentListingTableAdapter();
            this.tableAdapterManager = new BracketWFA.BracketDBDataSetTableAdapters.TableAdapterManager();
            this.tournamentListingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tournamentListingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tournamentListingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentTableAdapter = new BracketWFA.BracketDBDataSetTableAdapters.TournamentTableAdapter();
            this.tournamentComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sportTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.organizer_IDTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sportLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            organizer_IDLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bracketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentListingBindingNavigator)).BeginInit();
            this.tournamentListingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentListingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // sportLabel
            // 
            sportLabel.AutoSize = true;
            sportLabel.Location = new System.Drawing.Point(9, 120);
            sportLabel.Name = "sportLabel";
            sportLabel.Size = new System.Drawing.Size(46, 17);
            sportLabel.TabIndex = 8;
            sportLabel.Text = "Sport:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(9, 149);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "Date:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(9, 176);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // organizer_IDLabel
            // 
            organizer_IDLabel.AutoSize = true;
            organizer_IDLabel.Location = new System.Drawing.Point(9, 204);
            organizer_IDLabel.Name = "organizer_IDLabel";
            organizer_IDLabel.Size = new System.Drawing.Size(92, 17);
            organizer_IDLabel.TabIndex = 14;
            organizer_IDLabel.Text = "Organizer ID:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(9, 232);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(66, 17);
            locationLabel.TabIndex = 16;
            locationLabel.Text = "Location:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 284);
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
            // tournamentListingBindingSource
            // 
            this.tournamentListingBindingSource.DataMember = "TournamentListing";
            this.tournamentListingBindingSource.DataSource = this.bracketDBDataSet;
            // 
            // tournamentListingTableAdapter
            // 
            this.tournamentListingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.PeopleTeamsTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TournamentsTeamsTableAdapter = null;
            this.tableAdapterManager.TournamentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BracketWFA.BracketDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tournamentListingBindingNavigator
            // 
            this.tournamentListingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tournamentListingBindingNavigator.BindingSource = this.tournamentListingBindingSource;
            this.tournamentListingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tournamentListingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tournamentListingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tournamentListingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tournamentListingBindingNavigatorSaveItem});
            this.tournamentListingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tournamentListingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tournamentListingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tournamentListingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tournamentListingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tournamentListingBindingNavigator.Name = "tournamentListingBindingNavigator";
            this.tournamentListingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tournamentListingBindingNavigator.Size = new System.Drawing.Size(982, 27);
            this.tournamentListingBindingNavigator.TabIndex = 4;
            this.tournamentListingBindingNavigator.Text = "bindingNavigator1";
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
            // tournamentListingBindingNavigatorSaveItem
            // 
            this.tournamentListingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tournamentListingBindingNavigatorSaveItem.Enabled = false;
            this.tournamentListingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tournamentListingBindingNavigatorSaveItem.Image")));
            this.tournamentListingBindingNavigatorSaveItem.Name = "tournamentListingBindingNavigatorSaveItem";
            this.tournamentListingBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tournamentListingBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // tournamentListingDataGridView
            // 
            this.tournamentListingDataGridView.AutoGenerateColumns = false;
            this.tournamentListingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentListingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tournamentListingDataGridView.DataSource = this.tournamentListingBindingSource;
            this.tournamentListingDataGridView.Location = new System.Drawing.Point(313, 30);
            this.tournamentListingDataGridView.Name = "tournamentListingDataGridView";
            this.tournamentListingDataGridView.RowTemplate.Height = 24;
            this.tournamentListingDataGridView.Size = new System.Drawing.Size(659, 411);
            this.tournamentListingDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn6.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Seed";
            this.dataGridViewTextBoxColumn7.HeaderText = "Seed";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Placement";
            this.dataGridViewTextBoxColumn8.HeaderText = "Placement";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // tournamentComboBox
            // 
            this.tournamentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tournamentListingBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tournamentComboBox.DataSource = this.tournamentBindingSource;
            this.tournamentComboBox.DisplayMember = "Name";
            this.tournamentComboBox.FormattingEnabled = true;
            this.tournamentComboBox.Location = new System.Drawing.Point(7, 31);
            this.tournamentComboBox.Name = "tournamentComboBox";
            this.tournamentComboBox.Size = new System.Drawing.Size(300, 24);
            this.tournamentComboBox.TabIndex = 4;
            this.tournamentComboBox.ValueMember = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournamentBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(107, 61);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournamentBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(107, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // sportTextBox
            // 
            this.sportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournamentBindingSource, "Sport", true));
            this.sportTextBox.Location = new System.Drawing.Point(107, 117);
            this.sportTextBox.Name = "sportTextBox";
            this.sportTextBox.Size = new System.Drawing.Size(200, 22);
            this.sportTextBox.TabIndex = 9;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tournamentBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(107, 145);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournamentBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(107, 173);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // organizer_IDTextBox
            // 
            this.organizer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournamentBindingSource, "Organizer_ID", true));
            this.organizer_IDTextBox.Location = new System.Drawing.Point(107, 201);
            this.organizer_IDTextBox.Name = "organizer_IDTextBox";
            this.organizer_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.organizer_IDTextBox.TabIndex = 15;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tournamentBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(107, 229);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 22);
            this.locationTextBox.TabIndex = 17;
            // 
            // ManageTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(sportLabel);
            this.Controls.Add(this.sportTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(organizer_IDLabel);
            this.Controls.Add(this.organizer_IDTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.tournamentComboBox);
            this.Controls.Add(this.tournamentListingDataGridView);
            this.Controls.Add(this.tournamentListingBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "ManageTournaments";
            this.Text = "Manage Tournaments";
            this.Load += new System.EventHandler(this.ManageTournaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bracketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentListingBindingNavigator)).EndInit();
            this.tournamentListingBindingNavigator.ResumeLayout(false);
            this.tournamentListingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentListingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BracketDBDataSet bracketDBDataSet;
        private System.Windows.Forms.BindingSource tournamentListingBindingSource;
        private BracketDBDataSetTableAdapters.TournamentListingTableAdapter tournamentListingTableAdapter;
        private BracketDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tournamentListingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tournamentListingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tournamentListingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource tournamentBindingSource;
        private BracketDBDataSetTableAdapters.TournamentTableAdapter tournamentTableAdapter;
        private System.Windows.Forms.ComboBox tournamentComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sportTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox organizer_IDTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
    }
}