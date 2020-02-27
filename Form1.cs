using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5
{
    public partial class Form1 : Form
    {
        BackgroundWorker bwAlarm = new BackgroundWorker();
        BackgroundWorker bwReminder = new BackgroundWorker();
        SoundPlayer player;
        private DateTime alarmTime, reminderTime;
        private bool alarmStatus;
        private int numAppointments;
        private List<DateTime> dates = new List<DateTime>();
        private List<DateTime> times = new List<DateTime>();
        private List<DateTime> reminders = new List<DateTime>();
        private List<string> comments = new List<string>();

        public Form1()
        {
            InitializeComponent();
            currentDate.Text = DateTime.Now.ToLongDateString();
            currentTime.Text = DateTime.Now.ToLongTimeString();
            bwAlarm.DoWork += bwAlarm_DoWork;
            bwReminder.DoWork += bwReminder_DoWork;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public static void PromptReminder()
        //{

        //}

        // Adds an alarm
        private void button1_Click(object sender, EventArgs e)
        {
            AlarmSetDialog dlg = new AlarmSetDialog();
            DialogResult dr = dlg.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                alarmTime = new DateTime(dlg.Year, dlg.Month, dlg.Day, dlg.Hour, dlg.Minute, dlg.Second);
                alarmTimeDisplay.Text = alarmTime.ToLongTimeString();
                alarmLabel.Visible = true;
                alarmTimeDisplay.Visible = true;
                bwAlarm.RunWorkerAsync();
            }
        }

        // Constantly checks if the current time is the same as the alarm time
        private void bwAlarm_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatus = true;
            while(alarmStatus)
            {
                if (DateTime.Compare(DateTime.Now, alarmTime) >= 0)
                {
                    player = new SoundPlayer(PA5.Properties.Resources.Goodmorn);
                    player.PlayLooping();
                    alarmLabel.Visible = false;
                    alarmTimeDisplay.Visible = false;
                    break;
                }
            }
        }

        // Constantly checks if the current time is the same as a reminder time
        private void bwReminder_DoWork(object sender, DoWorkEventArgs e)
        {
            int index;
            while (numAppointments != 0)
            {
                foreach (DateTime reminder in reminders)
                {
                    if (DateTime.Compare(DateTime.Now, reminder) >= 0)
                    {
                        index = reminders.IndexOf(reminder);
                        player = new SoundPlayer(PA5.Properties.Resources.notify);
                        player.Play();
                        reminderPicture.Visible = true;
                        Reminder reminderWindow = new Reminder();
                        DialogResult dr = reminderWindow.ShowDialog();
                        reminderWindow.nameLabel.Text = aptBook.Items[index].ToString();
                        reminderWindow.dateTimeLabel.Text = reminder.ToString();
                        if (dr == System.Windows.Forms.DialogResult.OK)
                        {
                            reminderPicture.Visible = false;
                            reminders.RemoveAt(index);
                        }                
                    }
                }     
            }
        }

        // Keeps time and date updated
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentDate.Text = DateTime.Now.ToLongDateString();
            currentTime.Text = DateTime.Now.ToLongTimeString();
        }

        // Stops the alarm
        private void stopAlarm_Click(object sender, EventArgs e)
        {
            if (alarmStatus)
            {
                player.Stop();
                alarmStatus = false;
            }
        }

        // Snoozes the alarm
        private void btnSnooze_Click(object sender, EventArgs e)
        {
            int newSeconds, newMinute = 0;
            if (!alarmStatus)
            {
                MessageBox.Show("An alarm has not been set. ");
            }
            else
            {
                Snooze dlg = new Snooze();
                DialogResult dr = dlg.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    player.Stop();
                    newSeconds = (DateTime.Now.Second) + (dlg.Seconds);
                    if (newSeconds > 59)
                    {
                        newMinute += (newSeconds / 60);
                        newSeconds -= 60;
                    }
                    alarmTime = new DateTime(alarmTime.Year, alarmTime.Month, alarmTime.Day, alarmTime.Hour,
                        (alarmTime.Minute) + newMinute, newSeconds);
                    alarmTimeDisplay.Text = alarmTime.ToLongTimeString();
                    alarmLabel.Visible = true;
                    alarmTimeDisplay.Visible = true;
                    bwAlarm.RunWorkerAsync();
                }
            }
        }

        // Adds an appointment to the appointment book
        private void addAppointment_Click(object sender, EventArgs e)
        {
            // Add the items into their own lists/array
            // When an item is highlighted in the list box, display the information again on the boxes on left
            if (string.IsNullOrEmpty(nameTextbox.Text))
            {
                MessageBox.Show("Please enter a name for your appointment. ");
            }
            else
            {
                dates.Add(dateTimePicker1.Value);
                times.Add(dateTimePicker2.Value);
                comments.Add(commentBox.Text);
                aptBook.Items.Add(nameTextbox.Text);
                numAppointments++;
            } 
        }

        // Displays appointment information of the selected person
        private void aptBook_Click(object sender, EventArgs e)
        {
            int index = aptBook.SelectedIndex;

            if(aptBook.SelectedItem != null)
            {
                dateTimePicker1.Value = dates[index];
                dateTimePicker2.Value = times[index];
                nameTextbox.Text = aptBook.Text;
                commentBox.Text = comments[index];
            }
        }

        // Deletes a selected appointment
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (aptBook.SelectedItem == null)
            {
                MessageBox.Show("Please select a name in the appointment book to delete. ");
            }
            else
            {
                int index = aptBook.SelectedIndex;
                aptBook.Items.RemoveAt(index);
                dates.RemoveAt(index);
                times.RemoveAt(index);
                if (reminders[index] != null)
                {
                    reminders.RemoveAt(index);
                }
            }
        }

        // Edits selected appointment with new information
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (aptBook.SelectedItem == null)
            {
                MessageBox.Show("Please select a name in the appointment book to edit the appointment. ");
            }
            else
            {
                int index = aptBook.SelectedIndex;
                dates[index] = dateTimePicker1.Value;
                times[index] = dateTimePicker2.Value;
                comments[index] = commentBox.Text;
                aptBook.Items.RemoveAt(index);
                aptBook.Items.Insert(index, nameTextbox.Text);
            }
        }

        // Adds a reminder to the selected appointment
        private void btnReminder_Click(object sender, EventArgs e)
        {
            if (aptBook.SelectedItem == null)
            {
                MessageBox.Show("Please select a name in the appointment book to add a reminder for. ");
            }
            else
            {
                int index = aptBook.SelectedIndex;
                AlarmSetDialog dlg = new AlarmSetDialog();
                DialogResult dr = dlg.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    reminderTime = new DateTime(dlg.Year, dlg.Month, dlg.Day, dlg.Hour, dlg.Minute, dlg.Second);
                    reminders.Insert(index, reminderTime);
                    bwReminder.RunWorkerAsync();
                }
            }       
        }
    }
}
