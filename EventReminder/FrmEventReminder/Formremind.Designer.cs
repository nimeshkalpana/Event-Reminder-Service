namespace FrmEventReminder
{
    partial class Formremind
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbdefault = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cmbCustomize = new System.Windows.Forms.ComboBox();
            this.dgwEventList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmsDgwEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdatetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventList)).BeginInit();
            this.cmsDgwEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Reminder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight Number :";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event :";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time :";
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remind  :";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(417, 42);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(184, 20);
            this.dtpTime.TabIndex = 6;
            this.dtpTime.FormatChanged += new System.EventHandler(this.dtpTime_FormatChanged);
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(132, 46);
            this.txtFlightNo.Multiline = true;
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(194, 20);
            this.txtFlightNo.TabIndex = 7;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(79, 73);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(247, 51);
            this.txtEvent.TabIndex = 8;
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(417, 78);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(184, 20);
            this.dtpdate.TabIndex = 9;
            // 
            // cmbdefault
            // 
            this.cmbdefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbdefault.FormattingEnabled = true;
            this.cmbdefault.Items.AddRange(new object[] {
            "On time",
            "5 mins before",
            "10 mins before",
            "30 mins before",
            "1 hour before",
            "Customize"});
            this.cmbdefault.Location = new System.Drawing.Point(80, 134);
            this.cmbdefault.Name = "cmbdefault";
            this.cmbdefault.Size = new System.Drawing.Size(184, 21);
            this.cmbdefault.TabIndex = 12;
            this.cmbdefault.SelectedIndexChanged += new System.EventHandler(this.cmbdefault_SelectedIndexChanged);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(80, 170);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(23, 20);
            this.txtNum.TabIndex = 13;
            // 
            // cmbCustomize
            // 
            this.cmbCustomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomize.FormattingEnabled = true;
            this.cmbCustomize.Items.AddRange(new object[] {
            "mins before",
            "hours before"});
            this.cmbCustomize.Location = new System.Drawing.Point(109, 169);
            this.cmbCustomize.Name = "cmbCustomize";
            this.cmbCustomize.Size = new System.Drawing.Size(126, 21);
            this.cmbCustomize.TabIndex = 14;
            // 
            // dgwEventList
            // 
            this.dgwEventList.AllowUserToAddRows = false;
            this.dgwEventList.AllowUserToDeleteRows = false;
            this.dgwEventList.AllowUserToResizeColumns = false;
            this.dgwEventList.AllowUserToResizeRows = false;
            this.dgwEventList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEventList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwEventList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEventList.Location = new System.Drawing.Point(5, 218);
            this.dgwEventList.MultiSelect = false;
            this.dgwEventList.Name = "dgwEventList";
            this.dgwEventList.ReadOnly = true;
            this.dgwEventList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEventList.Size = new System.Drawing.Size(596, 130);
            this.dgwEventList.TabIndex = 18;
            this.dgwEventList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEventList_CellContentClick);
            this.dgwEventList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwEventList_CellMouseClick);
            this.dgwEventList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwEventList_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(312, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(380, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 28);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmsDgwEvent
            // 
            this.cmsDgwEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdatetoolStripMenuItem,
            this.DeletetoolStripMenuItem});
            this.cmsDgwEvent.Name = "cmsDgwEvent";
            this.cmsDgwEvent.Size = new System.Drawing.Size(113, 48);
            // 
            // UpdatetoolStripMenuItem
            // 
            this.UpdatetoolStripMenuItem.Name = "UpdatetoolStripMenuItem";
            this.UpdatetoolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.UpdatetoolStripMenuItem.Text = "Update";
            this.UpdatetoolStripMenuItem.Click += new System.EventHandler(this.UpdatetoolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem
            // 
            this.DeletetoolStripMenuItem.Name = "DeletetoolStripMenuItem";
            this.DeletetoolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DeletetoolStripMenuItem.Text = "Delete";
            this.DeletetoolStripMenuItem.Click += new System.EventHandler(this.DeletetoolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(455, 184);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 28);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(613, 351);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgwEventList);
            this.Controls.Add(this.cmbCustomize);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.cmbdefault);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEventList)).EndInit();
            this.cmsDgwEvent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbdefault;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cmbCustomize;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.DataGridView dgwEventList;
        private System.Windows.Forms.ContextMenuStrip cmsDgwEvent;
        private System.Windows.Forms.ToolStripMenuItem UpdatetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}

