using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Planner
{
    public partial class Form1 : Form
    {
        // INIT NEW PERSON
        Person user;

        // FORM CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
            user = new Person(true, 1);
        }

        // CLICK DRINK BUTTON
        private void drink_button_Click(object sender, EventArgs e)
        {
            // takes in text in the # of cups drunk text input
            string text = drink_input_textBox.Text;
            // set up fluids float
            float fluids = 0;
            // try parsing text into float. if you can, then update amount drunk
            if (float.TryParse(text, out fluids))
            {
                user.Cups_drunk += fluids;
                fluids_meter_label.Text = user.Cups_drunk.ToString() + " / 9 cups drunk";
            }
        }

        // WORK BUTTON
        private void work_button_Click(object sender, EventArgs e)
        {
            // can't start working again during a current work session, so disable button
            work_button.Enabled = false;

            // start stopwatch
            user.Elapsed_time.Start();

            elapsed_time_backgroundWorker.RunWorkerAsync();
            // break time! we have to reset everything
            work_button.Enabled = true;
            user.Elapsed_time.Reset();

            int current_time = (int)user.Elapsed_time.ElapsedMilliseconds;
            string output_str = user.Elapsed_time.Elapsed.Hours.ToString() + ":" + user.Elapsed_time.Elapsed.Minutes.ToString() + " until break";

            while (user.Work_time_msecs > current_time)
            {
                time_till_break_label.Text = output_str;
                Thread.Sleep(1000);
            }
        }

        private void elapsed_time_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            

        }
    }
}
