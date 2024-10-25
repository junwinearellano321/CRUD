using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Eniwnuj
{
    public partial class Form1 : Form
    {
        private List<User> users;
        private DataTable userTable;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            SetupDataGridView();
        }

        private void LoadData()
        {

            users = new List<User>
            {
                new User { FirstName = "John", LastName = "Doe", meddlename = "M.", Age = 30, rent = DateTime.Now.AddDays(-5), back = DateTime.Now.AddDays(5) },
                new User { FirstName = "Jane", LastName = "Smith", meddlename = "A.", Age = 25, rent = DateTime.Now.AddDays(-3), back = DateTime.Now.AddDays(3) },

            };
        }

        private void SetupDataGridView()
        {
            userTable = new DataTable();

         
            userTable.Columns.Add("ID", typeof(int));
            userTable.Columns.Add("First Name");
            userTable.Columns.Add("Last Name");
            userTable.Columns.Add("Middle Name");
            userTable.Columns.Add("Age", typeof(int));
            userTable.Columns.Add("Date of Rent", typeof(DateTime));
            userTable.Columns.Add("Date of Return", typeof(DateTime));

       
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                userTable.Rows.Add(i, user.FirstName, user.LastName, user.meddlename, user.Age, user.rent, user.back);
            }

            dataGridView1.DataSource = userTable;

           
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = Box1.Text;
            string lastName = Box2.Text;
            string middleName = Box3.Text;

            int Age = (int)age.Value;
            DateTime rent = dateTimePicker1.Value;
            DateTime back = dateTimePicker2.Value;

            if (!string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(lastName) &&
                !string.IsNullOrWhiteSpace(middleName) &&
                Age > 0)
            {
              
                int newId = userTable.Rows.Count;

             
                userTable.Rows.Add(newId, firstName, lastName, middleName, Age, rent, back);

         
                dataGridView1.DataSource = userTable;

     
                Box1.Clear();
                Box2.Clear();
                Box3.Clear();
                age.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Please fill in all fields correctly.");
            }
        }



        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string meddlename { get; set; }
            public int Age { get; set; }
            public DateTime rent { get; set; }
            public DateTime back { get; set; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = sear.Text.ToLower();
            DataView dv = userTable.DefaultView;

      
            dv.RowFilter = string.Format(
                "Convert([First Name], 'System.String') LIKE '%{0}%' OR Convert([Last Name], 'System.String') LIKE '%{0}%'",
                searchTerm);

            dataGridView1.DataSource = dv.ToTable();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                
                    int originalId = (int)row.Cells["ID"].Value;

                
                    DataRow[] rowsToDelete = userTable.Select("ID = " + originalId);
                    foreach (DataRow rowToDelete in rowsToDelete)
                    {
                        userTable.Rows.Remove(rowToDelete);
                       
                        sear.Clear();
                        string searchTerm = sear.Text.ToLower();
                        DataView dv = userTable.DefaultView;
                        dv.RowFilter = string.Format(
              "Convert([First Name], 'System.String') LIKE '%{0}%' OR Convert([Last Name], 'System.String') LIKE '%{0}%'",
              searchTerm);
                        dataGridView1.DataSource = dv.ToTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

    }
}
