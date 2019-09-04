using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.ServiceProcess;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace EventService
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();


        //SqlConnection conn = new SqlConnection("Data Source=ERANDI-IT\\SQLEXPRESS;Initial Catalog=lounge;User ID=sa;Password=sa123");
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5I851K6;Initial Catalog=Lounge_Mgt;Persist Security Info=True;User ID=sa;Password=sa123");
        string event_date, x, input, event_time, event_remind, event_description,date,flight_No,Eventstatus;
        string[] time;
        Thread _thread;
        int d,z=0, Eventid;
        SqlDataReader reader;
        
        public Service1()
        {
            InitializeComponent();
           
        }

        public void OnElapsedTime(object source, ElapsedEventArgs e)
        {
          
            date = DateTime.Now.Date.ToString();
             time = DateTime.Now.ToString("HH:mm ").Split(':');
            string[] date1 = DateTime.Now.Date.ToString().Split(' ');
             
            conn.Open();                
            SqlDataAdapter sda = new SqlDataAdapter("select event_date,event_time,event_remind,event_description,flight_No,event_id,event_status from Event_Reminder1 where event_date='" + date1[0] + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            foreach(DataRow dr in dt.Rows)
            {
                event_date = dr[0].ToString();
                event_time = dr[1].ToString();
                event_remind = dr[2].ToString();
                event_description = dr[3].ToString();
                flight_No = dr[4].ToString();
                Eventid = Convert.ToInt32(dr[5]);
                Eventstatus = dr[6].ToString();
                checkeventtime();
        }
         
        }

        public void checkeventtime()
        {
            if (event_time != null)
            {
                string[] splitTime = event_time.Split(':');
                int f = Convert.ToInt32(splitTime[1]);
                f += Convert.ToInt32(splitTime[0]) * 60;
                int g = Convert.ToInt32(time[1]);
                g += Convert.ToInt32(time[0]) * 60;

                string[] reminesplit = event_remind.Split(' ');
                string remineValue = reminesplit[1]; //+ " " + reminesplit[2];
                string remineValue1 = event_remind;
                if (remineValue == "mins")
                {
                    d = Convert.ToInt32(reminesplit[0]);
                }
                else if (remineValue == "hours" || remineValue == "hour")
                {
                    d = Convert.ToInt32(reminesplit[0]) * 60;
                }
                else if (remineValue1 == "On time")
                {
                    d = 0;
                }

                if ((f - d) == g)
                {
                    reader_Speak();

                }
            }
        }
        public void reader_Speak()
        {

            if (Eventstatus != "Complete")
            {              
                string Stime = Edit_time(event_time);
                string Speech = "you have an " + event_description + "  AT " + Stime + " for flight" + flight_No;
                for (z = 0; z < 3; z++)
                {
                    synthesizer.Volume = 100;  // 0...100
                    synthesizer.Rate = -3;     // -10...10       
                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    synthesizer.SpeakAsync(Speech);
                    if (z == 2)
                    {
                        String query2 = "update Event_Reminder1 set event_status='Complete' where event_id = " + Eventid + " ";
                        eventcomplete(query2);
                        Eventstatus = "Complete";
                        Checkevent();
                    }
                }
            }
        }
                            
        public void eventcomplete(String queryy)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryy,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

       

        public String Edit_time(String editt)
        {
            
            StringBuilder sb = new StringBuilder(editt);
            sb[2] = (' ');
            editt = sb.ToString();
            if (sb[0] == ('0'))
            {
                sb[0] = (' ');
                editt = sb.ToString();
            }
            else
            {
                sb[0] = sb[0];
                editt = sb.ToString();
            }

            if (sb[3] == ('0'))
            {
                sb[3] = (' ');
                editt = sb.ToString();
            }
            else
            {
                sb[3] = sb[3];
                editt = sb.ToString();
            }
            return editt;
        }

        public void Checkevent()
        {
            try
            {               
                timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
                timer.Interval = 1000;
                timer.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        protected override void OnStart(string[] args)
        {
            try
            {
                
                 _thread = new Thread(Checkevent);

                // Start the thread.
                _thread.Start();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected override void OnStop()
        {
            timer.Stop();
           
        }
    }
}
