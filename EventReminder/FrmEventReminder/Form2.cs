using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;

namespace FrmEventReminder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=lounge;Integrated Security=True");
        string event_date, event_time, event_remind, event_description, flight_No = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkEvent();
        }

        int d;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void checkEvent()
        {
            string date = DateTime.Now.Date.ToString();
            string[] time = DateTime.Now.ToString("HH:mm ").Split(':');
            string[] date1 = DateTime.Now.Date.ToString().Split(' ');
            string query = "select event_date,event_time,event_remind,event_description,flight_No from Event_Reminder where event_date='" + date1[0] + "'";
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                event_date = reader.GetString(0);
                event_time = reader.GetString(1);
                event_remind = reader.GetString(2);
                event_description = reader.GetString(3);
                flight_No = reader.GetString(4);
            }
            reader.Close();
            conn.Close();
            if (event_time != null)
            {
                string[] splitTime = event_time.Split(':');
                int f = Convert.ToInt32(splitTime[1]);
                f += Convert.ToInt32(splitTime[0]) * 60;
                int g = Convert.ToInt32(time[1]);
                g += Convert.ToInt32(time[0]) * 60;

                string[] reminesplit = event_remind.Split(' ');
                string remineValue = reminesplit[1]; //+ " " + reminesplit[2];
                String remineValue1 = event_remind;
                if (remineValue == "mins")
                {
                    d = Convert.ToInt32(reminesplit[0]);
                }
                else if (remineValue == "hours" || remineValue == "hour")
                {
                    d = Convert.ToInt32(reminesplit[0]) * 60;
                }
              /*  else if (remineValue == "days" || remineValue == "day")
                {
                    d = Convert.ToInt32(reminesplit[0]) * 60 * 24;
                }
                else if (remineValue == "weeks")
                {
                    d = Convert.ToInt32(reminesplit[0]) * 60 * 24 * 7;
                }*/
                else if (remineValue1 == "On time" )
                {
                    d = 0;                                        
                };
               
                if ((f - d) == g)
                {
                   //// MessageBox.Show("you have an event on "+event_time+" for flight "+flight_No);
                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.Volume = 100;  // 0...100
                    synthesizer.Rate = -2;     // -10...10

                    // Synchronous
                   //// synthesizer.Speak("you have an event on " + event_time + " for flight " + flight_No);

                    // Asynchronous
                    synthesizer.SpeakAsync("you have an event on " + event_time + " for flight " + flight_No);
                    //MessageBox.Show((f - g).ToString());
                    //MessageBox.Show(d.ToString());
                }
               
            }

        }
    }
}
