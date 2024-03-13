using BusinessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_managment
{
    public partial class Form1 : Form
    {
        byte[] image_data;
        public Form1()
        {
            InitializeComponent();
        }




        private void btnBrowser_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp;)|.jpeg; *.jpg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                lblPicture.Text = Path.GetFileName(open.FileName);

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                image_data = ms.ToArray();

            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            if(lblPicture.Text != "")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                ProductClass1 product = StudentDetails();
                ProductBusiness.AddProductBusiness(product);
                MessageBox.Show("New Product Added Successfully ");
                ResetForm();
            }
            else
            {
                MessageBox.Show("Please Select Image!");
            }
            
        }


        private ProductClass1 StudentDetails()
        {
            return new ProductClass1()
            {
                senderName = senderName.Text,
                senderPhoneNo = senderPhoneNo.Text,
                senderAddress = senderAddress.Text,
                reciverName = reciverName.Text,
                reciverPhoneNo = reciverPhoneNo.Text,
                reciverAddress = reciverAddress.Text,
                productWeight = productWeight.Text,
                cost = cost.Text,
                picture = image_data
            };
        }



        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            image_data = ms.ToArray();
            ProductClass1 product = StudentDetails();
            ProductBusiness.UpdateProductBusiness(product);

            productGridView.DataSource = null;
            productGridView.DataSource = ProductBusiness.SelectAllProductBusiness();
            ResetForm();
        }


        private void ResetForm()
        {
            senderName.Clear();
            senderPhoneNo.Clear();
            senderAddress.Clear();
            reciverName.Clear();
            reciverPhoneNo.Clear();
            reciverAddress.Clear();
            productWeight.Clear();
            cost.Clear();
            pictureBox1.Image = null;
            lblPicture.Text = null;

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            senderName.Text = productGridView.SelectedRows[0].Cells[0].Value.ToString();
            senderPhoneNo.Text = productGridView.SelectedRows[0].Cells[1].Value.ToString();
            senderAddress.Text = productGridView.SelectedRows[0].Cells[2].Value.ToString();
            reciverName.Text = productGridView.SelectedRows[0].Cells[3].Value.ToString();
            reciverPhoneNo.Text = productGridView.SelectedRows[0].Cells[4].Value.ToString();
            reciverAddress.Text = productGridView.SelectedRows[0].Cells[5].Value.ToString();
            productWeight.Text = productGridView.SelectedRows[0].Cells[6].Value.ToString();
            cost.Text = productGridView.SelectedRows[0].Cells[7].Value.ToString();
            pictureBox1.Image = Image.FromStream(new MemoryStream((Byte[])productGridView.SelectedRows[0].Cells[8].Value));
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ProductClass1 product = StudentDetails();
            ProductBusiness.DeleteProductBusiness(product);
        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {
            productGridView.DataSource = ProductBusiness.SelectAllProductBusiness();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
