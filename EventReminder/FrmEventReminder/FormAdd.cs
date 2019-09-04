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
using System.IO;

namespace FrmEventReminder
{
    public partial class FormAdd : Form
    {

       // SqlConnection conn = new SqlConnection("Data Source=ERANDI-IT\\SQLEXPRESS;Initial Catalog=lounge;User ID=sa;Password=sa123");
          SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5I851K6;Initial Catalog=lounge;Persist Security Info=True;User ID=sa;Password=sa123");
        EventClass EC = new EventClass();
        string Fno, EventDes, EventTime, EventDate, RemainDefault, remain,val = "";
        string query_load = "select flight_No,event_description,event_date,event_time,event_id from Event_Reminder1";
        int row,rowIndex=0;
        public static int Eid = 0;
        string[] date1 = DateTime.Now.Date.ToString().Split(' ');
        

        public FormAdd()
        {
            InitializeComponent();
           
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtNum.Visible = false;
            cmbCustomize.Visible = false;
            load(query_load);

        }

        private void dtpTime_FormatChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFlightNo.Text == "" || txtEvent.Text == "")
            {
                MessageBox.Show("Some fields are empty");
            }
            else
            {
                Fno = txtFlightNo.Text;
                EventDes = txtEvent.Text;
                EventTime = dtpTime.Text;
                EventDate = dtpdate.Text;
                RemainDefault = cmbdefault.SelectedItem.ToString();
                StringBuilder sb = new StringBuilder(EventTime);
                sb[2] = (' ');
                EventTime = sb.ToString();

                if (RemainDefault=="Customize")
                {
                    remain = txtNum.Text + " " + cmbCustomize.SelectedItem.ToString();
                }
                else
                {
                    remain=RemainDefault;
                }

                string query = "insert into Event_Reminder1(flight_No,event_description,event_date,EventTime,event_remind,event_status) values('" + Fno + "','" + EventDes + "','" + EventDate + "','" + EventTime + "','" + remain + "','" + RemainDefault + "')";
                if (EC.Save_Update_DeleteEvent(query) == true)
                {
                    MessageBox.Show("Event is added successfully");
                    Clear();
                    dgwEventList.DataSource = null;
                    load(query_load);
                }
                else
                {
                    MessageBox.Show("try again");
                }
            }
        }

        private void cmbdefault_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Check = cmbdefault.SelectedItem.ToString();
            if (Check == "Customize")
            {
               txtNum.Visible = true;
               cmbCustomize.Visible = true;
            }
            else
            {
                txtNum.Visible = false;
                cmbCustomize.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Fno = txtFlightNo.Text;
            EventDes = txtEvent.Text;
            EventTime = dtpTime.Text;
            EventDate = dtpdate.Text;
            RemainDefault = cmbdefault.SelectedItem.ToString();

            if (RemainDefault == "Customize")
            {
                remain = txtNum.Text + " " + cmbCustomize.SelectedItem.ToString();
            }
            else
            {
                remain = RemainDefault;
            }
            string query = "update Event_Reminder1 set flight_No='" + Fno + "',event_description='" + EventDes + "',event_date='" + EventDate + "',event_time='" + EventTime + "',event_remind='" + remain + "',event_status='" + RemainDefault + "' where event_id=" + Eid + "";
            if (EC.Save_Update_DeleteEvent(query) == true)
            {
                MessageBox.Show("Event is updated successfully");
                Clear();
                dgwEventList.DataSource = null;
                load(query_load);
            }
            else
            {
                MessageBox.Show("try again");
            }
        }

    

    private void dgwEventList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
          
        }

        private void dgwEventList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dgwEventList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                row = dgwEventList.CurrentCell.RowIndex;
                if (e.Button == MouseButtons.Right)
                {
                    rowIndex = e.RowIndex;
                    Eid = Convert.ToInt32(dgwEventList.Rows[e.RowIndex].Cells[4].Value);
                    cmsDgwEvent.Show(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                }
            }
            else
            { 
                
            }
            
        }

        public void load(string query)
        {
            try
            {
                SqlDataAdapter dataadapter = new SqlDataAdapter(query, conn);
                DataTable ds = new DataTable();
                dataadapter.Fill(ds);
                dgwEventList.AutoGenerateColumns = false;
                dgwEventList.ColumnCount = 5;
                dgwEventList.Columns[0].HeaderText = "Flight Number";
                dgwEventList.Columns[0].DataPropertyName = "flight_No";
                dgwEventList.Columns[1].HeaderText = "Event";
                dgwEventList.Columns[1].DataPropertyName = "event_description";
                dgwEventList.Columns[2].HeaderText = "Date";
                dgwEventList.Columns[2].DataPropertyName = "event_date";
                dgwEventList.Columns[3].HeaderText = "Time";
                dgwEventList.Columns[3].DataPropertyName = "event_time";
                dgwEventList.Columns[4].DataPropertyName = "event_id";
                dgwEventList.Columns[4].Visible = false;

                dgwEventList.DataSource = ds;

            }

            catch (Exception)
            {
            }

        }

        private void UpdatetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            fill();
        }

        public void Clear()
        {
            txtFlightNo.Text = "";
            txtEvent.Text = "";
            txtNum.Text = "";
            dtpdate.Text = "";
            dtpTime.Text = "";
            cmbdefault.Text= " ";
            cmbCustomize.Text = "";
        }

        public void fill()
        {
            string query = "select flight_No,event_description,event_date,event_time,event_id,event_status,event_remind from Event_Reminder1 where event_id=" + Eid + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtFlightNo.Text = reader.GetString(0);
                txtEvent.Text = reader.GetString(1);
                dtpdate.Text = reader.GetString(2);
                dtpTime.Text = reader.GetString(3);
                cmbdefault.Text = reader.GetString(5);
                val = reader.GetString(6);
             }
            if (cmbdefault.Text == "Customize")
            {
               // Regex re = new Regex(@"(\d+)([a-zA-Z]+)");
                //Match result;
               // result = re.Match(val);
               // string[] splitTime = val.Split(' ');
               // cmbCustomize.Text = result.Groups[2].Value;
                //txtNum.Text = result.Groups[1].Value;
                string[] reminesplit = val.Split(' ');
                cmbCustomize.Text = reminesplit[1] +" "+ reminesplit[2];
                txtNum.Text = reminesplit[0];

                // MessageBox.Show(reader.GetString(6));
            }
            else
            {
                //cmbdefault.Text = reader.GetString(5);
            }
            reader.Close();
            conn.Close();
        }
       

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            fill();
            DialogResult res = MessageBox.Show("Do you really want to delete this event?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string query = "delete Event_Reminder1 where event_id=" + Eid + "";
                if (EC.Save_Update_DeleteEvent(query) == true)
                {
                    MessageBox.Show("Event is deleted successfully");
                    dgwEventList.Rows.RemoveAt(row);
                    Clear();
                }
                else
                {
                    MessageBox.Show("try again");
                }

            }
            else
            { 
            
            }
        }


        //private void cmbdefault_SelectedIndexChanged()
        //{

        //}
        //protected void Displaynotify()
        //{
        //    //fullFileName = new List<String>(openFileDialog1.FileNames);
        //    ////string Path;
        //    //foreach (string fileName in fullFileName)
        //    //{
        //    //    //Path = fileName;
        //    //}
        //    try
        //    {
        //        notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"Downloads\notification.ico"));
        //        notifyIcon1.Text = "Export Datatable Utlity";
        //        notifyIcon1.Visible = true;
        //        notifyIcon1.BalloonTipTitle = "Welcome Devesh omar to Datatable Export Utlity";
        //        notifyIcon1.BalloonTipText = "Click Here to see details";
        //        notifyIcon1.ShowBalloonTip(100);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}  
            
    }
}
