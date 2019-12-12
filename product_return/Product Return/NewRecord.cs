using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Return
{
    public partial class NewRecord : Form
    {
        private string[] pids { get; set;}
        private string placeHolderText = "Please input all data in this area, seperate each by a line";

        private MySqlConnection conn;
        private LoadingScreen ls;

        public NewRecord()
        {
            InitializeComponent();
        }

        private void NewRecord_Load(object sender, EventArgs e)
        {
            //rtbIDs.Text = "501218G703670105";
            //rtbOther.Text = "70367 01-BLK 05";
            resetRtbIds();
            resetRtbOther();

            conn = DBConnect.getConnection();
            ls = new LoadingScreen();

            getAllBrandName();

            cmbOtherInfo.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rtbIDs_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(rtbIDs.Text))
            {
                resetRtbIds();
            }
        }

        private void rtbIDs_Enter(object sender, EventArgs e)
        {
            if (rtbIDs.Text.Equals(placeHolderText))
            {
                rtbIDs.Text = "";
                rtbIDs.ForeColor = Color.Black;
                rtbIDs.Font = new Font(rtbIDs.Font.FontFamily, (float)15.75);
            }
        }

        private void rtbOther_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(rtbOther.Text))
            {
                resetRtbOther();
            }
        }

        private void rtbOther_Enter(object sender, EventArgs e)
        {
            if (rtbOther.Text.Equals(placeHolderText))
            {
                rtbOther.Text = "";
                rtbOther.ForeColor = Color.Black;
                rtbOther.Font = new Font(rtbOther.Font.FontFamily, (float)15.75);
            }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            string[] ids = rtbIDs.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            string[] other = rtbOther.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            if ((tbInvoiceID.Text.Equals("") ||
                (ids.Length == 1 && ids[0].Equals(placeHolderText)) ||
                (other.Length == 1 && other[0].Equals(placeHolderText))) &&
                cmbOtherInfo.SelectedIndex != 2)
            {
                MessageBox.Show("Please fill in all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ids.Length != other.Length && cmbOtherInfo.SelectedIndex != 2)
            {
                MessageBox.Show("Please enter same amount of data in both text boxes.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkDuplicateItem(ids))
            {
                MessageBox.Show("Duplicate item found in ID field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (checkDuplicateItem(other) && cmbOtherInfo.SelectedIndex == 0)
            {
                MessageBox.Show("Duplicate item found in other field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ls.Show();
                try
                {
                    conn.Open();
                    for (int i = 0; i < ids.Length; i++)
                    {
                        MySqlCommand comm = conn.CreateCommand();
                        if (cmbOtherInfo.SelectedIndex == 0)
                        {
                            string[] otherDetailed = other[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                            comm.CommandText = "INSERT INTO `product_return` (`invoice_id`, `brand`, `pid`, `short_code`, `color`, `size`, `quantity`, `price`) VALUES (@invoice, @brand, @pid, @short_code, @color, @size, @quantity, NULL);";

                            comm.Parameters.AddWithValue("@short_code", otherDetailed[0]);
                            comm.Parameters.AddWithValue("@color", otherDetailed[1]);
                            comm.Parameters.AddWithValue("@size", otherDetailed[2]);
                        }
                        else if(cmbOtherInfo.SelectedIndex == 1)
                        {
                            comm.CommandText = "INSERT INTO `product_return` (`invoice_id`, `brand`, `pid`, `short_code`, `color`, `size`, `quantity`, `price`) VALUES (@invoice, @brand, @pid, NULL, NULL, NULL, @quantity, @price);";
                            comm.Parameters.AddWithValue("@price", other[i]);
                        }
                        else
                        {
                            comm.CommandText = "INSERT INTO `product_return` (`invoice_id`, `brand`, `pid`, `short_code`, `color`, `size`, `quantity`, `price`) VALUES (@invoice, @brand, @pid, NULL, NULL, NULL, @quantity, NULL);";
                        }
                        comm.Parameters.AddWithValue("@invoice", tbInvoiceID.Text);
                        comm.Parameters.AddWithValue("@brand", cmbBrand.Text);
                        comm.Parameters.AddWithValue("@pid", ids[i]);
                        comm.Parameters.AddWithValue("@quantity", "1");
                        comm.ExecuteNonQuery();
                    }
                    
                    conn.Close();
                    MessageBox.Show("Record(s) successfully added to database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbInvoiceID.Text = "";
                    cmbBrand.SelectedIndex = 0;
                    resetRtbIds();
                    resetRtbOther();
                }
                catch (MySqlException sqlEx)
                {
                    conn.Close();
                    if (sqlEx.Number == 1062)
                    {
                        MessageBox.Show("The same product is already appeared in an invoice.", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sqlEx.Number == 0 || sqlEx.Number == 1042)
                    {
                        MessageBox.Show("Connection timed out\nPlease try again", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Please send the following to the developer for fixing this error:\n" + sqlEx.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    BringToFront();
                    return;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BringToFront();
                    return;
                }
                BringToFront();
                ls.Hide();
            }
        }

        private Boolean checkDuplicateItem(string[] arr)
        {
            return arr.Length != arr.Distinct().Count();
        }

        private void resetRtbIds()
        {
            rtbIDs.Text = placeHolderText;
            rtbIDs.ForeColor = Color.DimGray;
            rtbIDs.Font = new Font(rtbIDs.Font.FontFamily, 11);
        }

        private void resetRtbOther()
        {
            rtbOther.Text = placeHolderText;
            rtbOther.ForeColor = Color.DimGray;
            rtbOther.Font = new Font(rtbIDs.Font.FontFamily, 11);
        }

        private void getAllBrandName()
        {
            ls.Show();
            string sql = "SELECT * FROM `Brand`";
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sql, conn);
                using (MySqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbBrand.Items.Add(dr.GetValue(0).ToString());
                    }
                }
                conn.Close();
                cmbBrand.SelectedIndex = 0;
            }
            catch (MySqlException sqlEx)
            {
                conn.Close();
                if (sqlEx.Number == 0 || sqlEx.Number == 1042)
                {
                    MessageBox.Show("Connection timed out\nPlease try again", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please send the following to the developer for fixing this error:\n" + sqlEx.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
            ls.Hide();
        }

        private void btnManBrand_Click(object sender, EventArgs e)
        {
            Form mb = new ManageBrands();
            mb.Show();
        }
    }
}
