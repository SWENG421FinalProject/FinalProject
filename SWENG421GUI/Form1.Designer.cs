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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.TabSelector = new System.Windows.Forms.TabControl();
            this.CompanyTab = new System.Windows.Forms.TabPage();
            this.VehicleTab = new System.Windows.Forms.TabPage();
            this.RouteTab = new System.Windows.Forms.TabPage();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.VehicleComboBox = new System.Windows.Forms.ComboBox();
            this.SelectVehicleLabel = new System.Windows.Forms.Label();
            this.VehicleIdentifierLabel = new System.Windows.Forms.Label();
            this.VehicleIdentifierOutput = new System.Windows.Forms.TextBox();
            this.LoadCountLabel = new System.Windows.Forms.Label();
            this.LoadCountOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MpgOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TodoList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanyNameOutput = new System.Windows.Forms.TextBox();
            this.CompanyVehiclesOutput = new System.Windows.Forms.Label();
            this.CompanyVehicles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabSelector.SuspendLayout();
            this.CompanyTab.SuspendLayout();
            this.VehicleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(932, 513);
            this.splitContainer1.SplitterDistance = 475;
            this.splitContainer1.TabIndex = 0;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(118, 1);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(252, 46);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Text = "Output Panel";
            // 
            // OutputPanel
            // 
            this.OutputPanel.AutoSize = true;
            this.OutputPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OutputPanel.Location = new System.Drawing.Point(0, 50);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(472, 463);
            this.OutputPanel.TabIndex = 0;
            // 
            // TabSelector
            // 
            this.TabSelector.Controls.Add(this.CompanyTab);
            this.TabSelector.Controls.Add(this.VehicleTab);
            this.TabSelector.Controls.Add(this.RouteTab);
            this.TabSelector.Controls.Add(this.OrderTab);
            this.TabSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSelector.Location = new System.Drawing.Point(-1, 3);
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.SelectedIndex = 0;
            this.TabSelector.Size = new System.Drawing.Size(453, 510);
            this.TabSelector.TabIndex = 0;
            // 
            // CompanyTab
            // 
            this.CompanyTab.Controls.Add(this.CompanyVehicles);
            this.CompanyTab.Controls.Add(this.CompanyVehiclesOutput);
            this.CompanyTab.Controls.Add(this.CompanyNameOutput);
            this.CompanyTab.Controls.Add(this.label3);
            this.CompanyTab.Location = new System.Drawing.Point(4, 34);
            this.CompanyTab.Name = "CompanyTab";
            this.CompanyTab.Padding = new System.Windows.Forms.Padding(3);
            this.CompanyTab.Size = new System.Drawing.Size(445, 472);
            this.CompanyTab.TabIndex = 0;
            this.CompanyTab.Text = "Company";
            this.CompanyTab.UseVisualStyleBackColor = true;
            // 
            // VehicleTab
            // 
            this.VehicleTab.Controls.Add(this.TodoList);
            this.VehicleTab.Controls.Add(this.label2);
            this.VehicleTab.Controls.Add(this.MpgOutput);
            this.VehicleTab.Controls.Add(this.label1);
            this.VehicleTab.Controls.Add(this.LoadCountOutput);
            this.VehicleTab.Controls.Add(this.LoadCountLabel);
            this.VehicleTab.Controls.Add(this.VehicleIdentifierOutput);
            this.VehicleTab.Controls.Add(this.VehicleIdentifierLabel);
            this.VehicleTab.Controls.Add(this.SelectVehicleLabel);
            this.VehicleTab.Controls.Add(this.VehicleComboBox);
            this.VehicleTab.Location = new System.Drawing.Point(4, 34);
            this.VehicleTab.Name = "VehicleTab";
            this.VehicleTab.Padding = new System.Windows.Forms.Padding(3);
            this.VehicleTab.Size = new System.Drawing.Size(445, 472);
            this.VehicleTab.TabIndex = 1;
            this.VehicleTab.Text = "Vehicles";
            this.VehicleTab.UseVisualStyleBackColor = true;
            // 
            // RouteTab
            // 
            this.RouteTab.Location = new System.Drawing.Point(4, 34);
            this.RouteTab.Name = "RouteTab";
            this.RouteTab.Padding = new System.Windows.Forms.Padding(3);
            this.RouteTab.Size = new System.Drawing.Size(445, 472);
            this.RouteTab.TabIndex = 2;
            this.RouteTab.Text = "Routes";
            this.RouteTab.UseVisualStyleBackColor = true;
            // 
            // OrderTab
            // 
            this.OrderTab.Location = new System.Drawing.Point(4, 34);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(445, 472);
            this.OrderTab.TabIndex = 3;
            this.OrderTab.Text = "Orders";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(173, 10);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(230, 33);
            this.VehicleComboBox.TabIndex = 0;
            // 
            // SelectVehicleLabel
            // 
            this.SelectVehicleLabel.AutoSize = true;
            this.SelectVehicleLabel.Location = new System.Drawing.Point(6, 13);
            this.SelectVehicleLabel.Name = "SelectVehicleLabel";
            this.SelectVehicleLabel.Size = new System.Drawing.Size(143, 25);
            this.SelectVehicleLabel.TabIndex = 1;
            this.SelectVehicleLabel.Text = "Select Vehicle:";
            // 
            // VehicleIdentifierLabel
            // 
            this.VehicleIdentifierLabel.AutoSize = true;
            this.VehicleIdentifierLabel.Location = new System.Drawing.Point(6, 66);
            this.VehicleIdentifierLabel.Name = "VehicleIdentifierLabel";
            this.VehicleIdentifierLabel.Size = new System.Drawing.Size(161, 25);
            this.VehicleIdentifierLabel.TabIndex = 2;
            this.VehicleIdentifierLabel.Text = "Vehicle Identifier:";
            // 
            // VehicleIdentifierOutput
            // 
            this.VehicleIdentifierOutput.Enabled = false;
            this.VehicleIdentifierOutput.Location = new System.Drawing.Point(173, 63);
            this.VehicleIdentifierOutput.Name = "VehicleIdentifierOutput";
            this.VehicleIdentifierOutput.Size = new System.Drawing.Size(230, 30);
            this.VehicleIdentifierOutput.TabIndex = 3;
            // 
            // LoadCountLabel
            // 
            this.LoadCountLabel.AutoSize = true;
            this.LoadCountLabel.Location = new System.Drawing.Point(6, 108);
            this.LoadCountLabel.Name = "LoadCountLabel";
            this.LoadCountLabel.Size = new System.Drawing.Size(120, 25);
            this.LoadCountLabel.TabIndex = 4;
            this.LoadCountLabel.Text = "Load Count:";
            // 
            // LoadCountOutput
            // 
            this.LoadCountOutput.Enabled = false;
            this.LoadCountOutput.Location = new System.Drawing.Point(173, 105);
            this.LoadCountOutput.Name = "LoadCountOutput";
            this.LoadCountOutput.Size = new System.Drawing.Size(230, 30);
            this.LoadCountOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mpg:";
            // 
            // MpgOutput
            // 
            this.MpgOutput.Enabled = false;
            this.MpgOutput.Location = new System.Drawing.Point(173, 147);
            this.MpgOutput.Name = "MpgOutput";
            this.MpgOutput.Size = new System.Drawing.Size(230, 30);
            this.MpgOutput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Todo:";
            // 
            // TodoList
            // 
            this.TodoList.FormattingEnabled = true;
            this.TodoList.ItemHeight = 25;
            this.TodoList.Location = new System.Drawing.Point(173, 189);
            this.TodoList.Name = "TodoList";
            this.TodoList.Size = new System.Drawing.Size(230, 254);
            this.TodoList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Company Name:";
            // 
            // CompanyNameOutput
            // 
            this.CompanyNameOutput.Enabled = false;
            this.CompanyNameOutput.Location = new System.Drawing.Point(194, 10);
            this.CompanyNameOutput.Name = "CompanyNameOutput";
            this.CompanyNameOutput.Size = new System.Drawing.Size(230, 30);
            this.CompanyNameOutput.TabIndex = 4;
            // 
            // CompanyVehiclesOutput
            // 
            this.CompanyVehiclesOutput.AutoSize = true;
            this.CompanyVehiclesOutput.Location = new System.Drawing.Point(6, 52);
            this.CompanyVehiclesOutput.Name = "CompanyVehiclesOutput";
            this.CompanyVehiclesOutput.Size = new System.Drawing.Size(183, 25);
            this.CompanyVehiclesOutput.TabIndex = 5;
            this.CompanyVehiclesOutput.Text = "Company Vehicles:";
            this.CompanyVehiclesOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompanyVehicles
            // 
            this.CompanyVehicles.FormattingEnabled = true;
            this.CompanyVehicles.ItemHeight = 25;
            this.CompanyVehicles.Location = new System.Drawing.Point(195, 52);
            this.CompanyVehicles.Name = "CompanyVehicles";
            this.CompanyVehicles.Size = new System.Drawing.Size(229, 404);
            this.CompanyVehicles.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 513);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabSelector.ResumeLayout(false);
            this.CompanyTab.ResumeLayout(false);
            this.CompanyTab.PerformLayout();
            this.VehicleTab.ResumeLayout(false);
            this.VehicleTab.PerformLayout();
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
        private System.Windows.Forms.Label VehicleIdentifierLabel;
        private System.Windows.Forms.ListBox TodoList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MpgOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoadCountOutput;
        private System.Windows.Forms.Label LoadCountLabel;
        private System.Windows.Forms.TextBox VehicleIdentifierOutput;
        private System.Windows.Forms.TextBox CompanyNameOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CompanyVehicles;
        private System.Windows.Forms.Label CompanyVehiclesOutput;
    }
}

