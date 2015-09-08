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

        delegate void SetTextCallback(string text);

        // INIT NEW PERSON
        Person user;

        // INIT WORK THREAD
        Thread work_Thread;

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

            // init work_Thread
            //work_Thread = new Thread(timer_Run);

            // start stopwatch
            user.Elapsed_time.Start();

            // init data
            int current_time = (int)user.Elapsed_time.ElapsedMilliseconds;
            string output_str = user.Elapsed_time.Elapsed.Hours.ToString() + ":" + user.Elapsed_time.Elapsed.Minutes.ToString() + user.Elapsed_time.Elapsed.Seconds.ToString() + " until break";

            //while (current_time < 1000)
            //{
            //    time_till_break_label.Text = output_str;
            //    //this.time_till_break_label.SetText(output_str);
            //    //Thread.Sleep(1000);

            //    // update data
            //    current_time = (int)user.Elapsed_time.ElapsedMilliseconds;
            //    output_str = user.Elapsed_time.Elapsed.Hours.ToString() + ":" + user.Elapsed_time.Elapsed.Minutes.ToString() + user.Elapsed_time.Elapsed.Seconds.ToString() + " until break";
            //}

            timer_Run();

            //// start work_Thread
            //work_Thread.Start();

            //// break time! we have to reset everything
            work_button.Enabled = true;
            //user.Elapsed_time.Reset();
        }

        private void timer_Run()
        {
            // init data
            int current_time = (int)user.Elapsed_time.ElapsedMilliseconds;
            string output_str = user.Elapsed_time.Elapsed.Hours.ToString() + ":" + user.Elapsed_time.Elapsed.Minutes.ToString() + user.Elapsed_time.Elapsed.Seconds.ToString() + " until break";

            while (user.Work_time_msecs > current_time)
            {
                //System.Windows.Forms.MessageBox.Show(output_str);
                this.SetText(output_str);
                //Thread.Sleep(1);

                // update data
                current_time = (int)user.Elapsed_time.ElapsedMilliseconds;
                output_str = user.Elapsed_time.Elapsed.Hours.ToString() + ":" + user.Elapsed_time.Elapsed.Minutes.ToString() + user.Elapsed_time.Elapsed.Seconds.ToString() + " until break";
            }
        }

        private void SetText(string s)
        {
            // ADAPTED FROM MSDN How to: Make Thread-Safe Calls to Windows Forms Controls
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.time_till_break_label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { s });
            }
            else
            {
                this.time_till_break_label.Text = s;
            }
        }

        
    }
}
