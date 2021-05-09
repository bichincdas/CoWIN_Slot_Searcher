
namespace CoWIN_Slot_Searcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuickSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDistricts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Center = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSearchStatus = new System.Windows.Forms.Label();
            this.labelCurrrentTime = new System.Windows.Forms.Label();
            this.labelLastUpdatedTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxPhoneNumber = new System.Windows.Forms.GroupBox();
            this.textBoxNotifyPinCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxNotifyMessage = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyAlarm = new System.Windows.Forms.CheckBox();
            this.textBoxAvailableSlotLimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxPhoneNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxStates);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonQuickSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxDistricts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Properties";
            // 
            // comboBoxStates
            // 
            this.comboBoxStates.FormattingEnabled = true;
            this.comboBoxStates.Location = new System.Drawing.Point(94, 21);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStates.TabIndex = 8;
            this.comboBoxStates.SelectedIndexChanged += new System.EventHandler(this.comboBoxStates_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Select State";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "30 Sec",
            "1 Min",
            "5 Min",
            "10 Min",
            "15 Min",
            "30 Min"});
            this.comboBoxInterval.Location = new System.Drawing.Point(94, 106);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(200, 21);
            this.comboBoxInterval.TabIndex = 6;
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.OnSearchPropertiesChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Interval;";
            // 
            // buttonQuickSearch
            // 
            this.buttonQuickSearch.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonQuickSearch.Location = new System.Drawing.Point(10, 133);
            this.buttonQuickSearch.Name = "buttonQuickSearch";
            this.buttonQuickSearch.Size = new System.Drawing.Size(285, 23);
            this.buttonQuickSearch.TabIndex = 4;
            this.buttonQuickSearch.Text = "Start Continuous Search";
            this.buttonQuickSearch.UseVisualStyleBackColor = false;
            this.buttonQuickSearch.Click += new System.EventHandler(this.buttonSearchSlot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.OnSearchPropertiesChanged);
            // 
            // comboBoxDistricts
            // 
            this.comboBoxDistricts.FormattingEnabled = true;
            this.comboBoxDistricts.Location = new System.Drawing.Point(94, 47);
            this.comboBoxDistricts.Name = "comboBoxDistricts";
            this.comboBoxDistricts.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDistricts.TabIndex = 1;
            this.comboBoxDistricts.SelectedIndexChanged += new System.EventHandler(this.OnSearchPropertiesChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select District:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slot Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Center,
            this.Address,
            this.Pin,
            this.Session1,
            this.Session2,
            this.Session3,
            this.Session4});
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(761, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // Center
            // 
            this.Center.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Center.HeaderText = "Center";
            this.Center.Name = "Center";
            this.Center.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Pin
            // 
            this.Pin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
            // 
            // Session1
            // 
            this.Session1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Session1.HeaderText = "Session1";
            this.Session1.Name = "Session1";
            this.Session1.ReadOnly = true;
            // 
            // Session2
            // 
            this.Session2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Session2.HeaderText = "Session2";
            this.Session2.Name = "Session2";
            this.Session2.ReadOnly = true;
            // 
            // Session3
            // 
            this.Session3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Session3.HeaderText = "Session3";
            this.Session3.Name = "Session3";
            this.Session3.ReadOnly = true;
            // 
            // Session4
            // 
            this.Session4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Session4.HeaderText = "Session4";
            this.Session4.Name = "Session4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSearchStatus);
            this.groupBox3.Controls.Add(this.labelCurrrentTime);
            this.groupBox3.Controls.Add(this.labelLastUpdatedTime);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 40);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // labelSearchStatus
            // 
            this.labelSearchStatus.AutoSize = true;
            this.labelSearchStatus.ForeColor = System.Drawing.Color.Red;
            this.labelSearchStatus.Location = new System.Drawing.Point(219, 16);
            this.labelSearchStatus.Name = "labelSearchStatus";
            this.labelSearchStatus.Size = new System.Drawing.Size(74, 13);
            this.labelSearchStatus.TabIndex = 4;
            this.labelSearchStatus.Text = "Search Status";
            // 
            // labelCurrrentTime
            // 
            this.labelCurrrentTime.AutoSize = true;
            this.labelCurrrentTime.Location = new System.Drawing.Point(679, 16);
            this.labelCurrrentTime.Name = "labelCurrrentTime";
            this.labelCurrrentTime.Size = new System.Drawing.Size(13, 13);
            this.labelCurrrentTime.TabIndex = 3;
            this.labelCurrrentTime.Text = "0";
            // 
            // labelLastUpdatedTime
            // 
            this.labelLastUpdatedTime.AutoSize = true;
            this.labelLastUpdatedTime.Location = new System.Drawing.Point(115, 16);
            this.labelLastUpdatedTime.Name = "labelLastUpdatedTime";
            this.labelLastUpdatedTime.Size = new System.Drawing.Size(13, 13);
            this.labelLastUpdatedTime.TabIndex = 2;
            this.labelLastUpdatedTime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Updated Time: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxPhoneNumber
            // 
            this.groupBoxPhoneNumber.Controls.Add(this.textBoxNotifyPinCode);
            this.groupBoxPhoneNumber.Controls.Add(this.label6);
            this.groupBoxPhoneNumber.Controls.Add(this.checkBoxNotifyMessage);
            this.groupBoxPhoneNumber.Controls.Add(this.checkBoxNotifyAlarm);
            this.groupBoxPhoneNumber.Controls.Add(this.textBoxAvailableSlotLimit);
            this.groupBoxPhoneNumber.Controls.Add(this.label5);
            this.groupBoxPhoneNumber.Location = new System.Drawing.Point(327, 62);
            this.groupBoxPhoneNumber.Name = "groupBoxPhoneNumber";
            this.groupBoxPhoneNumber.Size = new System.Drawing.Size(460, 118);
            this.groupBoxPhoneNumber.TabIndex = 3;
            this.groupBoxPhoneNumber.TabStop = false;
            this.groupBoxPhoneNumber.Text = "Notification Settings";
            // 
            // textBoxNotifyPinCode
            // 
            this.textBoxNotifyPinCode.Location = new System.Drawing.Point(198, 53);
            this.textBoxNotifyPinCode.Name = "textBoxNotifyPinCode";
            this.textBoxNotifyPinCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxNotifyPinCode.TabIndex = 8;
            this.textBoxNotifyPinCode.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Notify only for center with PIN code: ";
            // 
            // checkBoxNotifyMessage
            // 
            this.checkBoxNotifyMessage.AutoSize = true;
            this.checkBoxNotifyMessage.Location = new System.Drawing.Point(137, 89);
            this.checkBoxNotifyMessage.Name = "checkBoxNotifyMessage";
            this.checkBoxNotifyMessage.Size = new System.Drawing.Size(161, 17);
            this.checkBoxNotifyMessage.TabIndex = 5;
            this.checkBoxNotifyMessage.Text = "Notify By Telegram Message";
            this.checkBoxNotifyMessage.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyAlarm
            // 
            this.checkBoxNotifyAlarm.AutoSize = true;
            this.checkBoxNotifyAlarm.Checked = true;
            this.checkBoxNotifyAlarm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotifyAlarm.Location = new System.Drawing.Point(14, 89);
            this.checkBoxNotifyAlarm.Name = "checkBoxNotifyAlarm";
            this.checkBoxNotifyAlarm.Size = new System.Drawing.Size(97, 17);
            this.checkBoxNotifyAlarm.TabIndex = 4;
            this.checkBoxNotifyAlarm.Text = "Notify By Alarm";
            this.checkBoxNotifyAlarm.UseVisualStyleBackColor = true;
            // 
            // textBoxAvailableSlotLimit
            // 
            this.textBoxAvailableSlotLimit.Location = new System.Drawing.Point(198, 23);
            this.textBoxAvailableSlotLimit.Name = "textBoxAvailableSlotLimit";
            this.textBoxAvailableSlotLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvailableSlotLimit.TabIndex = 2;
            this.textBoxAvailableSlotLimit.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Notify when available slots more than:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoWIN_Slot_Searcher.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(391, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 55);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxPhoneNumber);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CoWIN Slot Searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxPhoneNumber.ResumeLayout(false);
            this.groupBoxPhoneNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDistricts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonQuickSearch;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSearchStatus;
        private System.Windows.Forms.Label labelCurrrentTime;
        private System.Windows.Forms.Label labelLastUpdatedTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxPhoneNumber;
        private System.Windows.Forms.CheckBox checkBoxNotifyMessage;
        private System.Windows.Forms.CheckBox checkBoxNotifyAlarm;
        private System.Windows.Forms.TextBox textBoxAvailableSlotLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNotifyPinCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Center;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session4;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

