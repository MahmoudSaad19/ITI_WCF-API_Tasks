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
            client.BaseAddress = new Uri("http://localhost/apihost");
            var result = client.GetAsync("api/employee").Result;
            var msg = result.Content.ReadAsAsync<List<EmployeeResultModel>>().Result;
            dataGridView1.DataSource = msg;
        }
    }
}
