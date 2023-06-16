using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AllClasses;
using System.Data.SqlClient;

namespace ReadFromDatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            
        }
        
        private void SendBtn_Click(object sender, EventArgs e)
        {
            
            Boolean stop = false;

            SearchUserControl a = new SearchUserControl();
            var timer = new AllClasses.ElapseCalculator();
            string connectionInfo = @"Server=.\SQL_2019;Database=Efim1;Integrated Security=true;";
            string command = a.command;
            MessageBox.Show("Main Form - " + command);
            using (SqlConnection sqlCon = new SqlConnection(connectionInfo))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM dbo.UserInfo", sqlCon);  
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);



                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = dataTable;
                
                AllClasses.ElapseCalculator.watch.Stop();
                TimerLabel.Visible = true;
                TimerLabel.Text = String.Format("{0:00}:{1:00}:{2:000}", AllClasses.ElapseCalculator.watch.Elapsed.Minutes, AllClasses.ElapseCalculator.watch.Elapsed.Seconds
                        , AllClasses.ElapseCalculator.watch.Elapsed.Milliseconds);
                
                
            }
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //this.userInfoTableAdapter.Fill(this.efim1DataSet.UserInfo);
            SearchUserControl searchOption = new SearchUserControl();
            OptionsPanel.Controls.Add(searchOption);
            searchOption.BringToFront();
            searchOption.Dock = DockStyle.Fill;

            searchOption.TargetView = dataGrid;// can uncomment but unnecessary works for the first showresult method

            //searchOption.Hide();

            searchOption.OnAction = (x) => dataGrid.DataSource = x;
            //{
            //    dataGrid.DataSource = x;
            //};

            //searchOption.OnAction = CallBack;

        }
        /*
        private void CallBack (DataTable x)
        {
            dataGrid.DataSource = x;
        }
        */
        private void OptionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] info= { "Efim", "", "" };
            
            SearchClass a = new SearchClass(info);
            a.ShowResults(dataGrid);
            
        }
    }
}
