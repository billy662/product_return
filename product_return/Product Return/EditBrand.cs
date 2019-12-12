using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Return
{
    public partial class EditBrand : Form
    {
        private MySqlConnection conn;
        private String brandName;
        private ManageBrands mb;

        public EditBrand()
        {
            InitializeComponent();

            conn = DBConnect.getConnection();
        }

        public EditBrand(String brandName, ManageBrands mb)
        {
            InitializeComponent();

            conn = DBConnect.getConnection();
            this.brandName = brandName;
            tbBrand.Text = brandName;
            this.mb = mb;
        }

        private void tbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbBrand.Text = brandName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbBrand.Text.Equals(brandName))
                {
                    conn.Open();
                    String sql = "UPDATE `brand` SET name = '" + tbBrand.Text + "' WHERE `name` = '" + brandName + "'";
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully edited", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                    mb.showBrands();
                    mb.BringToFront();
                }
                else
                {
                    Close();
                }
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
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Please send the following to the developer for fixing this error:\n" + ex.InnerException, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
