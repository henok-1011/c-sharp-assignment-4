using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Name_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                count = Convert.ToInt32(txt_count.Text),
                price = Convert.ToInt32(txt_price.Text),
                ObjectName = txt_objectName.Text,
                InvetoryNumber = txt_InventoryNum.Text,
                Date = dtp_date.Text,
                ProductID = Convert.ToInt32(txt_IdNum.Text)
            };
            
            MessageBox.Show("product added successfuly");
            
        }

        private void btn_Name_MouseHover(object sender, EventArgs e)
        {
            //btn_Name.Location()
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_count.Text = "";
            txt_IdNum.Text = "";
            txt_InventoryNum.Text = "";
            txt_objectName.Text = "";
            txt_price.Text = "";
            dtp_date.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void txt_InventoryNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
