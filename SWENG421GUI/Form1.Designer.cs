﻿namespace SWENG421GUI
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
            this.splitContainer1.SplitterDistance = 507;
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
            this.OutputTextBox.Enabled = false;
            this.OutputTextBox.Location = new System.Drawing.Point(-1, 0);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputTextBox.Name = "OutputTextBox";
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
            this.CompanyVehicles.Size = new System.Drawing.Size(331, 464);
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
            this.TodoList.Size = new System.Drawing.Size(356, 344);
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
            this.RouteOrderList.Size = new System.Drawing.Size(366, 424);
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
    }
}
