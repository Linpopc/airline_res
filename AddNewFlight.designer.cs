namespace AirlineReservationSystem
{
    partial class AddNewFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFlight));
            this.toCity = new System.Windows.Forms.ComboBox();
            this.airplaneIDBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msgBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.DM = new System.Windows.Forms.TextBox();
            this.DH = new System.Windows.Forms.TextBox();
            this.AM = new System.Windows.Forms.TextBox();
            this.AH = new System.Windows.Forms.TextBox();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fromCity = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.flightID = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toCity
            // 
            this.toCity.FormattingEnabled = true;
            this.toCity.Items.AddRange(new object[] {
            "Scheduled",
            "Chartered"});
            this.toCity.Location = new System.Drawing.Point(163, 237);
            this.toCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toCity.Name = "toCity";
            this.toCity.Size = new System.Drawing.Size(193, 21);
            this.toCity.TabIndex = 96;
            // 
            // airplaneIDBox
            // 
            this.airplaneIDBox.FormattingEnabled = true;
            this.airplaneIDBox.Items.AddRange(new object[] {
            "AirlineID"});
            this.airplaneIDBox.Location = new System.Drawing.Point(165, 133);
            this.airplaneIDBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.airplaneIDBox.Name = "airplaneIDBox";
            this.airplaneIDBox.Size = new System.Drawing.Size(193, 21);
            this.airplaneIDBox.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 90;
            this.label11.Text = "Прибытие";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(40, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 18);
            this.label12.TabIndex = 89;
            this.label12.Text = "ID Самолета";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 135);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 546);
            this.panel1.TabIndex = 76;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(134, 143);
            this.panel7.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 36);
            this.label6.TabIndex = 30;
            this.label6.Text = "Панель\r\nуправления";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(834, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(124)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.tableNameHeader);
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 83);
            this.panel2.TabIndex = 77;
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.msgBox.ForeColor = System.Drawing.Color.White;
            this.msgBox.Location = new System.Drawing.Point(286, 380);
            this.msgBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(0, 18);
            this.msgBox.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "Отправление";
            // 
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.Font = new System.Drawing.Font("Arial", 21F);
            this.tableNameHeader.ForeColor = System.Drawing.Color.White;
            this.tableNameHeader.Location = new System.Drawing.Point(299, 24);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(304, 32);
            this.tableNameHeader.TabIndex = 78;
            this.tableNameHeader.Text = "Добавления маршрута";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(135, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(135, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 5);
            this.panel3.TabIndex = 79;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.deletePanel.Controls.Add(this.DM);
            this.deletePanel.Controls.Add(this.DH);
            this.deletePanel.Controls.Add(this.AM);
            this.deletePanel.Controls.Add(this.AH);
            this.deletePanel.Controls.Add(this.dateA);
            this.deletePanel.Controls.Add(this.label14);
            this.deletePanel.Controls.Add(this.label17);
            this.deletePanel.Controls.Add(this.dateD);
            this.deletePanel.Controls.Add(this.label1);
            this.deletePanel.Controls.Add(this.h);
            this.deletePanel.Controls.Add(this.label19);
            this.deletePanel.Controls.Add(this.fromCity);
            this.deletePanel.Controls.Add(this.label15);
            this.deletePanel.Controls.Add(this.label16);
            this.deletePanel.Controls.Add(this.label18);
            this.deletePanel.Controls.Add(this.toCity);
            this.deletePanel.Controls.Add(this.airplaneIDBox);
            this.deletePanel.Controls.Add(this.label11);
            this.deletePanel.Controls.Add(this.label12);
            this.deletePanel.Controls.Add(this.msgBox);
            this.deletePanel.Controls.Add(this.flightID);
            this.deletePanel.Controls.Add(this.label4);
            this.deletePanel.Controls.Add(this.label111);
            this.deletePanel.Controls.Add(this.saveButton);
            this.deletePanel.Location = new System.Drawing.Point(128, 135);
            this.deletePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(886, 411);
            this.deletePanel.TabIndex = 81;
            // 
            // DM
            // 
            this.DM.Location = new System.Drawing.Point(691, 131);
            this.DM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DM.Name = "DM";
            this.DM.Size = new System.Drawing.Size(38, 20);
            this.DM.TabIndex = 127;
            // 
            // DH
            // 
            this.DH.Location = new System.Drawing.Point(604, 130);
            this.DH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(38, 20);
            this.DH.TabIndex = 126;
            // 
            // AM
            // 
            this.AM.Location = new System.Drawing.Point(691, 80);
            this.AM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(38, 20);
            this.AM.TabIndex = 125;
            // 
            // AH
            // 
            this.AH.Location = new System.Drawing.Point(604, 79);
            this.AH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AH.Name = "AH";
            this.AH.Size = new System.Drawing.Size(38, 20);
            this.AH.TabIndex = 124;
            // 
            // dateA
            // 
            this.dateA.CustomFormat = "dd-MM-yyyy";
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateA.Location = new System.Drawing.Point(604, 238);
            this.dateA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateA.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateA.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateA.Name = "dateA";
            this.dateA.Size = new System.Drawing.Size(99, 20);
            this.dateA.TabIndex = 123;
            this.dateA.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(463, 236);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 18);
            this.label14.TabIndex = 122;
            this.label14.Text = "Дата прибытия";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(463, 183);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 18);
            this.label17.TabIndex = 121;
            this.label17.Text = "Дата отправления";
            // 
            // dateD
            // 
            this.dateD.CustomFormat = "dd-MM-yyyy";
            this.dateD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateD.Location = new System.Drawing.Point(604, 187);
            this.dateD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateD.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateD.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(99, 20);
            this.dateD.TabIndex = 118;
            this.dateD.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(695, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 117;
            this.label1.Text = "Мин";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.h.ForeColor = System.Drawing.Color.White;
            this.h.Location = new System.Drawing.Point(607, 152);
            this.h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(35, 14);
            this.h.TabIndex = 114;
            this.h.Text = "Часы";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(695, 99);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 14);
            this.label19.TabIndex = 113;
            this.label19.Text = "Мин";
            // 
            // fromCity
            // 
            this.fromCity.FormattingEnabled = true;
            this.fromCity.Items.AddRange(new object[] {
            "AirlineID"});
            this.fromCity.Location = new System.Drawing.Point(162, 185);
            this.fromCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromCity.Name = "fromCity";
            this.fromCity.Size = new System.Drawing.Size(193, 21);
            this.fromCity.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(607, 99);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 14);
            this.label15.TabIndex = 105;
            this.label15.Text = "Часы";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(452, 129);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 18);
            this.label16.TabIndex = 101;
            this.label16.Text = "Время прибытия";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(452, 80);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 18);
            this.label18.TabIndex = 99;
            this.label18.Text = "Время отправления";
            // 
            // flightID
            // 
            this.flightID.Location = new System.Drawing.Point(162, 81);
            this.flightID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightID.Name = "flightID";
            this.flightID.Size = new System.Drawing.Size(196, 20);
            this.flightID.TabIndex = 80;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label111.ForeColor = System.Drawing.Color.White;
            this.label111.Location = new System.Drawing.Point(39, 79);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(99, 18);
            this.label111.TabIndex = 74;
            this.label111.Text = "ID Маршрута";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(374, 331);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 32);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddNewFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(124)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1015, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.deletePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox toCity;
        private System.Windows.Forms.ComboBox airplaneIDBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.TextBox flightID;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox fromCity;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox DM;
        private System.Windows.Forms.TextBox DH;
        private System.Windows.Forms.TextBox AM;
        private System.Windows.Forms.TextBox AH;
    }
}