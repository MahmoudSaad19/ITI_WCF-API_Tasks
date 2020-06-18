using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppConsumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FillEmployeesDataToGridView();
        }

        private void FillEmployeesDataToGridView()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("Application/json"));
            client.BaseAddress = new Uri("http://localhost/apihost/");
            var result = client.GetAsync("api/employee").Result;
            if(result.IsSuccessStatusCode)
            {
                var msg = result.Content.ReadAsAsync<List<EmployeeResultModel>>().Result;
                dataGridView1.DataSource = msg;
                label1.Text = "Success";
            }
            else
            {
                label1.Text = "Error";
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/apihost/");
            EmployeeResultModel employee = new EmployeeResultModel()
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Salary = int.Parse(txtSal.Text),
                DeptID = int.Parse(txtDeptId.Text)
            };

            var result = client.PostAsJsonAsync("api/employee", employee).Result;
            if(result.IsSuccessStatusCode)
            {
                label1.Text = "Added Successfully";
            }
            else
            {
                label1.Text = "Entry Error ";
            }
        }
    }
}
