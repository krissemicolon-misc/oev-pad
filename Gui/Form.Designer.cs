namespace Gui
{
    partial class Form
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
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.stationFinderTab = new System.Windows.Forms.TabPage();
            this.stationFinderStationList = new System.Windows.Forms.ListBox();
            this.stationFinderForm = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stationFinderToButton = new System.Windows.Forms.Button();
            this.stationFinderStationTextBox = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.departureBoardStationSearchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.connectionFinderCustomDateCheck = new System.Windows.Forms.CheckBox();
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
            this.applicationTabControl.Controls.Add(this.overviewTab);
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
            // overviewTab
            // 
            this.overviewTab.Location = new System.Drawing.Point(4, 24);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(792, 422);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
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
            this.stationFinderStationList.TabIndex = 8;
            // 
            // stationFinderForm
            // 
            this.stationFinderForm.BackColor = System.Drawing.Color.Transparent;
            this.stationFinderForm.Controls.Add(this.label5);
            this.stationFinderForm.Controls.Add(this.stationFinderToButton);
            this.stationFinderForm.Controls.Add(this.stationFinderStationTextBox);
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
            this.stationFinderToButton.Location = new System.Drawing.Point(705, 21);
            this.stationFinderToButton.Name = "stationFinderToButton";
            this.stationFinderToButton.Size = new System.Drawing.Size(75, 23);
            this.stationFinderToButton.TabIndex = 7;
            this.stationFinderToButton.Text = "To";
            this.stationFinderToButton.UseVisualStyleBackColor = true;
            this.stationFinderToButton.Click += new System.EventHandler(this.stationFinderSelectTo);
            // 
            // stationFinderStationTextBox
            // 
            this.stationFinderStationTextBox.Location = new System.Drawing.Point(94, 22);
            this.stationFinderStationTextBox.Name = "stationFinderStationTextBox";
            this.stationFinderStationTextBox.Size = new System.Drawing.Size(198, 23);
            this.stationFinderStationTextBox.TabIndex = 0;
            // 
            // stationFinderFromButton
            // 
            this.stationFinderFromButton.Location = new System.Drawing.Point(624, 21);
            this.stationFinderFromButton.Name = "stationFinderFromButton";
            this.stationFinderFromButton.Size = new System.Drawing.Size(75, 23);
            this.stationFinderFromButton.TabIndex = 6;
            this.stationFinderFromButton.Text = "From";
            this.stationFinderFromButton.UseVisualStyleBackColor = true;
            this.stationFinderFromButton.Click += new System.EventHandler(this.stationFinderSelectFrom);
            // 
            // stationFinderButton
            // 
            this.stationFinderButton.Location = new System.Drawing.Point(314, 22);
            this.stationFinderButton.Name = "stationFinderButton";
            this.stationFinderButton.Size = new System.Drawing.Size(130, 23);
            this.stationFinderButton.TabIndex = 2;
            this.stationFinderButton.Text = "Find Station";
            this.stationFinderButton.UseVisualStyleBackColor = true;
            this.stationFinderButton.Click += new System.EventHandler(this.findStation);
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
            this.connectionsFinderConnectionsTable.RowTemplate.Height = 25;
            this.connectionsFinderConnectionsTable.Size = new System.Drawing.Size(786, 331);
            this.connectionsFinderConnectionsTable.TabIndex = 5;
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
            // connectionFinderDatePicker
            // 
            this.connectionFinderDatePicker.Enabled = false;
            this.connectionFinderDatePicker.Location = new System.Drawing.Point(253, 22);
            this.connectionFinderDatePicker.Name = "connectionFinderDatePicker";
            this.connectionFinderDatePicker.Size = new System.Drawing.Size(212, 23);
            this.connectionFinderDatePicker.TabIndex = 7;
            this.connectionFinderDatePicker.Value = new System.DateTime(2022, 4, 12, 16, 0, 52, 0);
            // 
            // connectionFinderToInput
            // 
            this.connectionFinderToInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.connectionFinderToInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.connectionFinderToInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.connectionFinderToInput.FormattingEnabled = true;
            this.connectionFinderToInput.Location = new System.Drawing.Point(50, 51);
            this.connectionFinderToInput.Name = "connectionFinderToInput";
            this.connectionFinderToInput.Size = new System.Drawing.Size(197, 23);
            this.connectionFinderToInput.TabIndex = 6;
            this.connectionFinderToInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.connectionFinderToInputKeyUp);
            // 
            // connectionFinderFromInput
            // 
            this.connectionFinderFromInput.AllowDrop = true;
            this.connectionFinderFromInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.connectionFinderFromInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.connectionFinderFromInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.connectionFinderFromInput.FormattingEnabled = true;
            this.connectionFinderFromInput.Location = new System.Drawing.Point(50, 22);
            this.connectionFinderFromInput.Name = "connectionFinderFromInput";
            this.connectionFinderFromInput.Size = new System.Drawing.Size(197, 23);
            this.connectionFinderFromInput.TabIndex = 5;
            this.connectionFinderFromInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.connectionFinderFromInputKeyUp);
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
            this.connectionFinderViewConnectionsButton.Location = new System.Drawing.Point(253, 51);
            this.connectionFinderViewConnectionsButton.Name = "connectionFinderViewConnectionsButton";
            this.connectionFinderViewConnectionsButton.Size = new System.Drawing.Size(212, 23);
            this.connectionFinderViewConnectionsButton.TabIndex = 2;
            this.connectionFinderViewConnectionsButton.Text = "View Connections";
            this.connectionFinderViewConnectionsButton.UseVisualStyleBackColor = true;
            this.connectionFinderViewConnectionsButton.Click += new System.EventHandler(this.viewConnections);
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
            this.departureBoardTable.TabIndex = 5;
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
            this.departureBoardForm.Controls.Add(this.label4);
            this.departureBoardForm.Controls.Add(this.departureBoardStationSearchTextBox);
            this.departureBoardForm.Controls.Add(this.button1);
            this.departureBoardForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.departureBoardForm.Location = new System.Drawing.Point(3, 3);
            this.departureBoardForm.Name = "departureBoardForm";
            this.departureBoardForm.Size = new System.Drawing.Size(786, 57);
            this.departureBoardForm.TabIndex = 4;
            this.departureBoardForm.TabStop = false;
            this.departureBoardForm.Text = "Find Station Departure Board";
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
            // departureBoardStationSearchTextBox
            // 
            this.departureBoardStationSearchTextBox.Location = new System.Drawing.Point(94, 22);
            this.departureBoardStationSearchTextBox.Name = "departureBoardStationSearchTextBox";
            this.departureBoardStationSearchTextBox.Size = new System.Drawing.Size(198, 23);
            this.departureBoardStationSearchTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Departure Board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.viewDepartureBoard);
            // 
            // connectionFinderCustomDateCheck
            // 
            this.connectionFinderCustomDateCheck.AutoSize = true;
            this.connectionFinderCustomDateCheck.Location = new System.Drawing.Point(471, 24);
            this.connectionFinderCustomDateCheck.Name = "connectionFinderCustomDateCheck";
            this.connectionFinderCustomDateCheck.Size = new System.Drawing.Size(95, 19);
            this.connectionFinderCustomDateCheck.TabIndex = 8;
            this.connectionFinderCustomDateCheck.Text = "Custom Date";
            this.connectionFinderCustomDateCheck.UseVisualStyleBackColor = true;
            this.connectionFinderCustomDateCheck.CheckedChanged += new System.EventHandler(this.connectionFinderCustomDateCheckCheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applicationTabControl);
            this.Name = "Form";
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
        private TabPage overviewTab;
        private TabPage connectionFinderTab;
        private TabPage departureBoardTab;
        private GroupBox departureBoardForm;
        private Label label4;
        private TextBox departureBoardStationSearchTextBox;
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
        private TextBox stationFinderStationTextBox;
        private Button stationFinderButton;
        private Button stationFinderToButton;
        private Button stationFinderFromButton;
        private ListBox stationFinderStationList;
        private ComboBox connectionFinderToInput;
        private ComboBox connectionFinderFromInput;
        private DateTimePicker connectionFinderDatePicker;
        private CheckBox connectionFinderCustomDateCheck;
    }
}