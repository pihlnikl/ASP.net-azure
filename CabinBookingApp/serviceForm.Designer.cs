namespace CabinBookingApp
{
    partial class serviceForm
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
            this.cabinList = new System.Windows.Forms.ListBox();
            this.saveButtonBooking = new System.Windows.Forms.Button();
            this.deleteButtonBooking = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serviceBox2 = new System.Windows.Forms.ListBox();
            this.reservationsBox = new System.Windows.Forms.ListBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.saveButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serviceBox = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cabinList
            // 
            this.cabinList.FormattingEnabled = true;
            this.cabinList.Location = new System.Drawing.Point(12, 23);
            this.cabinList.Name = "cabinList";
            this.cabinList.Size = new System.Drawing.Size(271, 160);
            this.cabinList.TabIndex = 1;
            // 
            // saveButtonBooking
            // 
            this.saveButtonBooking.Location = new System.Drawing.Point(31, 505);
            this.saveButtonBooking.Name = "saveButtonBooking";
            this.saveButtonBooking.Size = new System.Drawing.Size(103, 23);
            this.saveButtonBooking.TabIndex = 10;
            this.saveButtonBooking.Text = "Save";
            this.saveButtonBooking.UseVisualStyleBackColor = true;
            this.saveButtonBooking.Click += new System.EventHandler(this.saveButtonBooking_Click);
            // 
            // deleteButtonBooking
            // 
            this.deleteButtonBooking.Location = new System.Drawing.Point(155, 505);
            this.deleteButtonBooking.Name = "deleteButtonBooking";
            this.deleteButtonBooking.Size = new System.Drawing.Size(103, 23);
            this.deleteButtonBooking.TabIndex = 11;
            this.deleteButtonBooking.Text = "Delete";
            this.deleteButtonBooking.UseVisualStyleBackColor = true;
            this.deleteButtonBooking.Click += new System.EventHandler(this.deleteButtonBooking_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceBox2);
            this.groupBox2.Controls.Add(this.reservationsBox);
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.deleteButtonBooking);
            this.groupBox2.Controls.Add(this.saveButtonBooking);
            this.groupBox2.Location = new System.Drawing.Point(324, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 538);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Reservation";
            // 
            // serviceBox2
            // 
            this.serviceBox2.FormattingEnabled = true;
            this.serviceBox2.Location = new System.Drawing.Point(16, 198);
            this.serviceBox2.Name = "serviceBox2";
            this.serviceBox2.Size = new System.Drawing.Size(262, 121);
            this.serviceBox2.TabIndex = 15;
            // 
            // reservationsBox
            // 
            this.reservationsBox.FormattingEnabled = true;
            this.reservationsBox.Location = new System.Drawing.Point(16, 23);
            this.reservationsBox.Name = "reservationsBox";
            this.reservationsBox.Size = new System.Drawing.Size(262, 160);
            this.reservationsBox.TabIndex = 19;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(31, 331);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(29, 505);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(227, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 331);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceBox);
            this.groupBox1.Controls.Add(this.cabinList);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 538);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // serviceBox
            // 
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.Location = new System.Drawing.Point(12, 198);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(271, 121);
            this.serviceBox.TabIndex = 14;
            // 
            // serviceForm
            // 
            this.ClientSize = new System.Drawing.Size(636, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "serviceForm";
            this.Text = "Services";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox cabinList;
        private System.Windows.Forms.Button saveButtonBooking;
        private System.Windows.Forms.Button deleteButtonBooking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox serviceBox;
        private System.Windows.Forms.ListBox serviceBox2;
        private System.Windows.Forms.ListBox reservationsBox;
    }
}

