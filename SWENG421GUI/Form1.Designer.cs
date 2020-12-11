namespace SWENG421GUI
{
    partial class Form1
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
            this.OriginOutput = new System.Windows.Forms.TextBox();
            this.SenderOutput = new System.Windows.Forms.TextBox();
            this.ParcelOutput = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.TabSelector = new System.Windows.Forms.TabControl();
            this.CompanyTab = new System.Windows.Forms.TabPage();
            this.CompanyVehicles = new System.Windows.Forms.ListBox();
            this.CompanyVehiclesOutput = new System.Windows.Forms.Label();
            this.CompanyNameOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleTab = new System.Windows.Forms.TabPage();
            this.otherLabel = new System.Windows.Forms.Label();
            this.attributesbox = new System.Windows.Forms.TextBox();
            this.TodoList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MpgOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadCountOutput = new System.Windows.Forms.TextBox();
            this.LoadCountLabel = new System.Windows.Forms.Label();
            this.SelectVehicleLabel = new System.Windows.Forms.Label();
            this.VehicleComboBox = new System.Windows.Forms.ComboBox();
            this.RouteTab = new System.Windows.Forms.TabPage();
            this.RouteOrderList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AssignedOutput = new System.Windows.Forms.TextBox();
            this.AssignedLabel = new System.Windows.Forms.Label();
            this.SelectRouteLabel = new System.Windows.Forms.Label();
            this.RouteComboBox = new System.Windows.Forms.ComboBox();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.CurrentStateOutput = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ParcelLabel = new System.Windows.Forms.Label();
            this.ReceiverOutput = new System.Windows.Forms.TextBox();
            this.ReceiverLabel = new System.Windows.Forms.Label();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.DestinationOutput = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.SelectOrderLabel = new System.Windows.Forms.Label();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.ManageTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddParcelTab = new System.Windows.Forms.TabPage();
            this.addShippingObjectbutton = new System.Windows.Forms.Button();
            this.selectPalletablebox = new System.Windows.Forms.ComboBox();
            this.palletableNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PalletableLabel = new System.Windows.Forms.Label();
            this.addShippingObjectStatusBox = new System.Windows.Forms.TextBox();
            this.soNameLabel = new System.Windows.Forms.Label();
            this.soNameBox = new System.Windows.Forms.TextBox();
            this.SObox = new System.Windows.Forms.ComboBox();
            this.loadableSObox = new System.Windows.Forms.CheckBox();
            this.builtinSObox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddOrderTab = new System.Windows.Forms.TabPage();
            this.AddRouteTab = new System.Windows.Forms.TabPage();
            this.AddVehicleTab = new System.Windows.Forms.TabPage();
            this.IdentifierBox = new System.Windows.Forms.TextBox();
            this.loadCountBox = new System.Windows.Forms.TextBox();
            this.mpgBox = new System.Windows.Forms.TextBox();
            this.attributeBox = new System.Windows.Forms.TextBox();
            this.confirmAddVehicleButton = new System.Windows.Forms.Button();
            this.VehicleAddStatusBox = new System.Windows.Forms.TextBox();
            this.AttributeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AvailableVehicleTypesBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoadableBox = new System.Windows.Forms.CheckBox();
            this.BuiltInBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddObjectBox = new System.Windows.Forms.ComboBox();
            this.AddObjectLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.TabSelector.SuspendLayout();
            this.CompanyTab.SuspendLayout();
            this.VehicleTab.SuspendLayout();
            this.RouteTab.SuspendLayout();
            this.OrderTab.SuspendLayout();
            this.ManageTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AddParcelTab.SuspendLayout();
            this.AddVehicleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginOutput
            // 
            this.OriginOutput.Enabled = false;
            this.OriginOutput.Location = new System.Drawing.Point(140, 45);
            this.OriginOutput.Margin = new System.Windows.Forms.Padding(2);
            this.OriginOutput.Name = "OriginOutput";
            this.OriginOutput.Size = new System.Drawing.Size(344, 26);
            this.OriginOutput.TabIndex = 13;
            // 
            // SenderOutput
            // 
            this.SenderOutput.Enabled = false;
            this.SenderOutput.Location = new System.Drawing.Point(140, 113);
            this.SenderOutput.Margin = new System.Windows.Forms.Padding(2);
            this.SenderOutput.Name = "SenderOutput";
            this.SenderOutput.Size = new System.Drawing.Size(344, 26);
            this.SenderOutput.TabIndex = 17;
            // 
            // ParcelOutput
            // 
            this.ParcelOutput.Enabled = false;
            this.ParcelOutput.Location = new System.Drawing.Point(140, 183);
            this.ParcelOutput.Margin = new System.Windows.Forms.Padding(2);
            this.ParcelOutput.Name = "ParcelOutput";
            this.ParcelOutput.Size = new System.Drawing.Size(344, 26);
            this.ParcelOutput.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OutputLabel);
            this.splitContainer1.Panel1.Controls.Add(this.OutputPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabSelector);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 571);
            this.splitContainer1.SplitterDistance = 506;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(88, 1);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(204, 37);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Text = "Output Panel";
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoSize = true;
            this.OutputPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OutputPanel.Controls.Add(this.OutputTextBox);
            this.OutputPanel.Location = new System.Drawing.Point(0, 41);
            this.OutputPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(507, 529);
            this.OutputPanel.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputTextBox.HideSelection = false;
            this.OutputTextBox.Location = new System.Drawing.Point(-1, 0);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(506, 527);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.Text = "";
            // 
            // TabSelector
            // 
            this.TabSelector.Controls.Add(this.CompanyTab);
            this.TabSelector.Controls.Add(this.VehicleTab);
            this.TabSelector.Controls.Add(this.RouteTab);
            this.TabSelector.Controls.Add(this.OrderTab);
            this.TabSelector.Controls.Add(this.ManageTab);
            this.TabSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSelector.Location = new System.Drawing.Point(-1, 2);
            this.TabSelector.Margin = new System.Windows.Forms.Padding(2);
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.SelectedIndex = 0;
            this.TabSelector.Size = new System.Drawing.Size(506, 568);
            this.TabSelector.TabIndex = 0;
            // 
            // CompanyTab
            // 
            this.CompanyTab.Controls.Add(this.CompanyVehicles);
            this.CompanyTab.Controls.Add(this.CompanyVehiclesOutput);
            this.CompanyTab.Controls.Add(this.CompanyNameOutput);
            this.CompanyTab.Controls.Add(this.label3);
            this.CompanyTab.Location = new System.Drawing.Point(4, 29);
            this.CompanyTab.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyTab.Name = "CompanyTab";
            this.CompanyTab.Padding = new System.Windows.Forms.Padding(2);
            this.CompanyTab.Size = new System.Drawing.Size(498, 535);
            this.CompanyTab.TabIndex = 0;
            this.CompanyTab.Text = "Company";
            this.CompanyTab.UseVisualStyleBackColor = true;
            // 
            // CompanyVehicles
            // 
            this.CompanyVehicles.DisplayMember = "identifier";
            this.CompanyVehicles.FormattingEnabled = true;
            this.CompanyVehicles.ItemHeight = 20;
            this.CompanyVehicles.Location = new System.Drawing.Point(146, 42);
            this.CompanyVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyVehicles.Name = "CompanyVehicles";
            this.CompanyVehicles.Size = new System.Drawing.Size(331, 444);
            this.CompanyVehicles.TabIndex = 6;
            // 
            // CompanyVehiclesOutput
            // 
            this.CompanyVehiclesOutput.AutoSize = true;
            this.CompanyVehiclesOutput.Location = new System.Drawing.Point(4, 42);
            this.CompanyVehiclesOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyVehiclesOutput.Name = "CompanyVehiclesOutput";
            this.CompanyVehiclesOutput.Size = new System.Drawing.Size(144, 20);
            this.CompanyVehiclesOutput.TabIndex = 5;
            this.CompanyVehiclesOutput.Text = "Company Vehicles:";
            this.CompanyVehiclesOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompanyNameOutput
            // 
            this.CompanyNameOutput.Enabled = false;
            this.CompanyNameOutput.Location = new System.Drawing.Point(146, 8);
            this.CompanyNameOutput.Margin = new System.Windows.Forms.Padding(2);
            this.CompanyNameOutput.Name = "CompanyNameOutput";
            this.CompanyNameOutput.Size = new System.Drawing.Size(332, 26);
            this.CompanyNameOutput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Company Name:";
            // 
            // VehicleTab
            // 
            this.VehicleTab.Controls.Add(this.otherLabel);
            this.VehicleTab.Controls.Add(this.attributesbox);
            this.VehicleTab.Controls.Add(this.TodoList);
            this.VehicleTab.Controls.Add(this.label2);
            this.VehicleTab.Controls.Add(this.MpgOutput);
            this.VehicleTab.Controls.Add(this.label1);
            this.VehicleTab.Controls.Add(this.LoadCountOutput);
            this.VehicleTab.Controls.Add(this.LoadCountLabel);
            this.VehicleTab.Controls.Add(this.SelectVehicleLabel);
            this.VehicleTab.Controls.Add(this.VehicleComboBox);
            this.VehicleTab.Location = new System.Drawing.Point(4, 29);
            this.VehicleTab.Margin = new System.Windows.Forms.Padding(2);
            this.VehicleTab.Name = "VehicleTab";
            this.VehicleTab.Padding = new System.Windows.Forms.Padding(2);
            this.VehicleTab.Size = new System.Drawing.Size(498, 535);
            this.VehicleTab.TabIndex = 1;
            this.VehicleTab.Text = "Vehicles";
            this.VehicleTab.UseVisualStyleBackColor = true;
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Location = new System.Drawing.Point(0, 122);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(126, 20);
            this.otherLabel.TabIndex = 11;
            this.otherLabel.Text = "Other Attributes:";
            // 
            // attributesbox
            // 
            this.attributesbox.Enabled = false;
            this.attributesbox.Location = new System.Drawing.Point(130, 119);
            this.attributesbox.Name = "attributesbox";
            this.attributesbox.Size = new System.Drawing.Size(356, 26);
            this.attributesbox.TabIndex = 10;
            // 
            // TodoList
            // 
            this.TodoList.FormattingEnabled = true;
            this.TodoList.ItemHeight = 20;
            this.TodoList.Location = new System.Drawing.Point(130, 163);
            this.TodoList.Margin = new System.Windows.Forms.Padding(2);
            this.TodoList.Name = "TodoList";
            this.TodoList.Size = new System.Drawing.Size(356, 324);
            this.TodoList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Todo:";
            // 
            // MpgOutput
            // 
            this.MpgOutput.Enabled = false;
            this.MpgOutput.Location = new System.Drawing.Point(130, 80);
            this.MpgOutput.Margin = new System.Windows.Forms.Padding(2);
            this.MpgOutput.Name = "MpgOutput";
            this.MpgOutput.Size = new System.Drawing.Size(356, 26);
            this.MpgOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mpg:";
            // 
            // LoadCountOutput
            // 
            this.LoadCountOutput.Enabled = false;
            this.LoadCountOutput.Location = new System.Drawing.Point(130, 46);
            this.LoadCountOutput.Margin = new System.Windows.Forms.Padding(2);
            this.LoadCountOutput.Name = "LoadCountOutput";
            this.LoadCountOutput.Size = new System.Drawing.Size(356, 26);
            this.LoadCountOutput.TabIndex = 5;
            // 
            // LoadCountLabel
            // 
            this.LoadCountLabel.AutoSize = true;
            this.LoadCountLabel.Location = new System.Drawing.Point(4, 49);
            this.LoadCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoadCountLabel.Name = "LoadCountLabel";
            this.LoadCountLabel.Size = new System.Drawing.Size(96, 20);
            this.LoadCountLabel.TabIndex = 4;
            this.LoadCountLabel.Text = "Load Count:";
            // 
            // SelectVehicleLabel
            // 
            this.SelectVehicleLabel.AutoSize = true;
            this.SelectVehicleLabel.Location = new System.Drawing.Point(4, 11);
            this.SelectVehicleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectVehicleLabel.Name = "SelectVehicleLabel";
            this.SelectVehicleLabel.Size = new System.Drawing.Size(114, 20);
            this.SelectVehicleLabel.TabIndex = 1;
            this.SelectVehicleLabel.Text = "Select Vehicle:";
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.DisplayMember = "identifier";
            this.VehicleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(130, 8);
            this.VehicleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(356, 28);
            this.VehicleComboBox.TabIndex = 0;
            this.VehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.VehicleComboBox_SelectedIndexChanged);
            // 
            // RouteTab
            // 
            this.RouteTab.Controls.Add(this.RouteOrderList);
            this.RouteTab.Controls.Add(this.label5);
            this.RouteTab.Controls.Add(this.AssignedOutput);
            this.RouteTab.Controls.Add(this.AssignedLabel);
            this.RouteTab.Controls.Add(this.SelectRouteLabel);
            this.RouteTab.Controls.Add(this.RouteComboBox);
            this.RouteTab.Location = new System.Drawing.Point(4, 29);
            this.RouteTab.Margin = new System.Windows.Forms.Padding(2);
            this.RouteTab.Name = "RouteTab";
            this.RouteTab.Padding = new System.Windows.Forms.Padding(2);
            this.RouteTab.Size = new System.Drawing.Size(498, 535);
            this.RouteTab.TabIndex = 2;
            this.RouteTab.Text = "Routes";
            this.RouteTab.UseVisualStyleBackColor = true;
            // 
            // RouteOrderList
            // 
            this.RouteOrderList.DisplayMember = "trackingNumber";
            this.RouteOrderList.FormattingEnabled = true;
            this.RouteOrderList.ItemHeight = 20;
            this.RouteOrderList.Location = new System.Drawing.Point(122, 88);
            this.RouteOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.RouteOrderList.Name = "RouteOrderList";
            this.RouteOrderList.Size = new System.Drawing.Size(366, 404);
            this.RouteOrderList.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Orders:";
            // 
            // AssignedOutput
            // 
            this.AssignedOutput.Enabled = false;
            this.AssignedOutput.Location = new System.Drawing.Point(122, 51);
            this.AssignedOutput.Margin = new System.Windows.Forms.Padding(2);
            this.AssignedOutput.Name = "AssignedOutput";
            this.AssignedOutput.Size = new System.Drawing.Size(366, 26);
            this.AssignedOutput.TabIndex = 11;
            // 
            // AssignedLabel
            // 
            this.AssignedLabel.AutoSize = true;
            this.AssignedLabel.Location = new System.Drawing.Point(4, 54);
            this.AssignedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignedLabel.Name = "AssignedLabel";
            this.AssignedLabel.Size = new System.Drawing.Size(79, 20);
            this.AssignedLabel.TabIndex = 10;
            this.AssignedLabel.Text = "Assigned:";
            // 
            // SelectRouteLabel
            // 
            this.SelectRouteLabel.AutoSize = true;
            this.SelectRouteLabel.Location = new System.Drawing.Point(4, 11);
            this.SelectRouteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectRouteLabel.Name = "SelectRouteLabel";
            this.SelectRouteLabel.Size = new System.Drawing.Size(106, 20);
            this.SelectRouteLabel.TabIndex = 9;
            this.SelectRouteLabel.Text = "Select Route:";
            // 
            // RouteComboBox
            // 
            this.RouteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteComboBox.FormattingEnabled = true;
            this.RouteComboBox.Location = new System.Drawing.Point(122, 8);
            this.RouteComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RouteComboBox.Name = "RouteComboBox";
            this.RouteComboBox.Size = new System.Drawing.Size(366, 28);
            this.RouteComboBox.TabIndex = 8;
            this.RouteComboBox.SelectedIndexChanged += new System.EventHandler(this.RouteComboBox_SelectedIndexChanged);
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.CurrentStateOutput);
            this.OrderTab.Controls.Add(this.StateLabel);
            this.OrderTab.Controls.Add(this.ParcelOutput);
            this.OrderTab.Controls.Add(this.ParcelLabel);
            this.OrderTab.Controls.Add(this.ReceiverOutput);
            this.OrderTab.Controls.Add(this.ReceiverLabel);
            this.OrderTab.Controls.Add(this.SenderOutput);
            this.OrderTab.Controls.Add(this.SenderLabel);
            this.OrderTab.Controls.Add(this.DestinationOutput);
            this.OrderTab.Controls.Add(this.DestinationLabel);
            this.OrderTab.Controls.Add(this.OriginOutput);
            this.OrderTab.Controls.Add(this.OriginLabel);
            this.OrderTab.Controls.Add(this.SelectOrderLabel);
            this.OrderTab.Controls.Add(this.OrderComboBox);
            this.OrderTab.Location = new System.Drawing.Point(4, 29);
            this.OrderTab.Margin = new System.Windows.Forms.Padding(2);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(2);
            this.OrderTab.Size = new System.Drawing.Size(498, 535);
            this.OrderTab.TabIndex = 3;
            this.OrderTab.Text = "Orders";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // CurrentStateOutput
            // 
            this.CurrentStateOutput.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentStateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentStateOutput.Location = new System.Drawing.Point(140, 217);
            this.CurrentStateOutput.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentStateOutput.Name = "CurrentStateOutput";
            this.CurrentStateOutput.Size = new System.Drawing.Size(344, 26);
            this.CurrentStateOutput.TabIndex = 23;
            this.CurrentStateOutput.TextChanged += new System.EventHandler(this.CurrentStateOutput_TextChanged);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(4, 219);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(109, 20);
            this.StateLabel.TabIndex = 22;
            this.StateLabel.Text = "Current State:";
            // 
            // ParcelLabel
            // 
            this.ParcelLabel.AutoSize = true;
            this.ParcelLabel.Location = new System.Drawing.Point(4, 185);
            this.ParcelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParcelLabel.Name = "ParcelLabel";
            this.ParcelLabel.Size = new System.Drawing.Size(57, 20);
            this.ParcelLabel.TabIndex = 20;
            this.ParcelLabel.Text = "Parcel:";
            // 
            // ReceiverOutput
            // 
            this.ReceiverOutput.Enabled = false;
            this.ReceiverOutput.Location = new System.Drawing.Point(140, 147);
            this.ReceiverOutput.Margin = new System.Windows.Forms.Padding(2);
            this.ReceiverOutput.Name = "ReceiverOutput";
            this.ReceiverOutput.Size = new System.Drawing.Size(344, 26);
            this.ReceiverOutput.TabIndex = 19;
            // 
            // ReceiverLabel
            // 
            this.ReceiverLabel.AutoSize = true;
            this.ReceiverLabel.Location = new System.Drawing.Point(4, 150);
            this.ReceiverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReceiverLabel.Name = "ReceiverLabel";
            this.ReceiverLabel.Size = new System.Drawing.Size(121, 20);
            this.ReceiverLabel.TabIndex = 18;
            this.ReceiverLabel.Text = "Receiver Name:";
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Location = new System.Drawing.Point(4, 115);
            this.SenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(111, 20);
            this.SenderLabel.TabIndex = 16;
            this.SenderLabel.Text = "Sender Name:";
            // 
            // DestinationOutput
            // 
            this.DestinationOutput.Enabled = false;
            this.DestinationOutput.Location = new System.Drawing.Point(140, 79);
            this.DestinationOutput.Margin = new System.Windows.Forms.Padding(2);
            this.DestinationOutput.Name = "DestinationOutput";
            this.DestinationOutput.Size = new System.Drawing.Size(344, 26);
            this.DestinationOutput.TabIndex = 15;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(4, 81);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(97, 20);
            this.DestinationLabel.TabIndex = 14;
            this.DestinationLabel.Text = "Shipping To:";
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(4, 47);
            this.OriginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(116, 20);
            this.OriginLabel.TabIndex = 12;
            this.OriginLabel.Text = "Shipping From:";
            // 
            // SelectOrderLabel
            // 
            this.SelectOrderLabel.AutoSize = true;
            this.SelectOrderLabel.Location = new System.Drawing.Point(4, 11);
            this.SelectOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectOrderLabel.Name = "SelectOrderLabel";
            this.SelectOrderLabel.Size = new System.Drawing.Size(102, 20);
            this.SelectOrderLabel.TabIndex = 9;
            this.SelectOrderLabel.Text = "Select Order:";
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.DisplayMember = "trackingNumber";
            this.OrderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Location = new System.Drawing.Point(140, 8);
            this.OrderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(344, 28);
            this.OrderComboBox.TabIndex = 8;
            this.OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderComboBox_SelectedIndexChanged);
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.tabControl1);
            this.ManageTab.Controls.Add(this.AddObjectBox);
            this.ManageTab.Controls.Add(this.AddObjectLabel);
            this.ManageTab.Location = new System.Drawing.Point(4, 29);
            this.ManageTab.Margin = new System.Windows.Forms.Padding(2);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.Padding = new System.Windows.Forms.Padding(2);
            this.ManageTab.Size = new System.Drawing.Size(498, 535);
            this.ManageTab.TabIndex = 4;
            this.ManageTab.Text = "Manage";
            this.ManageTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddParcelTab);
            this.tabControl1.Controls.Add(this.AddOrderTab);
            this.tabControl1.Controls.Add(this.AddRouteTab);
            this.tabControl1.Controls.Add(this.AddVehicleTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 486);
            this.tabControl1.TabIndex = 2;
            // 
            // AddParcelTab
            // 
            this.AddParcelTab.Controls.Add(this.addShippingObjectbutton);
            this.AddParcelTab.Controls.Add(this.selectPalletablebox);
            this.AddParcelTab.Controls.Add(this.palletableNameBox);
            this.AddParcelTab.Controls.Add(this.label11);
            this.AddParcelTab.Controls.Add(this.PalletableLabel);
            this.AddParcelTab.Controls.Add(this.addShippingObjectStatusBox);
            this.AddParcelTab.Controls.Add(this.soNameLabel);
            this.AddParcelTab.Controls.Add(this.soNameBox);
            this.AddParcelTab.Controls.Add(this.SObox);
            this.AddParcelTab.Controls.Add(this.loadableSObox);
            this.AddParcelTab.Controls.Add(this.builtinSObox);
            this.AddParcelTab.Controls.Add(this.label10);
            this.AddParcelTab.Location = new System.Drawing.Point(4, 29);
            this.AddParcelTab.Name = "AddParcelTab";
            this.AddParcelTab.Size = new System.Drawing.Size(495, 453);
            this.AddParcelTab.TabIndex = 3;
            this.AddParcelTab.Text = "New Parcel";
            this.AddParcelTab.UseVisualStyleBackColor = true;
            // 
            // addShippingObjectbutton
            // 
            this.addShippingObjectbutton.Location = new System.Drawing.Point(152, 341);
            this.addShippingObjectbutton.Name = "addShippingObjectbutton";
            this.addShippingObjectbutton.Size = new System.Drawing.Size(197, 43);
            this.addShippingObjectbutton.TabIndex = 12;
            this.addShippingObjectbutton.Text = "Add Shipping Object";
            this.addShippingObjectbutton.UseVisualStyleBackColor = true;
            this.addShippingObjectbutton.Click += new System.EventHandler(this.addShippingObjectbutton_Click);
            // 
            // selectPalletablebox
            // 
            this.selectPalletablebox.Enabled = false;
            this.selectPalletablebox.FormattingEnabled = true;
            this.selectPalletablebox.Location = new System.Drawing.Point(152, 213);
            this.selectPalletablebox.Name = "selectPalletablebox";
            this.selectPalletablebox.Size = new System.Drawing.Size(197, 28);
            this.selectPalletablebox.TabIndex = 11;
            // 
            // palletableNameBox
            // 
            this.palletableNameBox.Enabled = false;
            this.palletableNameBox.Location = new System.Drawing.Point(152, 277);
            this.palletableNameBox.Name = "palletableNameBox";
            this.palletableNameBox.Size = new System.Drawing.Size(197, 26);
            this.palletableNameBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Palletable Name:";
            // 
            // PalletableLabel
            // 
            this.PalletableLabel.AutoSize = true;
            this.PalletableLabel.Location = new System.Drawing.Point(10, 216);
            this.PalletableLabel.Name = "PalletableLabel";
            this.PalletableLabel.Size = new System.Drawing.Size(131, 20);
            this.PalletableLabel.TabIndex = 7;
            this.PalletableLabel.Text = "Select Palletable:";
            // 
            // addShippingObjectStatusBox
            // 
            this.addShippingObjectStatusBox.Enabled = false;
            this.addShippingObjectStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addShippingObjectStatusBox.Location = new System.Drawing.Point(3, 424);
            this.addShippingObjectStatusBox.Name = "addShippingObjectStatusBox";
            this.addShippingObjectStatusBox.Size = new System.Drawing.Size(489, 23);
            this.addShippingObjectStatusBox.TabIndex = 6;
            // 
            // soNameLabel
            // 
            this.soNameLabel.AutoSize = true;
            this.soNameLabel.Location = new System.Drawing.Point(77, 152);
            this.soNameLabel.Name = "soNameLabel";
            this.soNameLabel.Size = new System.Drawing.Size(55, 20);
            this.soNameLabel.TabIndex = 5;
            this.soNameLabel.Text = "Name:";
            // 
            // soNameBox
            // 
            this.soNameBox.Location = new System.Drawing.Point(152, 146);
            this.soNameBox.Name = "soNameBox";
            this.soNameBox.Size = new System.Drawing.Size(197, 26);
            this.soNameBox.TabIndex = 4;
            // 
            // SObox
            // 
            this.SObox.FormattingEnabled = true;
            this.SObox.Location = new System.Drawing.Point(152, 75);
            this.SObox.Name = "SObox";
            this.SObox.Size = new System.Drawing.Size(197, 28);
            this.SObox.TabIndex = 3;
            this.SObox.SelectedIndexChanged += new System.EventHandler(this.SObox_SelectedIndexChanged);
            // 
            // loadableSObox
            // 
            this.loadableSObox.AutoSize = true;
            this.loadableSObox.Location = new System.Drawing.Point(244, 45);
            this.loadableSObox.Name = "loadableSObox";
            this.loadableSObox.Size = new System.Drawing.Size(94, 24);
            this.loadableSObox.TabIndex = 2;
            this.loadableSObox.Text = "Loadable";
            this.loadableSObox.UseVisualStyleBackColor = true;
            this.loadableSObox.CheckedChanged += new System.EventHandler(this.loadableSObox_CheckedChanged);
            // 
            // builtinSObox
            // 
            this.builtinSObox.AutoSize = true;
            this.builtinSObox.Location = new System.Drawing.Point(162, 45);
            this.builtinSObox.Name = "builtinSObox";
            this.builtinSObox.Size = new System.Drawing.Size(76, 24);
            this.builtinSObox.TabIndex = 1;
            this.builtinSObox.Text = "Built-in";
            this.builtinSObox.UseVisualStyleBackColor = true;
            this.builtinSObox.CheckedChanged += new System.EventHandler(this.builtinSObox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Select Type:";
            // 
            // AddOrderTab
            // 
            this.AddOrderTab.Location = new System.Drawing.Point(4, 29);
            this.AddOrderTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddOrderTab.Name = "AddOrderTab";
            this.AddOrderTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddOrderTab.Size = new System.Drawing.Size(495, 453);
            this.AddOrderTab.TabIndex = 1;
            this.AddOrderTab.Text = "New Order";
            this.AddOrderTab.UseVisualStyleBackColor = true;
            // 
            // AddRouteTab
            // 
            this.AddRouteTab.Location = new System.Drawing.Point(4, 29);
            this.AddRouteTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddRouteTab.Name = "AddRouteTab";
            this.AddRouteTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddRouteTab.Size = new System.Drawing.Size(495, 453);
            this.AddRouteTab.TabIndex = 2;
            this.AddRouteTab.Text = "New Route";
            this.AddRouteTab.UseVisualStyleBackColor = true;
            // 
            // AddVehicleTab
            // 
            this.AddVehicleTab.Controls.Add(this.IdentifierBox);
            this.AddVehicleTab.Controls.Add(this.loadCountBox);
            this.AddVehicleTab.Controls.Add(this.mpgBox);
            this.AddVehicleTab.Controls.Add(this.attributeBox);
            this.AddVehicleTab.Controls.Add(this.confirmAddVehicleButton);
            this.AddVehicleTab.Controls.Add(this.VehicleAddStatusBox);
            this.AddVehicleTab.Controls.Add(this.AttributeLabel);
            this.AddVehicleTab.Controls.Add(this.label9);
            this.AddVehicleTab.Controls.Add(this.label8);
            this.AddVehicleTab.Controls.Add(this.label7);
            this.AddVehicleTab.Controls.Add(this.AvailableVehicleTypesBox);
            this.AddVehicleTab.Controls.Add(this.label6);
            this.AddVehicleTab.Controls.Add(this.LoadableBox);
            this.AddVehicleTab.Controls.Add(this.BuiltInBox);
            this.AddVehicleTab.Controls.Add(this.label4);
            this.AddVehicleTab.Location = new System.Drawing.Point(4, 29);
            this.AddVehicleTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddVehicleTab.Name = "AddVehicleTab";
            this.AddVehicleTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddVehicleTab.Size = new System.Drawing.Size(495, 453);
            this.AddVehicleTab.TabIndex = 0;
            this.AddVehicleTab.Text = "New Vehicle";
            this.AddVehicleTab.UseVisualStyleBackColor = true;
            // 
            // IdentifierBox
            // 
            this.IdentifierBox.Location = new System.Drawing.Point(196, 110);
            this.IdentifierBox.Name = "IdentifierBox";
            this.IdentifierBox.Size = new System.Drawing.Size(160, 26);
            this.IdentifierBox.TabIndex = 14;
            // 
            // loadCountBox
            // 
            this.loadCountBox.Location = new System.Drawing.Point(196, 172);
            this.loadCountBox.Name = "loadCountBox";
            this.loadCountBox.Size = new System.Drawing.Size(160, 26);
            this.loadCountBox.TabIndex = 13;
            // 
            // mpgBox
            // 
            this.mpgBox.Location = new System.Drawing.Point(196, 235);
            this.mpgBox.Name = "mpgBox";
            this.mpgBox.Size = new System.Drawing.Size(160, 26);
            this.mpgBox.TabIndex = 12;
            // 
            // attributeBox
            // 
            this.attributeBox.Location = new System.Drawing.Point(196, 300);
            this.attributeBox.Name = "attributeBox";
            this.attributeBox.Size = new System.Drawing.Size(160, 26);
            this.attributeBox.TabIndex = 11;
            // 
            // confirmAddVehicleButton
            // 
            this.confirmAddVehicleButton.Location = new System.Drawing.Point(165, 354);
            this.confirmAddVehicleButton.Name = "confirmAddVehicleButton";
            this.confirmAddVehicleButton.Size = new System.Drawing.Size(154, 45);
            this.confirmAddVehicleButton.TabIndex = 10;
            this.confirmAddVehicleButton.Text = "Add Vehicle";
            this.confirmAddVehicleButton.UseVisualStyleBackColor = true;
            this.confirmAddVehicleButton.Click += new System.EventHandler(this.confirmAddVehicleButton_Click);
            // 
            // VehicleAddStatusBox
            // 
            this.VehicleAddStatusBox.Enabled = false;
            this.VehicleAddStatusBox.Location = new System.Drawing.Point(2, 427);
            this.VehicleAddStatusBox.Name = "VehicleAddStatusBox";
            this.VehicleAddStatusBox.Size = new System.Drawing.Size(493, 26);
            this.VehicleAddStatusBox.TabIndex = 9;
            // 
            // AttributeLabel
            // 
            this.AttributeLabel.AutoSize = true;
            this.AttributeLabel.Location = new System.Drawing.Point(116, 300);
            this.AttributeLabel.Name = "AttributeLabel";
            this.AttributeLabel.Size = new System.Drawing.Size(74, 20);
            this.AttributeLabel.TabIndex = 8;
            this.AttributeLabel.Text = "Attribute:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "MPG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Load Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Identifier:";
            // 
            // AvailableVehicleTypesBox
            // 
            this.AvailableVehicleTypesBox.FormattingEnabled = true;
            this.AvailableVehicleTypesBox.Location = new System.Drawing.Point(155, 45);
            this.AvailableVehicleTypesBox.Margin = new System.Windows.Forms.Padding(2);
            this.AvailableVehicleTypesBox.Name = "AvailableVehicleTypesBox";
            this.AvailableVehicleTypesBox.Size = new System.Drawing.Size(211, 28);
            this.AvailableVehicleTypesBox.TabIndex = 4;
            this.AvailableVehicleTypesBox.SelectedIndexChanged += new System.EventHandler(this.AvailableVehicleTypesBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select Type:";
            // 
            // LoadableBox
            // 
            this.LoadableBox.AutoSize = true;
            this.LoadableBox.Location = new System.Drawing.Point(262, 17);
            this.LoadableBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoadableBox.Name = "LoadableBox";
            this.LoadableBox.Size = new System.Drawing.Size(94, 24);
            this.LoadableBox.TabIndex = 2;
            this.LoadableBox.Text = "Loadable";
            this.LoadableBox.UseVisualStyleBackColor = true;
            this.LoadableBox.CheckedChanged += new System.EventHandler(this.LoadableBox_CheckedChanged);
            // 
            // BuiltInBox
            // 
            this.BuiltInBox.AutoSize = true;
            this.BuiltInBox.Location = new System.Drawing.Point(165, 17);
            this.BuiltInBox.Margin = new System.Windows.Forms.Padding(2);
            this.BuiltInBox.Name = "BuiltInBox";
            this.BuiltInBox.Size = new System.Drawing.Size(76, 24);
            this.BuiltInBox.TabIndex = 1;
            this.BuiltInBox.Text = "Built-in";
            this.BuiltInBox.UseVisualStyleBackColor = true;
            this.BuiltInBox.CheckedChanged += new System.EventHandler(this.BuiltInBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            // 
            // AddObjectBox
            // 
            this.AddObjectBox.FormattingEnabled = true;
            this.AddObjectBox.Location = new System.Drawing.Point(226, 13);
            this.AddObjectBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddObjectBox.Name = "AddObjectBox";
            this.AddObjectBox.Size = new System.Drawing.Size(177, 28);
            this.AddObjectBox.TabIndex = 1;
            // 
            // AddObjectLabel
            // 
            this.AddObjectLabel.AutoSize = true;
            this.AddObjectLabel.Location = new System.Drawing.Point(130, 16);
            this.AddObjectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddObjectLabel.Name = "AddObjectLabel";
            this.AddObjectLabel.Size = new System.Drawing.Size(92, 20);
            this.AddObjectLabel.TabIndex = 0;
            this.AddObjectLabel.Text = "Add Object:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 571);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            this.TabSelector.ResumeLayout(false);
            this.CompanyTab.ResumeLayout(false);
            this.CompanyTab.PerformLayout();
            this.VehicleTab.ResumeLayout(false);
            this.VehicleTab.PerformLayout();
            this.RouteTab.ResumeLayout(false);
            this.RouteTab.PerformLayout();
            this.OrderTab.ResumeLayout(false);
            this.OrderTab.PerformLayout();
            this.ManageTab.ResumeLayout(false);
            this.ManageTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AddParcelTab.ResumeLayout(false);
            this.AddParcelTab.PerformLayout();
            this.AddVehicleTab.ResumeLayout(false);
            this.AddVehicleTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TabControl TabSelector;
        private System.Windows.Forms.TabPage CompanyTab;
        private System.Windows.Forms.TabPage VehicleTab;
        private System.Windows.Forms.TabPage RouteTab;
        private System.Windows.Forms.TabPage OrderTab;
        private System.Windows.Forms.Label SelectVehicleLabel;
        private System.Windows.Forms.ComboBox VehicleComboBox;
        private System.Windows.Forms.ListBox TodoList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MpgOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoadCountOutput;
        private System.Windows.Forms.Label LoadCountLabel;
        private System.Windows.Forms.TextBox CompanyNameOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CompanyVehicles;
        private System.Windows.Forms.Label CompanyVehiclesOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AssignedOutput;
        private System.Windows.Forms.Label AssignedLabel;
        private System.Windows.Forms.Label SelectRouteLabel;
        private System.Windows.Forms.ComboBox RouteComboBox;
        private System.Windows.Forms.ListBox RouteOrderList;
        private System.Windows.Forms.TextBox DestinationOutput;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.Label SelectOrderLabel;
        private System.Windows.Forms.ComboBox OrderComboBox;
        private System.Windows.Forms.TextBox ReceiverOutput;
        private System.Windows.Forms.Label ReceiverLabel;
        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.TextBox CurrentStateOutput;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ParcelLabel;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.TextBox OriginOutput;
        private System.Windows.Forms.TextBox SenderOutput;
        private System.Windows.Forms.TextBox ParcelOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.TextBox attributesbox;
        private System.Windows.Forms.TabPage ManageTab;
        private System.Windows.Forms.ComboBox AddObjectBox;
        private System.Windows.Forms.Label AddObjectLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddVehicleTab;
        private System.Windows.Forms.TabPage AddOrderTab;
        private System.Windows.Forms.TabPage AddRouteTab;
        private System.Windows.Forms.ComboBox AvailableVehicleTypesBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox LoadableBox;
        private System.Windows.Forms.CheckBox BuiltInBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdentifierBox;
        private System.Windows.Forms.TextBox loadCountBox;
        private System.Windows.Forms.TextBox mpgBox;
        private System.Windows.Forms.TextBox attributeBox;
        private System.Windows.Forms.Button confirmAddVehicleButton;
        private System.Windows.Forms.TextBox VehicleAddStatusBox;
        private System.Windows.Forms.Label AttributeLabel;
        private System.Windows.Forms.TabPage AddParcelTab;
        private System.Windows.Forms.ComboBox SObox;
        private System.Windows.Forms.CheckBox loadableSObox;
        private System.Windows.Forms.CheckBox builtinSObox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PalletableLabel;
        private System.Windows.Forms.TextBox addShippingObjectStatusBox;
        private System.Windows.Forms.Label soNameLabel;
        private System.Windows.Forms.TextBox soNameBox;
        private System.Windows.Forms.TextBox palletableNameBox;
        private System.Windows.Forms.Button addShippingObjectbutton;
        private System.Windows.Forms.ComboBox selectPalletablebox;
    }
}

