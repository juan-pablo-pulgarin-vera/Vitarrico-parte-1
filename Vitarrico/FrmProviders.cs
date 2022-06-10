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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.tool.xml;

namespace Vitarrico
{
    public partial class FrmProviders : Form
    {
        ConexionSQLServer conexion = new ConexionSQLServer();

        #region atributos y propiedades

        private int idProviders;
        private DataTable dataProviders;

        #endregion

        #region constructor 

        public FrmProviders()
        {
            InitializeComponent();
            fillDataGridView();
        }

        #endregion

        #region metodos

        private void savedProviders()
        {
            try
            {
                SqlCommand comando;
                string sql;

                sql = @"INSERT INTO tblProviders (Nit,CompanyName,ProductCode,Email,Address,Phone)
                    VALUES (@nit, @companyName,@productCode, @email, @address, @phone)";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@nit", txtNit.Text);
                comando.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                comando.Parameters.AddWithValue("@productCode", txtProductCode.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@address", txtAddress.Text);
                comando.Parameters.AddWithValue("@phone", txtPhone.Text);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateProviders()
        {
            try
            {
                SqlCommand comando;
                string sql = @"UPDATE tblProviders
                           SET Nit = @nit
                              ,CompanyName = @companyName
                              ,ProductCode = @productCode
                              ,Email = @email
                              ,Address = @address
                              ,Phone = @phone
                         WHERE Id = @id";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@id", idProviders);
                comando.Parameters.AddWithValue("@nit", txtNit.Text);
                comando.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                comando.Parameters.AddWithValue("@productCode", txtProductCode.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@address", txtAddress.Text);
                comando.Parameters.AddWithValue("@phone", txtPhone.Text);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully update", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteProviders()
        {
            try
            {
                SqlCommand comando;
                string sql = @"DELETE FROM tblProviders
                            WHERE Id = @id";
                conexion.ConectarBD.Open();
                comando = new SqlCommand(sql, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@id", idProviders);
                comando.ExecuteNonQuery();
                conexion.ConectarBD.Close();
                MessageBox.Show("successfully delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillDataGridView()
        {
            SqlCommand comando;
            string sql = @"SELECT *
                           FROM tblProviders";
            comando = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataProviders = dt;

            dgvProviders.DataSource = dt;
            dgvProviders.RowHeadersVisible = false;
            dgvProviders.Columns[0].Visible = false;
            dgvProviders.Columns[1].HeaderText = "Nit";
            dgvProviders.Columns[2].HeaderText = "Company name";
            dgvProviders.Columns[3].HeaderText = "Product code";
            dgvProviders.Columns[4].HeaderText = "Email";
            dgvProviders.Columns[5].HeaderText = "Address";
            dgvProviders.Columns[6].HeaderText = "Phone";
        }

        private void clear()
        {
            txtNit.Text = String.Empty;
            txtCompanyName.Text = String.Empty;
            txtProductCode.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
        }

        #endregion

        #region Eventos 

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedProviders();
            fillDataGridView();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProviders();
            fillDataGridView();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProviders();
            fillDataGridView();
            clear();
        }

        private void dgvProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idProviders = Convert.ToInt32(dgvProviders.CurrentRow.Cells["Id"].Value.ToString());
                txtNit.Text = dgvProviders.CurrentRow.Cells["Nit"].Value.ToString();
                txtCompanyName.Text = dgvProviders.CurrentRow.Cells["CompanyName"].Value.ToString();
                txtProductCode.Text = dgvProviders.CurrentRow.Cells["ProductCode"].Value.ToString();
                txtEmail.Text = dgvProviders.CurrentRow.Cells["Email"].Value.ToString();
                txtAddress.Text = dgvProviders.CurrentRow.Cells["Address"].Value.ToString();
                txtPhone.Text = dgvProviders.CurrentRow.Cells["Phone"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
             * Se solicita ruta del archivo y se le da el nombre
             * **/
            SaveFileDialog route = new SaveFileDialog();
            route.FileName = "Providers"+DateTime.Now.ToString("dd-MM-yyyy")+ ".pdf";
            

            String Contenido = Properties.Resources.ExtructuraPdf.ToString();

            String datosFilas = string.Empty;

            /**
             * Se llena el pdf Con la infomacion de los provedores
             * **/
            foreach (DataGridViewRow row in dgvProviders.Rows)
            {
                if(!(row.Cells["CompanyName"].Value == null))
                {
                    datosFilas += "<tr><td colspan='3' height='20'></td></tr>";
                    datosFilas += "<tr>";
                    datosFilas += "<td colspan='2'>";
                    datosFilas += "<table style='width:100%'>";
                    datosFilas += "<tr>";
                    datosFilas += "<td colspan='1' style='width:20%'>Company name:</td>";
                    datosFilas += "<td colspan='3' style='width:80%;border-bottom:1px solid black'>" + row.Cells["CompanyName"].Value.ToString() + "</td>";
                    datosFilas += "</tr>";
                    datosFilas += "<tr>";
                    datosFilas += "<td colspan='1' style='width:20%'>Nit:</td>";
                    datosFilas += "<td colspan='1' style='width:30%;border-bottom:1px solid black'>" + row.Cells["Nit"].Value.ToString() + "</td>";
                    datosFilas += "<td colspan='1' style='width:10%'>Product code:</td>";
                    datosFilas += "<td colspan='1' style='width:40%;border-bottom:1px solid black'>" + row.Cells["ProductCode"].Value.ToString() + "</td>";
                    datosFilas += "</tr>";
                    datosFilas += "<tr>";
                    datosFilas += "<td colspan='1' style='width:20%'>Email:</td>";
                    datosFilas += "<td colspan='1' style='width:30%;border-bottom:1px solid black'>" + row.Cells["Email"].Value.ToString() + "</td>";
                    datosFilas += "<td colspan='1' style='width:20%'>Phone number:</td>";
                    datosFilas += "<td colspan='1' style='width:80%;border-bottom:1px solid black'>" + row.Cells["Phone"].Value.ToString() + "</td>";
                    datosFilas += "</tr>";
                    datosFilas += "</table>";
                    datosFilas += "</td>";
                    datosFilas += "</tr>";
                }
            }
            Contenido = Contenido.Replace("@ContenidoHTML", datosFilas);

            if(route.ShowDialog() == DialogResult.OK)
            {
                /**
                 * Esta instruccion permite crear el archivo en memoria
                 * porque todavia no existe.
                 * 
                 * fileStream: memoria
                 ***/
                using (FileStream saveArchive = new FileStream(route.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDocument, saveArchive);
                    pdfDocument.Open();

                    pdfDocument.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoVitarrico, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80,60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDocument.LeftMargin,pdfDocument.Top-60);
                    pdfDocument.Add(img);

                    /**
                     * StreamReader nos permitira leer el contenido html**/
                    using (StringReader sr = new StringReader(Contenido))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDocument, sr);
                    }

                    pdfDocument.Close();
                    saveArchive.Close();
                }  
            }
        }

        #endregion

    }
}
