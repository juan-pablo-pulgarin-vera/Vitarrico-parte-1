using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vitarrico
{
    public partial class FrmProducts : Form
    {
        ConexionSQLServer conexion = new ConexionSQLServer();

        #region atributos y propiedades

            private int idProduct;

        #endregion

        #region constructor

         public FrmProducts()
         {
            InitializeComponent();
            cbType.SelectedIndex = 0;
            fillComboBox();
            try
            {
                cbProductCode.SelectedIndex = 0;

            }catch(Exception ex)
            {
                MessageBox.Show("register providers "+ex, "Attention", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            fillDataGridView();
         }

        #endregion

        #region metodos

        private void fillComboBox()
        {
            SqlCommand comando;
            string sql;

            sql = @"SELECT ProductCode FROM tblProviders";
            comando = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbProductCode.Items.Add(dt.Rows[i]["ProductCode"].ToString());
            }
        }

        private void fillDataGridView()
        {
            SqlCommand comando;
            string sql;

            sql = @"SELECT * FROM tblProducts";
            comando = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
          
            dgvProducts.DataSource = dt;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.Columns[0].Visible = false;
            dgvProducts.Columns[1].HeaderText = "Product code";
            dgvProducts.Columns[2].HeaderText = "Product name";
            dgvProducts.Columns[3].HeaderText = "Product details";
            dgvProducts.Columns[4].HeaderText = "Type";
            dgvProducts.Columns[5].HeaderText = "Unit price";
        }

        private void saveProduct()
        {
            try
            {
                SqlCommand comando;
                string sql;
        
                sql = @"INSERT INTO tblProducts (ProductCode,ProductName,ProductDetails,Type,UnitPrice)
                    VALUES (@codeProduct, @productName,@productDetails, @type, @unitPrice)";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@codeProduct", cbProductCode.Text);
                comando.Parameters.AddWithValue("@productName", txtProductName.Text);
                comando.Parameters.AddWithValue("@productDetails", txtDetails.Text);
                comando.Parameters.AddWithValue("@type", cbType.Text);
                comando.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateProduct()
        {
            try
            {
                SqlCommand comando;

                String sql = @"UPDATE [dbo].[tblProducts]
                   SET ProductCode = @codeProduct
                      ,ProductName = @productName
                      ,ProductDetails = @productDetails
                      ,Type = @type
                      ,UnitPrice =@unitPrice
                 WHERE Id = @id";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@id", idProduct);
                comando.Parameters.AddWithValue("@codeProduct", cbProductCode.Text);
                comando.Parameters.AddWithValue("@productName", txtProductName.Text);
                comando.Parameters.AddWithValue("@productDetails", txtDetails.Text);
                comando.Parameters.AddWithValue("@type", cbType.Text);
                comando.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteProduct()
        {
            try
            {
                SqlCommand comando;
                string sql = @"
                        DELETE FROM tblProducts
                              WHERE Id = @id";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@id", idProduct);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void clear()
        {
            cbProductCode.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtDetails.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
        }

        #endregion

        #region eventos

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProduct();
            fillDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProduct();
            fillDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProduct();
            fillDataGridView();
            clear();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idProduct = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value.ToString());
                cbProductCode.SelectedIndex = cbProductCode.FindString(dgvProducts.CurrentRow.Cells["ProductCode"].Value.ToString());
                txtProductName.Text = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
                txtDetails.Text = dgvProducts.CurrentRow.Cells["ProductDetails"].Value.ToString();
                cbType.SelectedIndex = cbType.FindString(dgvProducts.CurrentRow.Cells["Type"].Value.ToString());
                txtUnitPrice.Text = dgvProducts.CurrentRow.Cells["UnitPrice"].Value.ToString();
            }
        }

        #endregion

    }
}
