using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllClasses;
using System.Data.SqlClient;
using System.Data;

namespace ReadFromDatabaseApp
{
    public partial class SearchUserControl : UserControl
    {
        public string command { get; set; }

        public DataGridView TargetView;

        public Action<DataTable> OnAction;
        public SearchUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] data = {FTextBox.Text, LTextBox.Text, IDTextBox.Text };
            SearchClass search = new SearchClass(data);
            
            if (TargetView != null)
            {
                search.ShowResults(TargetView);
            }

            else if (OnAction != null)
            {
                OnAction.Invoke(search.ShowResults());
            }

            //command = search.command;
            //MessageBox.Show("COMMAND AT THE END" + command);

        }

        private void SearchUserControl_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] data = { FTextBox.Text, LTextBox.Text, IDTextBox.Text };
            AddClass addData = new AddClass(data);
            if (TargetView != null)
            {
                addData.AddData(TargetView);
            }


        }
    }
}
