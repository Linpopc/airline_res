
namespace airline_reservation_system
{
    partial class ConfirmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmBooking));
            this.label7 = new System.Windows.Forms.Label();
            this.seatNumber = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.checkBoxClassA = new System.Windows.Forms.CheckBox();
            this.checkBoxClassB = new System.Windows.Forms.CheckBox();
            this.checkBoxClassC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Место в самолете:";
            // 
            // seatNumber
            // 
            this.seatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatNumber.DropDownHeight = 50;
            this.seatNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatNumber.FormattingEnabled = true;
            this.seatNumber.IntegralHeight = false;
            this.seatNumber.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5",
            "E6",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6"});
            this.seatNumber.Location = new System.Drawing.Point(229, 99);
            this.seatNumber.Margin = new System.Windows.Forms.Padding(4);
            this.seatNumber.Name = "seatNumber";
            this.seatNumber.Size = new System.Drawing.Size(193, 25);
            this.seatNumber.TabIndex = 15;
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
            this.submitButton.Location = new System.Drawing.Point(29, 165);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(403, 43);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Подтвердить бронирование";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // checkBoxClassA
            // 
            this.checkBoxClassA.AutoSize = true;
            this.checkBoxClassA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxClassA.Location = new System.Drawing.Point(12, 50);
            this.checkBoxClassA.Name = "checkBoxClassA";
            this.checkBoxClassA.Size = new System.Drawing.Size(120, 20);
            this.checkBoxClassA.TabIndex = 19;
            this.checkBoxClassA.Text = "Первый класс";
            this.checkBoxClassA.UseVisualStyleBackColor = true;
            this.checkBoxClassA.Click += new System.EventHandler(this.checkBoxClassA_Clicked);
            // 
            // checkBoxClassB
            // 
            this.checkBoxClassB.AutoSize = true;
            this.checkBoxClassB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxClassB.Location = new System.Drawing.Point(165, 50);
            this.checkBoxClassB.Name = "checkBoxClassB";
            this.checkBoxClassB.Size = new System.Drawing.Size(117, 20);
            this.checkBoxClassB.TabIndex = 20;
            this.checkBoxClassB.Text = "Второй класс";
            this.checkBoxClassB.UseVisualStyleBackColor = true;
            this.checkBoxClassB.Click += new System.EventHandler(this.checkBoxClassB_Clicked);
            // 
            // checkBoxClassC
            // 
            this.checkBoxClassC.AutoSize = true;
            this.checkBoxClassC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxClassC.Location = new System.Drawing.Point(315, 50);
            this.checkBoxClassC.Name = "checkBoxClassC";
            this.checkBoxClassC.Size = new System.Drawing.Size(117, 20);
            this.checkBoxClassC.TabIndex = 21;
            this.checkBoxClassC.Text = "Третий класс";
            this.checkBoxClassC.UseVisualStyleBackColor = true;
            this.checkBoxClassC.Click += new System.EventHandler(this.checkBoxClassC_Clicked);
            // 
            // ConfirmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(457, 333);
            this.Controls.Add(this.checkBoxClassC);
            this.Controls.Add(this.checkBoxClassB);
            this.Controls.Add(this.checkBoxClassA);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.seatNumber);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfirmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение бронирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox seatNumber;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox checkBoxClassA;
        private System.Windows.Forms.CheckBox checkBoxClassB;
        private System.Windows.Forms.CheckBox checkBoxClassC;
    }
}