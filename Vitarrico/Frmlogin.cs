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
    public partial class Frmlogin : Form
    {
        ConexionSQLServer conexion = new ConexionSQLServer();

        #region Atributos y Propiedades

        #endregion

        #region Constructores
        public Frmlogin()
        {
            InitializeComponent();
            conexion.AbrirConexion();
        }

        #endregion

        #region Métodos

        private void Clear()
        {
            txtUser.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        #endregion

        #region Eventos

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblUsers WHERE Users= '" + txtUser.Text + "' AND Password= '" + txtPassword.Text + "' ;";
            SqlCommand comando = new SqlCommand(sql, conexion.ConectarBD);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            data.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Clear();

                if (dt.Rows[0]["User_type"].ToString() == "ADMINISTRADOR")
                {
                    this.Visible = false;
                    FrmPrincipal frm = new FrmPrincipal(true, dt.Rows[0]["Users"].ToString());
                    frm.ShowDialog();
                    this.Visible = true;

                } else if (dt.Rows[0]["User_type"].ToString() == "VENDEDOR")
                {
                    this.Visible = false;
                    FrmPrincipal frm = new FrmPrincipal(false, dt.Rows[0]["Users"].ToString(),  true);
                    frm.ShowDialog();
                    this.Visible = true;
                }
                else if (dt.Rows[0]["User_type"].ToString() == "BODEGUERO")
                {
                    this.Visible = false;
                    FrmPrincipal frm = new FrmPrincipal(false, dt.Rows[0]["Users"].ToString());
                    frm.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("El tipo de usuario no coíncide", "Atención: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            else
            {
                Clear();
                timer1.Start();
                lblErrorLogin.Visible = true;
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmRegistro frm = new FrmRegistro();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
            timer1.Stop();
        }

        #endregion
        
    }
}
