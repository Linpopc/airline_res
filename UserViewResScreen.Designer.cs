namespace airline_reservation_system
{
    partial class UserViewResScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserViewResScreen));
            this.searchButton = new System.Windows.Forms.Button();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewGrid = new System.Windows.Forms.DataGridView();
            this.place_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.SteelBlue;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(28, 81);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(1146, 43);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Поиск бронирования";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassport.Location = new System.Drawing.Point(296, 34);
            this.textBoxPassport.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(878, 23);
            this.textBoxPassport.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Идентификационный номер:";
            // 
            // viewGrid
            // 
            this.viewGrid.AllowUserToAddRows = false;
            this.viewGrid.AllowUserToDeleteRows = false;
            this.viewGrid.AllowUserToResizeColumns = false;
            this.viewGrid.AllowUserToResizeRows = false;
            this.viewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place_department,
            this.place_arrive,
            this.date_department,
            this.time_depart,
            this.date_arrive,
            this.time_arrive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.GridColor = System.Drawing.Color.White;
            this.viewGrid.Location = new System.Drawing.Point(17, 171);
            this.viewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.viewGrid.Name = "viewGrid";
            this.viewGrid.ReadOnly = true;
            this.viewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewGrid.RowHeadersVisible = false;
            this.viewGrid.RowHeadersWidth = 62;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.Size = new System.Drawing.Size(1173, 348);
            this.viewGrid.TabIndex = 44;
            // 
            // place_department
            // 
            this.place_department.HeaderText = "Пункт вылета";
            this.place_department.MinimumWidth = 8;
            this.place_department.Name = "place_department";
            this.place_department.ReadOnly = true;
            // 
            // place_arrive
            // 
            this.place_arrive.HeaderText = "Пункт прибытия";
            this.place_arrive.MinimumWidth = 6;
            this.place_arrive.Name = "place_arrive";
            this.place_arrive.ReadOnly = true;
            // 
            // date_department
            // 
            this.date_department.HeaderText = "Дата вылета";
            this.date_department.MinimumWidth = 8;
            this.date_department.Name = "date_department";
            this.date_department.ReadOnly = true;
            // 
            // time_depart
            // 
            this.time_depart.HeaderText = "Время вылета";
            this.time_depart.MinimumWidth = 6;
            this.time_depart.Name = "time_depart";
            this.time_depart.ReadOnly = true;
            // 
            // date_arrive
            // 
            this.date_arrive.HeaderText = "Дата прибытия";
            this.date_arrive.MinimumWidth = 8;
            this.date_arrive.Name = "date_arrive";
            this.date_arrive.ReadOnly = true;
            // 
            // time_arrive
            // 
            this.time_arrive.HeaderText = "Время прибытия";
            this.time_arrive.MinimumWidth = 6;
            this.time_arrive.Name = "time_arrive";
            this.time_arrive.ReadOnly = true;
            // 
            // UserViewResScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1199, 588);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserViewResScreen";
            this.Text = "Просмотр бронирования";
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_arrive;
    }
}