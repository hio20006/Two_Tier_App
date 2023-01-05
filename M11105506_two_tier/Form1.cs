using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11105506_two_tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'function_51.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter2.Fill(this.function_51.List);
            // TODO: 這行程式碼會將資料載入 'function_5.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter1.Fill(this.function_5.DataTable1);
            // TODO: 這行程式碼會將資料載入 'function_41.site_info_3' 資料表。您可以視需要進行移動或移除。
            this.site_info_3TableAdapter.Fill(this.function_41.site_info_3);
            // TODO: 這行程式碼會將資料載入 'function_41.site_info_2' 資料表。您可以視需要進行移動或移除。
            this.site_info_2TableAdapter.Fill(this.function_41.site_info_2);
            // TODO: 這行程式碼會將資料載入 'function_41.List_1' 資料表。您可以視需要進行移動或移除。
            this.list_1TableAdapter.Fill(this.function_41.List_1);
            // TODO: 這行程式碼會將資料載入 'function_3.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter1.Fill(this.function_3.List);
            // TODO: 這行程式碼會將資料載入 'function_3.system_info' 資料表。您可以視需要進行移動或移除。
            this.system_infoTableAdapter1.Fill(this.function_3.system_info);
            // TODO: 這行程式碼會將資料載入 'function_3.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter1.Fill(this.function_3.List);
            // TODO: 這行程式碼會將資料載入 'function_3.system_info' 資料表。您可以視需要進行移動或移除。
            this.system_infoTableAdapter1.Fill(this.function_3.system_info);
            // TODO: 這行程式碼會將資料載入 'function_3.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter1.Fill(this.function_3.List);
            // TODO: 這行程式碼會將資料載入 'function_3.system_info' 資料表。您可以視需要進行移動或移除。
            this.system_infoTableAdapter1.Fill(this.function_3.system_info);
            // TODO: 這行程式碼會將資料載入 'function_3.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter1.Fill(this.function_3.List);
            // TODO: 這行程式碼會將資料載入 'function_3.system_info' 資料表。您可以視需要進行移動或移除。
            this.system_infoTableAdapter1.Fill(this.function_3.system_info);
            // TODO: 這行程式碼會將資料載入 'function_2.List' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter.Fill(this.function_2.List);
            // TODO: 這行程式碼會將資料載入 'function_2.system_info' 資料表。您可以視需要進行移動或移除。
            this.system_infoTableAdapter.Fill(this.function_2.system_info);
            // TODO: 這行程式碼會將資料載入 'function_1.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.function_1.DataTable1);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter1.FillBy(this.function_5.DataTable1, new System.Nullable<int>(((int)(System.Convert.ChangeType(minToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(maxToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable1TableAdapter1.FillBy(this.function_5.DataTable1, new System.Nullable<int>(((int)(System.Convert.ChangeType(minToolStripTextBox1.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(maxToolStripTextBox1.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(listToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
