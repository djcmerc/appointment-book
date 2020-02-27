using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5
{
    public partial class AlarmSetDialog : Form
    {
        public AlarmSetDialog()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public int Month
        {
            get { return (int)datePicker.Value.Month; }
        }

        public int Day
        {
            get { return (int)datePicker.Value.Day; }
            //set { numericUpDownWidth.Value = value; }
        }

        public int Year
        {
            get { return (int)datePicker.Value.Year; }
            //set { numericUpDownWidth.Value = value; }
        }

        public int Hour
        {
            get { return (int)timePicker.Value.Hour; }
            //set { numericUpDownWidth.Value = value; }
        }

        public int Minute
        {
            get { return (int)timePicker.Value.Minute; }
            //set { numericUpDownWidth.Value = value; }
        }

        public int Second
        {
            get { return (int)timePicker.Value.Second; }
            //set { numericUpDownWidth.Value = value; }
        }

    }
}
