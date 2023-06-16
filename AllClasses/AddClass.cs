using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllClasses
{
    public class AddClass : IOptimize
    {
        private string[] newUserData { get; set; }
        private string command { get; set; } = "INSERT INTO dbo.UserInfo (";
        
        public AddClass(string[] info)
        {
            newUserData = info;
            newUserData = InitializeCurrentData(newUserData);
            
        }

        public void AddData(DataGridView data) {
            CreateAddCommand();
            string connectionString = @"Server =.\SQL_2019; Database = Efim1; Integrated Security = true";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            { 
            sqlCon.Open();


                SqlCommand cmd = new SqlCommand(command, sqlCon);
                cmd.ExecuteNonQuery();

                //SqlDataAdapter adapter = new SqlDataAdapter(command, sqlCon);
                //DataTable dT = new DataTable();
                //adapter.Fill(dT);
                //data.AutoGenerateColumns = true;
                //data.DataSource = dT;

            }

        }



        private void CreateAddCommand() {
            bool f = false;
            bool s = false;
            newUserData = InitializeCurrentData(newUserData);
            //Cannot do the id thing, since it is made automatically by SQL database

            //Checking whether LastName and FirstNames were added
            if (newUserData[0] == "") { }
            else {
                f = true;
                command += "Name";
                
            }
            if (newUserData[1] == "") { }
            else
            {
                if (!(command[command.Length - 1] == '('))
                {
                    s = true;
                    command += ", LastName)";
                    
                }
            }
            


            //Adding Values
            if (f&s)
            {
                command += $"\n VALUES ('{newUserData[0]}', '{newUserData[1]}')";
            }
            MessageBox.Show(command);

        }

        public string[] InitializeCurrentData (string[] data)
        {
            data[0].Trim();
            data[1].Trim();
            data[2].Trim();
            return data;
        }

    }
}
