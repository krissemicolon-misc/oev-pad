namespace SwissTransport.Gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.applicationTabControl = new System.Windows.Forms.TabControl();
            this.stationFinderTab = new System.Windows.Forms.TabPage();
            this.stationFinderStationList = new System.Windows.Forms.ListBox();
            this.stationFinderForm = new System.Windows.Forms.GroupBox();
            this.stationFinderStationInput = new System.Windows.Forms.ComboBox();
            this.stationFinderShowOnMapButton = new System.Windows.Forms.Button();
            this.stationFinderFindNearestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stationFinderToButton = new System.Windows.Forms.Button();
            this.stationFinderFromButton = new System.Windows.Forms.Button();
            this.stationFinderButton = new System.Windows.Forms.Button();
            this.connectionFinderTab = new System.Windows.Forms.TabPage();
            this.connectionsFinderConnectionsTable = new System.Windows.Forms.DataGridView();
            this.connectionFinderFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionFinderTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionFinderDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionFinderArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionFinderDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionFinderForm = new System.Windows.Forms.GroupBox();
            this.connectionFinderChangeHome = new System.Windows.Forms.Button();
            this.connectionFinderTakeMeHomeButton = new System.Windows.Forms.Button();
            this.connectionFinderEmailShareButton = new System.Windows.Forms.Button();
            this.connectionFinderCustomDateCheck = new System.Windows.Forms.CheckBox();
            this.connectionFinderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.connectionFinderToInput = new System.Windows.Forms.ComboBox();
            this.connectionFinderFromInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionFinderViewConnectionsButton = new System.Windows.Forms.Button();
            this.departureBoardTab = new System.Windows.Forms.TabPage();
            this.departureBoardTable = new System.Windows.Forms.DataGridView();
            this.departureBoardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBoardCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBoardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBoardTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBoardOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBoardStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureBoardForm = new System.Windows.Forms.GroupBox();
            this.departureBoardStationSearchInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.applicationTabControl.SuspendLayout();
            this.stationFinderTab.SuspendLayout();
            this.stationFinderForm.SuspendLayout();
            this.connectionFinderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsFinderConnectionsTable)).BeginInit();
            this.connectionFinderForm.SuspendLayout();
            this.departureBoardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardTable)).BeginInit();
            this.departureBoardForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationTabControl
            // 
            this.applicationTabControl.Controls.Add(this.stationFinderTab);
            this.applicationTabControl.Controls.Add(this.connectionFinderTab);
            this.applicationTabControl.Controls.Add(this.departureBoardTab);
            this.applicationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationTabControl.Location = new System.Drawing.Point(0, 0);
            this.applicationTabControl.Name = "applicationTabControl";
            this.applicationTabControl.SelectedIndex = 0;
            this.applicationTabControl.Size = new System.Drawing.Size(800, 450);
            this.applicationTabControl.TabIndex = 0;
            // 
            // stationFinderTab
            // 
            this.stationFinderTab.Controls.Add(this.stationFinderStationList);
            this.stationFinderTab.Controls.Add(this.stationFinderForm);
            this.stationFinderTab.Location = new System.Drawing.Point(4, 24);
            this.stationFinderTab.Name = "stationFinderTab";
            this.stationFinderTab.Padding = new System.Windows.Forms.Padding(3);
            this.stationFinderTab.Size = new System.Drawing.Size(792, 422);
            this.stationFinderTab.TabIndex = 3;
            this.stationFinderTab.Text = "Station Finder";
            this.stationFinderTab.UseVisualStyleBackColor = true;
            // 
            // stationFinderStationList
            // 
            this.stationFinderStationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationFinderStationList.FormattingEnabled = true;
            this.stationFinderStationList.ItemHeight = 15;
            this.stationFinderStationList.Location = new System.Drawing.Point(3, 62);
            this.stationFinderStationList.Name = "stationFinderStationList";
            this.stationFinderStationList.Size = new System.Drawing.Size(786, 357);
            this.stationFinderStationList.TabIndex = 7;
            // 
            // stationFinderForm
            // 
            this.stationFinderForm.BackColor = System.Drawing.Color.Transparent;
            this.stationFinderForm.Controls.Add(this.stationFinderStationInput);
            this.stationFinderForm.Controls.Add(this.stationFinderShowOnMapButton);
            this.stationFinderForm.Controls.Add(this.stationFinderFindNearestButton);
            this.stationFinderForm.Controls.Add(this.label5);
            this.stationFinderForm.Controls.Add(this.stationFinderToButton);
            this.stationFinderForm.Controls.Add(this.stationFinderFromButton);
            this.stationFinderForm.Controls.Add(this.stationFinderButton);
            this.stationFinderForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.stationFinderForm.Location = new System.Drawing.Point(3, 3);
            this.stationFinderForm.Name = "stationFinderForm";
            this.stationFinderForm.Size = new System.Drawing.Size(786, 59);
            this.stationFinderForm.TabIndex = 4;
            this.stationFinderForm.TabStop = false;
            this.stationFinderForm.Text = "Find a Station";
            // 
            // stationFinderStationInput
            // 
            this.stationFinderStationInput.AllowDrop = true;
            this.stationFinderStationInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stationFinderStationInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stationFinderStationInput.FormattingEnabled = true;
            this.stationFinderStationInput.Location = new System.Drawing.Point(94, 22);
            this.stationFinderStationInput.Name = "stationFinderStationInput";
            this.stationFinderStationInput.Size = new System.Drawing.Size(197, 23);
            this.stationFinderStationInput.TabIndex = 7;
            this.stationFinderStationInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoCompleteComboBoxKeyUp);
            // 
            // stationFinderShowOnMapButton
            // 
            this.stationFinderShowOnMapButton.Location = new System.Drawing.Point(496, 21);
            this.stationFinderShowOnMapButton.Name = "stationFinderShowOnMapButton";
            this.stationFinderShowOnMapButton.Size = new System.Drawing.Size(149, 24);
            this.stationFinderShowOnMapButton.TabIndex = 5;
            this.stationFinderShowOnMapButton.Text = "View Location in Browser";
            this.stationFinderShowOnMapButton.UseVisualStyleBackColor = true;
            this.stationFinderShowOnMapButton.Click += new System.EventHandler(this.ShowStationLocationInBrowser);
            // 
            // stationFinderFindNearestButton
            // 
            this.stationFinderFindNearestButton.Location = new System.Drawing.Point(651, 21);
            this.stationFinderFindNearestButton.Name = "stationFinderFindNearestButton";
            this.stationFinderFindNearestButton.Size = new System.Drawing.Size(129, 24);
            this.stationFinderFindNearestButton.TabIndex = 6;
            this.stationFinderFindNearestButton.Text = "Find Nearest Station";
            this.stationFinderFindNearestButton.UseVisualStyleBackColor = true;
            this.stationFinderFindNearestButton.Click += new System.EventHandler(this.StationFinderFindNearestStation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Station Name:";
            // 
            // stationFinderToButton
            // 
            this.stationFinderToButton.Location = new System.Drawing.Point(421, 21);
            this.stationFinderToButton.Name = "stationFinderToButton";
            this.stationFinderToButton.Size = new System.Drawing.Size(50, 24);
            this.stationFinderToButton.TabIndex = 4;
            this.stationFinderToButton.Text = "To";
            this.stationFinderToButton.UseVisualStyleBackColor = true;
            this.stationFinderToButton.Click += new System.EventHandler(this.StationFinderSelectTo);
            // 
            // stationFinderFromButton
            // 
            this.stationFinderFromButton.Location = new System.Drawing.Point(365, 21);
            this.stationFinderFromButton.Name = "stationFinderFromButton";
            this.stationFinderFromButton.Size = new System.Drawing.Size(50, 24);
            this.stationFinderFromButton.TabIndex = 3;
            this.stationFinderFromButton.Text = "From";
            this.stationFinderFromButton.UseVisualStyleBackColor = true;
            this.stationFinderFromButton.Click += new System.EventHandler(this.StationFinderSelectFrom);
            // 
            // stationFinderButton
            // 
            this.stationFinderButton.Location = new System.Drawing.Point(297, 21);
            this.stationFinderButton.Name = "stationFinderButton";
            this.stationFinderButton.Size = new System.Drawing.Size(38, 24);
            this.stationFinderButton.TabIndex = 2;
            this.stationFinderButton.Text = "Find Station";
            this.stationFinderButton.UseVisualStyleBackColor = true;
            this.stationFinderButton.Click += new System.EventHandler(this.FindStation);
            // 
            // connectionFinderTab
            // 
            this.connectionFinderTab.Controls.Add(this.connectionsFinderConnectionsTable);
            this.connectionFinderTab.Controls.Add(this.connectionFinderForm);
            this.connectionFinderTab.Location = new System.Drawing.Point(4, 24);
            this.connectionFinderTab.Name = "connectionFinderTab";
            this.connectionFinderTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionFinderTab.Size = new System.Drawing.Size(792, 422);
            this.connectionFinderTab.TabIndex = 1;
            this.connectionFinderTab.Text = "Connection Finder";
            this.connectionFinderTab.UseVisualStyleBackColor = true;
            // 
            // connectionsFinderConnectionsTable
            // 
            this.connectionsFinderConnectionsTable.AllowUserToAddRows = false;
            this.connectionsFinderConnectionsTable.AllowUserToDeleteRows = false;
            this.connectionsFinderConnectionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsFinderConnectionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.connectionFinderFrom,
            this.connectionFinderTo,
            this.connectionFinderDeparture,
            this.connectionFinderArrival,
            this.connectionFinderDuration});
            this.connectionsFinderConnectionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsFinderConnectionsTable.Location = new System.Drawing.Point(3, 88);
            this.connectionsFinderConnectionsTable.Name = "connectionsFinderConnectionsTable";
            this.connectionsFinderConnectionsTable.ReadOnly = true;
            this.connectionsFinderConnectionsTable.RowHeadersWidth = 20;
            this.connectionsFinderConnectionsTable.RowTemplate.Height = 25;
            this.connectionsFinderConnectionsTable.Size = new System.Drawing.Size(786, 331);
            this.connectionsFinderConnectionsTable.TabIndex = 12;
            // 
            // connectionFinderFrom
            // 
            this.connectionFinderFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.connectionFinderFrom.HeaderText = "From";
            this.connectionFinderFrom.Name = "connectionFinderFrom";
            this.connectionFinderFrom.ReadOnly = true;
            // 
            // connectionFinderTo
            // 
            this.connectionFinderTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.connectionFinderTo.HeaderText = "To";
            this.connectionFinderTo.Name = "connectionFinderTo";
            this.connectionFinderTo.ReadOnly = true;
            // 
            // connectionFinderDeparture
            // 
            this.connectionFinderDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.connectionFinderDeparture.HeaderText = "Departure";
            this.connectionFinderDeparture.Name = "connectionFinderDeparture";
            this.connectionFinderDeparture.ReadOnly = true;
            // 
            // connectionFinderArrival
            // 
            this.connectionFinderArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.connectionFinderArrival.HeaderText = "Arrival";
            this.connectionFinderArrival.Name = "connectionFinderArrival";
            this.connectionFinderArrival.ReadOnly = true;
            // 
            // connectionFinderDuration
            // 
            this.connectionFinderDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.connectionFinderDuration.HeaderText = "Duration";
            this.connectionFinderDuration.Name = "connectionFinderDuration";
            this.connectionFinderDuration.ReadOnly = true;
            // 
            // connectionFinderForm
            // 
            this.connectionFinderForm.BackColor = System.Drawing.Color.Transparent;
            this.connectionFinderForm.Controls.Add(this.connectionFinderChangeHome);
            this.connectionFinderForm.Controls.Add(this.connectionFinderTakeMeHomeButton);
            this.connectionFinderForm.Controls.Add(this.connectionFinderEmailShareButton);
            this.connectionFinderForm.Controls.Add(this.connectionFinderCustomDateCheck);
            this.connectionFinderForm.Controls.Add(this.connectionFinderDatePicker);
            this.connectionFinderForm.Controls.Add(this.connectionFinderToInput);
            this.connectionFinderForm.Controls.Add(this.connectionFinderFromInput);
            this.connectionFinderForm.Controls.Add(this.label2);
            this.connectionFinderForm.Controls.Add(this.label1);
            this.connectionFinderForm.Controls.Add(this.connectionFinderViewConnectionsButton);
            this.connectionFinderForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionFinderForm.Location = new System.Drawing.Point(3, 3);
            this.connectionFinderForm.Name = "connectionFinderForm";
            this.connectionFinderForm.Size = new System.Drawing.Size(786, 85);
            this.connectionFinderForm.TabIndex = 3;
            this.connectionFinderForm.TabStop = false;
            this.connectionFinderForm.Text = "Find Connections";
            // 
            // connectionFinderChangeHome
            // 
            this.connectionFinderChangeHome.Location = new System.Drawing.Point(487, 52);
            this.connectionFinderChangeHome.Name = "connectionFinderChangeHome";
            this.connectionFinderChangeHome.Size = new System.Drawing.Size(95, 23);
            this.connectionFinderChangeHome.TabIndex = 10;
            this.connectionFinderChangeHome.Text = "Set Home";
            this.connectionFinderChangeHome.UseVisualStyleBackColor = true;
            this.connectionFinderChangeHome.Click += new System.EventHandler(this.TakeMeHomeSettings);
            // 
            // connectionFinderTakeMeHomeButton
            // 
            this.connectionFinderTakeMeHomeButton.Location = new System.Drawing.Point(370, 52);
            this.connectionFinderTakeMeHomeButton.Name = "connectionFinderTakeMeHomeButton";
            this.connectionFinderTakeMeHomeButton.Size = new System.Drawing.Size(111, 23);
            this.connectionFinderTakeMeHomeButton.TabIndex = 9;
            this.connectionFinderTakeMeHomeButton.Text = "Take Me Home";
            this.connectionFinderTakeMeHomeButton.UseVisualStyleBackColor = true;
            this.connectionFinderTakeMeHomeButton.Click += new System.EventHandler(this.TakeMeHome);
            // 
            // connectionFinderEmailShareButton
            // 
            this.connectionFinderEmailShareButton.BackColor = System.Drawing.Color.White;
            this.connectionFinderEmailShareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionFinderEmailShareButton.Location = new System.Drawing.Point(669, 22);
            this.connectionFinderEmailShareButton.Name = "connectionFinderEmailShareButton";
            this.connectionFinderEmailShareButton.Size = new System.Drawing.Size(111, 57);
            this.connectionFinderEmailShareButton.TabIndex = 11;
            this.connectionFinderEmailShareButton.Text = "Share Connection over Email";
            this.connectionFinderEmailShareButton.UseVisualStyleBackColor = false;
            this.connectionFinderEmailShareButton.Click += new System.EventHandler(this.ShareConnectionOverEmail);
            // 
            // connectionFinderCustomDateCheck
            // 
            this.connectionFinderCustomDateCheck.AutoSize = true;
            this.connectionFinderCustomDateCheck.Location = new System.Drawing.Point(487, 24);
            this.connectionFinderCustomDateCheck.Name = "connectionFinderCustomDateCheck";
            this.connectionFinderCustomDateCheck.Size = new System.Drawing.Size(95, 19);
            this.connectionFinderCustomDateCheck.TabIndex = 7;
            this.connectionFinderCustomDateCheck.Text = "Custom Date";
            this.connectionFinderCustomDateCheck.UseVisualStyleBackColor = true;
            this.connectionFinderCustomDateCheck.CheckedChanged += new System.EventHandler(this.ConnectionFinderCustomDateCheckCheckedChanged);
            // 
            // connectionFinderDatePicker
            // 
            this.connectionFinderDatePicker.Enabled = false;
            this.connectionFinderDatePicker.Location = new System.Drawing.Point(253, 22);
            this.connectionFinderDatePicker.Name = "connectionFinderDatePicker";
            this.connectionFinderDatePicker.Size = new System.Drawing.Size(228, 23);
            this.connectionFinderDatePicker.TabIndex = 8;
            this.connectionFinderDatePicker.Value = new System.DateTime(2022, 4, 12, 16, 0, 52, 0);
            // 
            // connectionFinderToInput
            // 
            this.connectionFinderToInput.AllowDrop = true;
            this.connectionFinderToInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.connectionFinderToInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.connectionFinderToInput.FormattingEnabled = true;
            this.connectionFinderToInput.Location = new System.Drawing.Point(50, 51);
            this.connectionFinderToInput.Name = "connectionFinderToInput";
            this.connectionFinderToInput.Size = new System.Drawing.Size(197, 23);
            this.connectionFinderToInput.TabIndex = 6;
            this.connectionFinderToInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoCompleteComboBoxKeyUp);
            // 
            // connectionFinderFromInput
            // 
            this.connectionFinderFromInput.AllowDrop = true;
            this.connectionFinderFromInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.connectionFinderFromInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.connectionFinderFromInput.FormattingEnabled = true;
            this.connectionFinderFromInput.Location = new System.Drawing.Point(50, 22);
            this.connectionFinderFromInput.Name = "connectionFinderFromInput";
            this.connectionFinderFromInput.Size = new System.Drawing.Size(197, 23);
            this.connectionFinderFromInput.TabIndex = 5;
            this.connectionFinderFromInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoCompleteComboBoxKeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // connectionFinderViewConnectionsButton
            // 
            this.connectionFinderViewConnectionsButton.Location = new System.Drawing.Point(253, 52);
            this.connectionFinderViewConnectionsButton.Name = "connectionFinderViewConnectionsButton";
            this.connectionFinderViewConnectionsButton.Size = new System.Drawing.Size(111, 23);
            this.connectionFinderViewConnectionsButton.TabIndex = 8;
            this.connectionFinderViewConnectionsButton.Text = "View Connections";
            this.connectionFinderViewConnectionsButton.UseVisualStyleBackColor = true;
            this.connectionFinderViewConnectionsButton.Click += new System.EventHandler(this.FindConnections);
            // 
            // departureBoardTab
            // 
            this.departureBoardTab.Controls.Add(this.departureBoardTable);
            this.departureBoardTab.Controls.Add(this.departureBoardForm);
            this.departureBoardTab.Location = new System.Drawing.Point(4, 24);
            this.departureBoardTab.Name = "departureBoardTab";
            this.departureBoardTab.Padding = new System.Windows.Forms.Padding(3);
            this.departureBoardTab.Size = new System.Drawing.Size(792, 422);
            this.departureBoardTab.TabIndex = 2;
            this.departureBoardTab.Text = "Departure Board";
            this.departureBoardTab.UseVisualStyleBackColor = true;
            // 
            // departureBoardTable
            // 
            this.departureBoardTable.AllowUserToAddRows = false;
            this.departureBoardTable.AllowUserToDeleteRows = false;
            this.departureBoardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departureBoardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureBoardName,
            this.departureBoardCategory,
            this.departureBoardNumber,
            this.departureBoardTo,
            this.departureBoardOperator,
            this.departureBoardStop});
            this.departureBoardTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departureBoardTable.Location = new System.Drawing.Point(3, 60);
            this.departureBoardTable.Name = "departureBoardTable";
            this.departureBoardTable.ReadOnly = true;
            this.departureBoardTable.RowTemplate.Height = 25;
            this.departureBoardTable.Size = new System.Drawing.Size(786, 359);
            this.departureBoardTable.TabIndex = 15;
            // 
            // departureBoardName
            // 
            this.departureBoardName.HeaderText = "Name";
            this.departureBoardName.Name = "departureBoardName";
            this.departureBoardName.ReadOnly = true;
            // 
            // departureBoardCategory
            // 
            this.departureBoardCategory.HeaderText = "Category";
            this.departureBoardCategory.Name = "departureBoardCategory";
            this.departureBoardCategory.ReadOnly = true;
            // 
            // departureBoardNumber
            // 
            this.departureBoardNumber.HeaderText = "Number";
            this.departureBoardNumber.Name = "departureBoardNumber";
            this.departureBoardNumber.ReadOnly = true;
            // 
            // departureBoardTo
            // 
            this.departureBoardTo.HeaderText = "To";
            this.departureBoardTo.Name = "departureBoardTo";
            this.departureBoardTo.ReadOnly = true;
            // 
            // departureBoardOperator
            // 
            this.departureBoardOperator.HeaderText = "Operator";
            this.departureBoardOperator.Name = "departureBoardOperator";
            this.departureBoardOperator.ReadOnly = true;
            // 
            // departureBoardStop
            // 
            this.departureBoardStop.HeaderText = "Stop";
            this.departureBoardStop.Name = "departureBoardStop";
            this.departureBoardStop.ReadOnly = true;
            // 
            // departureBoardForm
            // 
            this.departureBoardForm.BackColor = System.Drawing.Color.Transparent;
            this.departureBoardForm.Controls.Add(this.departureBoardStationSearchInput);
            this.departureBoardForm.Controls.Add(this.label4);
            this.departureBoardForm.Controls.Add(this.button1);
            this.departureBoardForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.departureBoardForm.Location = new System.Drawing.Point(3, 3);
            this.departureBoardForm.Name = "departureBoardForm";
            this.departureBoardForm.Size = new System.Drawing.Size(786, 57);
            this.departureBoardForm.TabIndex = 4;
            this.departureBoardForm.TabStop = false;
            this.departureBoardForm.Text = "Find Station Departure Board";
            // 
            // departureBoardStationSearchInput
            // 
            this.departureBoardStationSearchInput.AllowDrop = true;
            this.departureBoardStationSearchInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departureBoardStationSearchInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departureBoardStationSearchInput.FormattingEnabled = true;
            this.departureBoardStationSearchInput.Location = new System.Drawing.Point(94, 22);
            this.departureBoardStationSearchInput.Name = "departureBoardStationSearchInput";
            this.departureBoardStationSearchInput.Size = new System.Drawing.Size(211, 23);
            this.departureBoardStationSearchInput.TabIndex = 15;
            this.departureBoardStationSearchInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoCompleteComboBoxKeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Station Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "View Departure Board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewDepartureBoard);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applicationTabControl);
            this.Name = "MainForm";
            this.Text = "Oev Pad";
            this.applicationTabControl.ResumeLayout(false);
            this.stationFinderTab.ResumeLayout(false);
            this.stationFinderForm.ResumeLayout(false);
            this.stationFinderForm.PerformLayout();
            this.connectionFinderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionsFinderConnectionsTable)).EndInit();
            this.connectionFinderForm.ResumeLayout(false);
            this.connectionFinderForm.PerformLayout();
            this.departureBoardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardTable)).EndInit();
            this.departureBoardForm.ResumeLayout(false);
            this.departureBoardForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl applicationTabControl;
        private TabPage connectionFinderTab;
        private TabPage departureBoardTab;
        private GroupBox departureBoardForm;
        private Label label4;
        private Button button1;
        private DataGridView departureBoardTable;
        private DataGridViewTextBoxColumn connectionFinderFrom;
        private DataGridViewTextBoxColumn connectionFinderTo;
        private DataGridViewTextBoxColumn connectionFinderDeparture;
        private DataGridViewTextBoxColumn connectionFinderArrival;
        private DataGridViewTextBoxColumn connectionFinderDuration;
        private DataGridViewTextBoxColumn departureBoardName;
        private DataGridViewTextBoxColumn departureBoardCategory;
        private DataGridViewTextBoxColumn departureBoardNumber;
        private DataGridViewTextBoxColumn departureBoardTo;
        private DataGridViewTextBoxColumn departureBoardOperator;
        private DataGridViewTextBoxColumn departureBoardStop;
        private GroupBox connectionFinderForm;
        private Button connectionFinderViewConnectionsButton;
        private Label label2;
        private Label label1;
        private DataGridView connectionsFinderConnectionsTable;
        private TabPage stationFinderTab;
        private GroupBox stationFinderForm;
        private Label label5;
        private Button stationFinderButton;
        private Button stationFinderToButton;
        private Button stationFinderFromButton;
        private ListBox stationFinderStationList;
        private ComboBox connectionFinderToInput;
        private ComboBox connectionFinderFromInput;
        private DateTimePicker connectionFinderDatePicker;
        private CheckBox connectionFinderCustomDateCheck;
        private Button connectionFinderEmailShareButton;
        private Button stationFinderFindNearestButton;
        private Button stationFinderShowOnMapButton;
        private Button connectionFinderTakeMeHomeButton;
        private Button connectionFinderChangeHome;
        private ComboBox stationFinderStationInput;
        private ComboBox departureBoardStationSearchInput;
    }
}