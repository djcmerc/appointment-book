namespace PA5
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarmLabel = new System.Windows.Forms.Label();
            this.alarmTimeDisplay = new System.Windows.Forms.Label();
            this.stopAlarm = new System.Windows.Forms.Button();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.aptBook = new System.Windows.Forms.ListBox();
            this.addAppointment = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReminder = new System.Windows.Forms.Button();
            this.reminderPicture = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reminderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(14, 9);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(55, 23);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Location = new System.Drawing.Point(77, 9);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(108, 23);
            this.currentDate.TabIndex = 1;
            this.currentDate.Text = "currentDate";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(14, 43);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 23);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time:";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(77, 43);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(111, 23);
            this.currentTime.TabIndex = 1;
            this.currentTime.Text = "currentTime";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmLabel.Location = new System.Drawing.Point(14, 121);
            this.alarmLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(115, 23);
            this.alarmLabel.TabIndex = 0;
            this.alarmLabel.Text = "Alarm Time:";
            this.alarmLabel.Visible = false;
            // 
            // alarmTimeDisplay
            // 
            this.alarmTimeDisplay.AutoSize = true;
            this.alarmTimeDisplay.Location = new System.Drawing.Point(137, 121);
            this.alarmTimeDisplay.Name = "alarmTimeDisplay";
            this.alarmTimeDisplay.Size = new System.Drawing.Size(99, 23);
            this.alarmTimeDisplay.TabIndex = 1;
            this.alarmTimeDisplay.Text = "alarmTime";
            this.alarmTimeDisplay.Visible = false;
            // 
            // stopAlarm
            // 
            this.stopAlarm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAlarm.Location = new System.Drawing.Point(99, 80);
            this.stopAlarm.Name = "stopAlarm";
            this.stopAlarm.Size = new System.Drawing.Size(86, 23);
            this.stopAlarm.TabIndex = 2;
            this.stopAlarm.Text = "Stop Alarm";
            this.stopAlarm.UseVisualStyleBackColor = true;
            this.stopAlarm.Click += new System.EventHandler(this.stopAlarm_Click);
            // 
            // btnSnooze
            // 
            this.btnSnooze.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnooze.Location = new System.Drawing.Point(191, 80);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(89, 23);
            this.btnSnooze.TabIndex = 2;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // aptBook
            // 
            this.aptBook.FormattingEnabled = true;
            this.aptBook.ItemHeight = 23;
            this.aptBook.Location = new System.Drawing.Point(349, 9);
            this.aptBook.Name = "aptBook";
            this.aptBook.Size = new System.Drawing.Size(296, 257);
            this.aptBook.TabIndex = 3;
            this.aptBook.Click += new System.EventHandler(this.aptBook_Click);
            // 
            // addAppointment
            // 
            this.addAppointment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointment.Location = new System.Drawing.Point(12, 431);
            this.addAppointment.Name = "addAppointment";
            this.addAppointment.Size = new System.Drawing.Size(127, 23);
            this.addAppointment.TabIndex = 2;
            this.addAppointment.Text = "Add Appointment";
            this.addAppointment.UseVisualStyleBackColor = true;
            this.addAppointment.Click += new System.EventHandler(this.addAppointment_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 253);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(8, 285);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(272, 140);
            this.commentBox.TabIndex = 5;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(85, 215);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(133, 32);
            this.nameTextbox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 218);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 23);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Appointments";
            // 
            // btnReminder
            // 
            this.btnReminder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminder.Location = new System.Drawing.Point(153, 431);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(127, 23);
            this.btnReminder.TabIndex = 2;
            this.btnReminder.Text = "Add Reminder";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // reminderPicture
            // 
            this.reminderPicture.Image = global::PA5.Properties.Resources.Dragon;
            this.reminderPicture.InitialImage = null;
            this.reminderPicture.Location = new System.Drawing.Point(395, 314);
            this.reminderPicture.Name = "reminderPicture";
            this.reminderPicture.Size = new System.Drawing.Size(203, 140);
            this.reminderPicture.TabIndex = 8;
            this.reminderPicture.TabStop = false;
            this.reminderPicture.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(395, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(523, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 466);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.reminderPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.aptBook);
            this.Controls.Add(this.btnSnooze);
            this.Controls.Add(this.stopAlarm);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.addAppointment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alarmTimeDisplay);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "PA5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reminderPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Label alarmTimeDisplay;
        private System.Windows.Forms.Button stopAlarm;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.ListBox aptBook;
        private System.Windows.Forms.Button addAppointment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.PictureBox reminderPicture;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}

