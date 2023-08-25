using eGym.BLL.Models;
using eGym.BLL.Models.Enums;
using eGym.BLL.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eGym.UI.Desktop
{
    public partial class frmService : Form
    {
        private readonly APIService _service = new APIService("Service");
        List<ServiceDTO> services= new List<ServiceDTO>();
        ServiceDTO serviceDTO = new ServiceDTO();
        
        bool ValidationInput1 = false, ValidationInput2 = false, ValidationInput3 = false;
        public frmService()
        {
            InitializeComponent();
        }

        private async void frmService_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private async void Reload()
        {
            services = await _service.Get<List<ServiceDTO>>(null, "/getAll");
            dataGridView1.DataSource = services;
            dataGridView1.Columns["Descritption"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["ServiceId"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            serviceDTO = services[index];

            richTextBox1.Text = serviceDTO.Descritption;
            textBox1.Text = serviceDTO.Picture;
            textBox2.Text = serviceDTO.Title;

            buttonDelete.Visible = true;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await _service.Delete(new { id = serviceDTO.ServiceId });
            richTextBox1.Text = textBox1.Text = textBox2.Text = "";
            serviceDTO=new ServiceDTO();
            buttonDelete.Visible = false;
            Reload();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.BackColor = SystemColors.Window;
                textBox1.ForeColor = SystemColors.WindowText;
                textBox1.BorderStyle = BorderStyle.FixedSingle;
                ValidationInput1 = false;
            }
            else
            {
                textBox1.BackColor = Color.LightPink;
                textBox1.ForeColor = Color.Red;
                textBox1.BorderStyle = BorderStyle.Fixed3D;
                ValidationInput1 = true;
            }

            if (textBox2.Text != "")
            {
                textBox2.BackColor = SystemColors.Window;
                textBox2.ForeColor = SystemColors.WindowText;
                textBox2.BorderStyle = BorderStyle.FixedSingle;
                ValidationInput2 = false;
            }
            else
            {
                textBox2.BackColor = Color.LightPink;
                textBox2.ForeColor = Color.Red;
                textBox2.BorderStyle = BorderStyle.Fixed3D;
                ValidationInput2 = true;
            }

            if (richTextBox1.Text != "")
            {
                richTextBox1.BackColor = SystemColors.Window;
                richTextBox1.ForeColor = SystemColors.WindowText;
                richTextBox1.BorderStyle = BorderStyle.FixedSingle;
                ValidationInput3 = false;
            }
            else
            {
                richTextBox1.BackColor = Color.LightPink;
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.BorderStyle = BorderStyle.Fixed3D;
                ValidationInput3 = true;
            }


            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "")
            {
                var request = new UpdateServiceRequest()
                {
                    ServiceId = serviceDTO.ServiceId,
                    Title = textBox2.Text,
                    Picture = textBox1.Text,
                    Descritption = richTextBox1.Text
                };

                if (serviceDTO.ServiceId == 0)
                {
                    await _service.Post<ServiceDTO>(request);
                }
                else
                {
                    await _service.Put<ServiceDTO>(serviceDTO.ServiceId, request);
                }

                Cancel();
                Reload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            serviceDTO = new ServiceDTO();
            textBox2.Text = textBox1.Text = richTextBox1.Text = "";
            buttonDelete.Visible = false;

            textBox1.BackColor = SystemColors.Window;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            ValidationInput1 = false;
            textBox2.BackColor = SystemColors.Window;
            textBox2.ForeColor = SystemColors.WindowText;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            ValidationInput2 = false;
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.ForeColor = SystemColors.WindowText;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            ValidationInput3 = false;
        }
    }
}
