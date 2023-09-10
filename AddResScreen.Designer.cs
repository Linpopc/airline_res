
namespace airline_reservation_system
{
    partial class AddResScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResScreen));
            this.submitButton = new System.Windows.Forms.Button();
            this.viewGrid = new System.Windows.Forms.DataGridView();
            this.place_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_city = new System.Windows.Forms.TextBox();
            this.arr_city = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchRes = new System.Windows.Forms.Button();
            this.date_arr = new System.Windows.Forms.DateTimePicker();
            this.date_dep = new System.Windows.Forms.DateTimePicker();
            this.dep_lab = new System.Windows.Forms.Label();
            this.arr_lab = new System.Windows.Forms.Label();
            this.checkDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(321, 639);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(607, 43);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Забронировать";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place_department,
            this.place_arrive,
            this.date_department,
            this.time_depart,
            this.date_arrive,
            this.time_arrive});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.GridColor = System.Drawing.Color.White;
            this.viewGrid.Location = new System.Drawing.Point(36, 246);
            this.viewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.viewGrid.Name = "viewGrid";
            this.viewGrid.ReadOnly = true;
            this.viewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewGrid.RowHeadersVisible = false;
            this.viewGrid.RowHeadersWidth = 62;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.Size = new System.Drawing.Size(1173, 348);
            this.viewGrid.TabIndex = 43;
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
            // dep_city
            // 
            this.dep_city.Location = new System.Drawing.Point(115, 31);
            this.dep_city.Margin = new System.Windows.Forms.Padding(4);
            this.dep_city.Name = "dep_city";
            this.dep_city.Size = new System.Drawing.Size(132, 22);
            this.dep_city.TabIndex = 44;
            // 
            // arr_city
            // 
            this.arr_city.Location = new System.Drawing.Point(115, 82);
            this.arr_city.Margin = new System.Windows.Forms.Padding(4);
            this.arr_city.Name = "arr_city";
            this.arr_city.Size = new System.Drawing.Size(132, 22);
            this.arr_city.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Куда";
            // 
            // searchRes
            // 
            this.searchRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.searchRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRes.Font = new System.Drawing.Font("Rockwell Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchRes.Location = new System.Drawing.Point(736, 44);
            this.searchRes.Margin = new System.Windows.Forms.Padding(4);
            this.searchRes.Name = "searchRes";
            this.searchRes.Size = new System.Drawing.Size(143, 57);
            this.searchRes.TabIndex = 52;
            this.searchRes.Text = "Найти";
            this.searchRes.UseVisualStyleBackColor = false;
            this.searchRes.Click += new System.EventHandler(this.searchRes_Click);
            // 
            // date_arr
            // 
            this.date_arr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_arr.Location = new System.Drawing.Point(469, 85);
            this.date_arr.Name = "date_arr";
            this.date_arr.Size = new System.Drawing.Size(200, 22);
            this.date_arr.TabIndex = 53;
            this.date_arr.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // date_dep
            // 
            this.date_dep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dep.Location = new System.Drawing.Point(469, 31);
            this.date_dep.Name = "date_dep";
            this.date_dep.Size = new System.Drawing.Size(200, 22);
            this.date_dep.TabIndex = 54;
            this.date_dep.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // dep_lab
            // 
            this.dep_lab.AutoSize = true;
            this.dep_lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dep_lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dep_lab.Location = new System.Drawing.Point(270, 34);
            this.dep_lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dep_lab.Name = "dep_lab";
            this.dep_lab.Size = new System.Drawing.Size(128, 16);
            this.dep_lab.TabIndex = 55;
            this.dep_lab.Text = "Дата отправления";
            // 
            // arr_lab
            // 
            this.arr_lab.AutoSize = true;
            this.arr_lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.arr_lab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arr_lab.Location = new System.Drawing.Point(270, 88);
            this.arr_lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arr_lab.Name = "arr_lab";
            this.arr_lab.Size = new System.Drawing.Size(105, 16);
            this.arr_lab.TabIndex = 56;
            this.arr_lab.Text = "Дата прибытия";
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkDate.Location = new System.Drawing.Point(124, 156);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(323, 20);
            this.checkDate.TabIndex = 57;
            this.checkDate.Text = "Игнорировать дату отправления и прибытия";
            this.checkDate.UseVisualStyleBackColor = true;
            // 
            // AddResScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1268, 748);
            this.Controls.Add(this.checkDate);
            this.Controls.Add(this.arr_lab);
            this.Controls.Add(this.dep_lab);
            this.Controls.Add(this.date_dep);
            this.Controls.Add(this.date_arr);
            this.Controls.Add(this.searchRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arr_city);
            this.Controls.Add(this.dep_city);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddResScreen";
            this.Text = "Бронирование";
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_arrive;
        private System.Windows.Forms.TextBox dep_city;
        private System.Windows.Forms.TextBox arr_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchRes;
        private System.Windows.Forms.DateTimePicker date_arr;
        private System.Windows.Forms.DateTimePicker date_dep;
        private System.Windows.Forms.Label dep_lab;
        private System.Windows.Forms.Label arr_lab;
        private System.Windows.Forms.CheckBox checkDate;
    }
}