using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FrmEventReminder
{
    class EventClass
    {


        //SqlConnection conn = new SqlConnection("Data Source=ERANDI-IT\\SQLEXPRESS;Initial Catalog=lounge;User ID=sa;Password=sa123");
        SqlConnection conn = new SqlConnection("Data Source=desktop-5i851k6;Initial Catalog=lounge;Persist Security Info=True;User ID=sa;Password=sa123");

        public bool Save_Update_DeleteEvent(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rows= cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
       
        
    }
}
