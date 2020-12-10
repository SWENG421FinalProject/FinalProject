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
            this.AddObjectBox = new System.Windows.Forms.ComboBox();
            this.AddObjectLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddVehicleTab = new System.Windows.Forms.TabPage();
            this.AddOrderTab = new System.Windows.Forms.TabPage();
            this.AddRouteTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.BuiltInBox = new System.Windows.Forms.CheckBox();
            this.LoadableBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvailableVehicleTypesBox = new System.Windows.Forms.ComboBox();
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
            this.AddVehicleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginOutput
            // 
            this.OriginOutput.Enabled = false;
            this.OriginOutput.Location = new System.Drawing.Point(187, 55);
            this.OriginOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OriginOutput.Name = "OriginOutput";
            this.OriginOutput.Size = new System.Drawing.Size(457, 30);
            this.OriginOutput.TabIndex = 13;
            // 
            // SenderOutput
            // 
            this.SenderOutput.Enabled = false;
            this.SenderOutput.Location = new System.Drawing.Point(187, 139);
            this.SenderOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SenderOutput.Name = "SenderOutput";
            this.SenderOutput.Size = new System.Drawing.Size(457, 30);
            this.SenderOutput.TabIndex = 17;
            // 
            // ParcelOutput
            // 
            this.ParcelOutput.Enabled = false;
            this.ParcelOutput.Location = new System.Drawing.Point(187, 225);
            this.ParcelOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParcelOutput.Name = "ParcelOutput";
            this.ParcelOutput.Size = new System.Drawing.Size(457, 30);
            this.ParcelOutput.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(1357, 703);
            this.splitContainer1.SplitterDistance = 675;
            this.splitContainer1.TabIndex = 0;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(117, 1);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(252, 46);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Text = "Output Panel";
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoSize = true;
            this.OutputPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OutputPanel.Controls.Add(this.OutputTextBox);
            this.OutputPanel.Location = new System.Drawing.Point(0, 50);
            this.OutputPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(676, 651);
            this.OutputPanel.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputTextBox.HideSelection = false;
            this.OutputTextBox.Location = new System.Drawing.Point(-1, 0);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(673, 648);
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
            this.TabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.SelectedIndex = 0;
            this.TabSelector.Size = new System.Drawing.Size(675, 699);
            this.TabSelector.TabIndex = 0;
            // 
            // CompanyTab
            // 
            this.CompanyTab.Controls.Add(this.CompanyVehicles);
            this.CompanyTab.Controls.Add(this.CompanyVehiclesOutput);
            this.CompanyTab.Controls.Add(this.CompanyNameOutput);
            this.CompanyTab.Controls.Add(this.label3);
            this.CompanyTab.Location = new System.Drawing.Point(4, 34);
            this.CompanyTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyTab.Name = "CompanyTab";
            this.CompanyTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyTab.Size = new System.Drawing.Size(667, 661);
            this.CompanyTab.TabIndex = 0;
            this.CompanyTab.Text = "Company";
            this.CompanyTab.UseVisualStyleBackColor = true;
            // 
            // CompanyVehicles
            // 
            this.CompanyVehicles.DisplayMember = "identifier";
            this.CompanyVehicles.FormattingEnabled = true;
            this.CompanyVehicles.ItemHeight = 25;
            this.CompanyVehicles.Location = new System.Drawing.Point(195, 52);
            this.CompanyVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyVehicles.Name = "CompanyVehicles";
            this.CompanyVehicles.Size = new System.Drawing.Size(440, 554);
            this.CompanyVehicles.TabIndex = 6;
            // 
            // CompanyVehiclesOutput
            // 
            this.CompanyVehiclesOutput.AutoSize = true;
            this.CompanyVehiclesOutput.Location = new System.Drawing.Point(5, 52);
            this.CompanyVehiclesOutput.Name = "CompanyVehiclesOutput";
            this.CompanyVehiclesOutput.Size = new System.Drawing.Size(183, 25);
            this.CompanyVehiclesOutput.TabIndex = 5;
            this.CompanyVehiclesOutput.Text = "Company Vehicles:";
            this.CompanyVehiclesOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompanyNameOutput
            // 
            this.CompanyNameOutput.Enabled = false;
            this.CompanyNameOutput.Location = new System.Drawing.Point(195, 10);
            this.CompanyNameOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyNameOutput.Name = "CompanyNameOutput";
            this.CompanyNameOutput.Size = new System.Drawing.Size(441, 30);
            this.CompanyNameOutput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
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
            this.VehicleTab.Location = new System.Drawing.Point(4, 34);
            this.VehicleTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleTab.Name = "VehicleTab";
            this.VehicleTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleTab.Size = new System.Drawing.Size(667, 661);
            this.VehicleTab.TabIndex = 1;
            this.VehicleTab.Text = "Vehicles";
            this.VehicleTab.UseVisualStyleBackColor = true;
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Location = new System.Drawing.Point(0, 150);
            this.otherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(154, 25);
            this.otherLabel.TabIndex = 11;
            this.otherLabel.Text = "Other Attributes:";
            // 
            // attributesbox
            // 
            this.attributesbox.Enabled = false;
            this.attributesbox.Location = new System.Drawing.Point(173, 146);
            this.attributesbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attributesbox.Name = "attributesbox";
            this.attributesbox.Size = new System.Drawing.Size(473, 30);
            this.attributesbox.TabIndex = 10;
            // 
            // TodoList
            // 
            this.TodoList.FormattingEnabled = true;
            this.TodoList.ItemHeight = 25;
            this.TodoList.Location = new System.Drawing.Point(173, 201);
            this.TodoList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TodoList.Name = "TodoList";
            this.TodoList.Size = new System.Drawing.Size(473, 404);
            this.TodoList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Todo:";
            // 
            // MpgOutput
            // 
            this.MpgOutput.Enabled = false;
            this.MpgOutput.Location = new System.Drawing.Point(173, 98);
            this.MpgOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MpgOutput.Name = "MpgOutput";
            this.MpgOutput.Size = new System.Drawing.Size(473, 30);
            this.MpgOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mpg:";
            // 
            // LoadCountOutput
            // 
            this.LoadCountOutput.Enabled = false;
            this.LoadCountOutput.Location = new System.Drawing.Point(173, 57);
            this.LoadCountOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadCountOutput.Name = "LoadCountOutput";
            this.LoadCountOutput.Size = new System.Drawing.Size(473, 30);
            this.LoadCountOutput.TabIndex = 5;
            // 
            // LoadCountLabel
            // 
            this.LoadCountLabel.AutoSize = true;
            this.LoadCountLabel.Location = new System.Drawing.Point(5, 60);
            this.LoadCountLabel.Name = "LoadCountLabel";
            this.LoadCountLabel.Size = new System.Drawing.Size(120, 25);
            this.LoadCountLabel.TabIndex = 4;
            this.LoadCountLabel.Text = "Load Count:";
            // 
            // SelectVehicleLabel
            // 
            this.SelectVehicleLabel.AutoSize = true;
            this.SelectVehicleLabel.Location = new System.Drawing.Point(5, 14);
            this.SelectVehicleLabel.Name = "SelectVehicleLabel";
            this.SelectVehicleLabel.Size = new System.Drawing.Size(143, 25);
            this.SelectVehicleLabel.TabIndex = 1;
            this.SelectVehicleLabel.Text = "Select Vehicle:";
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.DisplayMember = "identifier";
            this.VehicleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(173, 10);
            this.VehicleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(473, 33);
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
            this.RouteTab.Location = new System.Drawing.Point(4, 34);
            this.RouteTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteTab.Name = "RouteTab";
            this.RouteTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteTab.Size = new System.Drawing.Size(667, 661);
            this.RouteTab.TabIndex = 2;
            this.RouteTab.Text = "Routes";
            this.RouteTab.UseVisualStyleBackColor = true;
            // 
            // RouteOrderList
            // 
            this.RouteOrderList.DisplayMember = "trackingNumber";
            this.RouteOrderList.FormattingEnabled = true;
            this.RouteOrderList.ItemHeight = 25;
            this.RouteOrderList.Location = new System.Drawing.Point(163, 108);
            this.RouteOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteOrderList.Name = "RouteOrderList";
            this.RouteOrderList.Size = new System.Drawing.Size(487, 504);
            this.RouteOrderList.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Orders:";
            // 
            // AssignedOutput
            // 
            this.AssignedOutput.Enabled = false;
            this.AssignedOutput.Location = new System.Drawing.Point(163, 63);
            this.AssignedOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignedOutput.Name = "AssignedOutput";
            this.AssignedOutput.Size = new System.Drawing.Size(487, 30);
            this.AssignedOutput.TabIndex = 11;
            // 
            // AssignedLabel
            // 
            this.AssignedLabel.AutoSize = true;
            this.AssignedLabel.Location = new System.Drawing.Point(5, 66);
            this.AssignedLabel.Name = "AssignedLabel";
            this.AssignedLabel.Size = new System.Drawing.Size(100, 25);
            this.AssignedLabel.TabIndex = 10;
            this.AssignedLabel.Text = "Assigned:";
            // 
            // SelectRouteLabel
            // 
            this.SelectRouteLabel.AutoSize = true;
            this.SelectRouteLabel.Location = new System.Drawing.Point(5, 14);
            this.SelectRouteLabel.Name = "SelectRouteLabel";
            this.SelectRouteLabel.Size = new System.Drawing.Size(129, 25);
            this.SelectRouteLabel.TabIndex = 9;
            this.SelectRouteLabel.Text = "Select Route:";
            // 
            // RouteComboBox
            // 
            this.RouteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteComboBox.FormattingEnabled = true;
            this.RouteComboBox.Location = new System.Drawing.Point(163, 10);
            this.RouteComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RouteComboBox.Name = "RouteComboBox";
            this.RouteComboBox.Size = new System.Drawing.Size(487, 33);
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
            this.OrderTab.Location = new System.Drawing.Point(4, 34);
            this.OrderTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderTab.Size = new System.Drawing.Size(667, 661);
            this.OrderTab.TabIndex = 3;
            this.OrderTab.Text = "Orders";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // CurrentStateOutput
            // 
            this.CurrentStateOutput.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentStateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentStateOutput.Location = new System.Drawing.Point(187, 267);
            this.CurrentStateOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrentStateOutput.Name = "CurrentStateOutput";
            this.CurrentStateOutput.Size = new System.Drawing.Size(458, 30);
            this.CurrentStateOutput.TabIndex = 23;
            this.CurrentStateOutput.TextChanged += new System.EventHandler(this.CurrentStateOutput_TextChanged);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(5, 270);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(134, 25);
            this.StateLabel.TabIndex = 22;
            this.StateLabel.Text = "Current State:";
            // 
            // ParcelLabel
            // 
            this.ParcelLabel.AutoSize = true;
            this.ParcelLabel.Location = new System.Drawing.Point(5, 228);
            this.ParcelLabel.Name = "ParcelLabel";
            this.ParcelLabel.Size = new System.Drawing.Size(73, 25);
            this.ParcelLabel.TabIndex = 20;
            this.ParcelLabel.Text = "Parcel:";
            // 
            // ReceiverOutput
            // 
            this.ReceiverOutput.Enabled = false;
            this.ReceiverOutput.Location = new System.Drawing.Point(187, 181);
            this.ReceiverOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReceiverOutput.Name = "ReceiverOutput";
            this.ReceiverOutput.Size = new System.Drawing.Size(457, 30);
            this.ReceiverOutput.TabIndex = 19;
            // 
            // ReceiverLabel
            // 
            this.ReceiverLabel.AutoSize = true;
            this.ReceiverLabel.Location = new System.Drawing.Point(5, 185);
            this.ReceiverLabel.Name = "ReceiverLabel";
            this.ReceiverLabel.Size = new System.Drawing.Size(151, 25);
            this.ReceiverLabel.TabIndex = 18;
            this.ReceiverLabel.Text = "Receiver Name:";
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Location = new System.Drawing.Point(5, 142);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(139, 25);
            this.SenderLabel.TabIndex = 16;
            this.SenderLabel.Text = "Sender Name:";
            // 
            // DestinationOutput
            // 
            this.DestinationOutput.Enabled = false;
            this.DestinationOutput.Location = new System.Drawing.Point(187, 97);
            this.DestinationOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DestinationOutput.Name = "DestinationOutput";
            this.DestinationOutput.Size = new System.Drawing.Size(457, 30);
            this.DestinationOutput.TabIndex = 15;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(5, 100);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(124, 25);
            this.DestinationLabel.TabIndex = 14;
            this.DestinationLabel.Text = "Shipping To:";
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(5, 58);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(145, 25);
            this.OriginLabel.TabIndex = 12;
            this.OriginLabel.Text = "Shipping From:";
            // 
            // SelectOrderLabel
            // 
            this.SelectOrderLabel.AutoSize = true;
            this.SelectOrderLabel.Location = new System.Drawing.Point(5, 14);
            this.SelectOrderLabel.Name = "SelectOrderLabel";
            this.SelectOrderLabel.Size = new System.Drawing.Size(128, 25);
            this.SelectOrderLabel.TabIndex = 9;
            this.SelectOrderLabel.Text = "Select Order:";
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.DisplayMember = "trackingNumber";
            this.OrderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Location = new System.Drawing.Point(187, 10);
            this.OrderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(457, 33);
            this.OrderComboBox.TabIndex = 8;
            this.OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderComboBox_SelectedIndexChanged);
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.tabControl1);
            this.ManageTab.Controls.Add(this.AddObjectBox);
            this.ManageTab.Controls.Add(this.AddObjectLabel);
            this.ManageTab.Location = new System.Drawing.Point(4, 29);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManageTab.Size = new System.Drawing.Size(498, 535);
            this.ManageTab.TabIndex = 4;
            this.ManageTab.Text = "Manage";
            this.ManageTab.UseVisualStyleBackColor = true;
            // 
            // AddObjectBox
            // 
            this.AddObjectBox.FormattingEnabled = true;
            this.AddObjectBox.Location = new System.Drawing.Point(210, 18);
            this.AddObjectBox.Name = "AddObjectBox";
            this.AddObjectBox.Size = new System.Drawing.Size(183, 28);
            this.AddObjectBox.TabIndex = 1;
            // 
            // AddObjectLabel
            // 
            this.AddObjectLabel.AutoSize = true;
            this.AddObjectLabel.Location = new System.Drawing.Point(111, 20);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddVehicleTab);
            this.tabControl1.Controls.Add(this.AddOrderTab);
            this.tabControl1.Controls.Add(this.AddRouteTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 474);
            this.tabControl1.TabIndex = 2;
            // 
            // AddVehicleTab
            // 
            this.AddVehicleTab.Controls.Add(this.AvailableVehicleTypesBox);
            this.AddVehicleTab.Controls.Add(this.label6);
            this.AddVehicleTab.Controls.Add(this.LoadableBox);
            this.AddVehicleTab.Controls.Add(this.BuiltInBox);
            this.AddVehicleTab.Controls.Add(this.label4);
            this.AddVehicleTab.Location = new System.Drawing.Point(4, 29);
            this.AddVehicleTab.Name = "AddVehicleTab";
            this.AddVehicleTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddVehicleTab.Size = new System.Drawing.Size(495, 441);
            this.AddVehicleTab.TabIndex = 0;
            this.AddVehicleTab.Text = "New Vehicle";
            this.AddVehicleTab.UseVisualStyleBackColor = true;
            // 
            // AddOrderTab
            // 
            this.AddOrderTab.Location = new System.Drawing.Point(4, 29);
            this.AddOrderTab.Name = "AddOrderTab";
            this.AddOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddOrderTab.Size = new System.Drawing.Size(495, 441);
            this.AddOrderTab.TabIndex = 1;
            this.AddOrderTab.Text = "New Order";
            this.AddOrderTab.UseVisualStyleBackColor = true;
            // 
            // AddRouteTab
            // 
            this.AddRouteTab.Location = new System.Drawing.Point(4, 29);
            this.AddRouteTab.Name = "AddRouteTab";
            this.AddRouteTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddRouteTab.Size = new System.Drawing.Size(495, 441);
            this.AddRouteTab.TabIndex = 2;
            this.AddRouteTab.Text = "New Route";
            this.AddRouteTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            // 
            // BuiltInBox
            // 
            this.BuiltInBox.AutoSize = true;
            this.BuiltInBox.Location = new System.Drawing.Point(124, 26);
            this.BuiltInBox.Name = "BuiltInBox";
            this.BuiltInBox.Size = new System.Drawing.Size(76, 24);
            this.BuiltInBox.TabIndex = 1;
            this.BuiltInBox.Text = "Built-in";
            this.BuiltInBox.UseVisualStyleBackColor = true;
            this.BuiltInBox.CheckedChanged += new System.EventHandler(this.BuiltInBox_CheckedChanged);
            // 
            // LoadableBox
            // 
            this.LoadableBox.AutoSize = true;
            this.LoadableBox.Location = new System.Drawing.Point(207, 26);
            this.LoadableBox.Name = "LoadableBox";
            this.LoadableBox.Size = new System.Drawing.Size(94, 24);
            this.LoadableBox.TabIndex = 2;
            this.LoadableBox.Text = "Loadable";
            this.LoadableBox.UseVisualStyleBackColor = true;
            this.LoadableBox.CheckedChanged += new System.EventHandler(this.LoadableBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select Type:";
            // 
            // AvailableVehicleTypesBox
            // 
            this.AvailableVehicleTypesBox.FormattingEnabled = true;
            this.AvailableVehicleTypesBox.Location = new System.Drawing.Point(307, 27);
            this.AvailableVehicleTypesBox.Name = "AvailableVehicleTypesBox";
            this.AvailableVehicleTypesBox.Size = new System.Drawing.Size(170, 28);
            this.AvailableVehicleTypesBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 703);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

