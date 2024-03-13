using ModelLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class ProductDB
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost; port=3306; username=root;password='';database=courier;");


        public static void AddProductDB(ProductClass1 product)
        {
            try
            {
                using (conn)
                {
                    // string querry = "INSERT INTO StudentTB(rollno,name,class,gpa) VALUES(@rollno,@name,@class,@gpa)";

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("AddProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@senderName",product.senderName);
                    cmd.Parameters.AddWithValue("@senderPhoneNo",product.senderPhoneNo);
                    cmd.Parameters.AddWithValue("@senderAddress",product.senderAddress);
                    cmd.Parameters.AddWithValue("@reciverName",product.reciverName);
                    cmd.Parameters.AddWithValue("@reciverPhoneNo",product.reciverPhoneNo);
                    cmd.Parameters.AddWithValue("@reciverAddress",product.reciverAddress);
                    cmd.Parameters.AddWithValue("@productWeight",product.productWeight);
                    cmd.Parameters.AddWithValue("@cost",product.cost);
                    cmd.Parameters.AddWithValue("@picture",product.picture);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    // conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);

            }
        }

        public static void UpdateProductDB(ProductClass1 product)
        {
            try
            {
                using (conn)
                {
                    // string querry = "INSERT INTO StudentTB(rollno,name,class,gpa) VALUES(@rollno,@name,@class,@gpa)";

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UpdateProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@senderName", product.senderName);
                    cmd.Parameters.AddWithValue("@senderCellNo", product.senderPhoneNo);
                    cmd.Parameters.AddWithValue("@senderAddress", product.senderAddress);
                    cmd.Parameters.AddWithValue("@reciverName", product.reciverName);
                    cmd.Parameters.AddWithValue("@reciverPhoneNo", product.reciverPhoneNo);
                    cmd.Parameters.AddWithValue("@reciverAddress", product.reciverAddress);
                    cmd.Parameters.AddWithValue("@productWeight", product.productWeight);
                    cmd.Parameters.AddWithValue("@cost",product.cost);
                    cmd.Parameters.AddWithValue("@picture",product.picture);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    // conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);

            }
        }

        //DeleteStudentDB

        public static void DeleteProductDB(ProductClass1 product)
        {
            try
            {
                using (conn)
                {
                    // string querry = "INSERT INTO StudentTB(rollno,name,class,gpa) VALUES(@rollno,@name,@class,@gpa)";

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DeleteProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@senderCellNo", product.senderPhoneNo);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted successfully");

                    // conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);

            }
        }

        public static DataTable SelectAllProducts()
        {
            using (conn)

            {
                conn.Open();
                var sda = new MySqlDataAdapter("SelectAll", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                var dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }

        }
    }
}
