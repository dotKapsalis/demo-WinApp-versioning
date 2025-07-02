using demoTool.Desktop.Mappers;
using demoTool.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoTool.Desktop
{
    public partial class Form1 : Form
    {
        private readonly IDataService _dataService;

        public Form1()
        {
            InitializeComponent();

            _dataService = new ApiDataService(new System.Net.Http.HttpClient());

            button1.Click += Button1_Click;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            await FetchDataAsync();
        }

        public async Task FetchDataAsync()
        {
            try
            {
                var items = await _dataService.FetchDataAsync();
                // datagridView1.DataSource = DataTableMapper.ToDataTable(items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
