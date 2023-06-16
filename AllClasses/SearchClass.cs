using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AllClasses
{
    public  class SearchClass : IOptimize
    {
        private string[] userData { get; set; }

        public string command { get; set; } = "SELECT * FROM dbo.UserInfo ";
        public SearchClass(string[] info) {
            userData = info;
            
        }


        public string[] InitializeCurrentData(string[] data) { 
        data[0].Trim();
            data[1].Trim();
            data[2].Trim();
            return data;
        }

        public void ShowResults(DataGridView dataTable)
        { 
        userData = InitializeCurrentData(userData);
            string[] OptimizedUserData = OptimizeSearch();
          
            string connectionString = @"Server =.\SQL_2019; Database = Efim1; Integrated Security = true";
            using (SqlConnection sCon = new SqlConnection(connectionString))
            {
                sCon.Open();
                
                SqlDataAdapter adapter = new SqlDataAdapter(command, sCon);
                DataTable dataList = new DataTable();
                adapter.Fill(dataList);
               
                dataTable.AutoGenerateColumns = false;
                dataTable.DataSource = dataList;
                
            }
            
            MessageBox.Show(command);
            command = "SELECT * FROM dbo.UserInfo ";
            
        }

        public DataTable ShowResults()
        {
            userData = InitializeCurrentData(userData);
            string[] OptimizedUserData = OptimizeSearch();

            string connectionString = @"Server =.\SQL_2019; Database = Efim1; Integrated Security = true";
            using (SqlConnection sCon = new SqlConnection(connectionString))
            {
                sCon.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command, sCon);
                DataTable dataList = new DataTable();
                adapter.Fill(dataList);
                
                return dataList;

            }

            

        }

        private string[] OptimizeSearch() {
            int len = 0;
            bool f = false;//to know which is empty
            bool s = false;
            bool t = false;
            //bool f, s, t = false; doesnt work
            

            if (userData[0] == "")
            { }
            else { 
                len++; 
                f = true;
                command += $"WHERE Name = '{userData[0]}'";
            }

            if (userData[1] == "")
            { }
            else { 
                len++; 
                s = true;
                if (!(command[command.Length - 1] == ' '))
                {
                    command += $" AND LastName = '{userData[1]}'";
                }
                else if (command[command.Length - 1] == ' ')
                {
                    command += $"WHERE LastName = '{userData[1]}'";

                }
            }

            if (userData[2] == "")
            { }
            else { 
                len++; 
                t = true;
                if (!(command[command.Length - 1] == ' '))
                {
                    command += $" AND id = '{userData[2]}'";
                }
                else if (command[command.Length - 1] == ' ')
                {
                    command += $"WHERE id = '{userData[2]}'";

                }
            }

            List<string> tempData = new List<string> { };//creating Optimized data

            if (f)
            {
                tempData.Add(userData[0]);
            }
            if (s)
            {
                tempData.Add(userData[1]);
            }
            if (t)
            {
                tempData.Add(userData[2]);
            }
            
            return tempData.ToArray();
        }
    
    
    
   
    }
}
