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
    public partial class FrmRegistro : Form
    {
        ConexionSQLServer conexion = new ConexionSQLServer();

        #region Atributos y Propiedades

        #endregion

        #region Constructores

        public FrmRegistro()
        {
            InitializeComponent();
            conexion.ConectarBD.Open();
            cbTypeDocument.SelectedIndex = 0;
            cbKingdPerson.SelectedIndex = 0;

        }

        #endregion

        #region Métodos
        private void Clear()
        {
            txtIdentification.Text = String.Empty;
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtUser.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        #endregion

        #region Eventos
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando;
                string SQL;

                if (cbKingdPerson.SelectedIndex == 2)
                {
                    SQL = "INSERT INTO tblsellers (TypeDocument,Identification,Name,LastName,Address, Email,Phone)" +
                          @"VALUES (@TypeDocument,@Identification,@Name,@LastName,@Address, @Email,@Phone)";
                    comando = new SqlCommand(SQL, conexion.ConectarBD);
                    comando.Parameters.AddWithValue("@TypeDocument", cbTypeDocument.Text);
                    comando.Parameters.AddWithValue("@Identification", txtIdentification.Text);
                    comando.Parameters.AddWithValue("@Name", txtName.Text);
                    comando.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@Address", txtAddress.Text);
                    comando.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    comando.ExecuteNonQuery();

                    SQL = "";

                    SQL = "INSERT INTO tblUsers (Users, Password, User_type, Identification_Sellers)" +
                        @"VALUES (@User, @Password, @UserType, @Identification)";
                }
                else
                {
                     SQL = "INSERT INTO tblPeople (TypeDocument,Identification,Name,LastName,Email,Address,Phone,KindOfPerson)" +
                            @"VALUES (@TypeDocument,@Identification,@Name,@LastName,@Email,@Address,@Phone,@KindOfPerson)";
                    comando = new SqlCommand(SQL, conexion.ConectarBD);
                    comando.Parameters.AddWithValue("@TypeDocument", cbTypeDocument.Text);
                    comando.Parameters.AddWithValue("@Identification", txtIdentification.Text);
                    comando.Parameters.AddWithValue("@Name", txtName.Text);
                    comando.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@Address", txtAddress.Text);
                    comando.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    comando.Parameters.AddWithValue("@KindOfPerson", cbKingdPerson.Text);
                    comando.ExecuteNonQuery();

                    SQL = "";

                    SQL = "INSERT INTO tblUsers (Users, Password, User_type, Identification_People)" +
                        @"VALUES (@User, @Password, @UserType, @Identification)";
                }

              
                comando = new SqlCommand(SQL, conexion.ConectarBD);
                comando.Parameters.AddWithValue("@User", txtUser.Text);
                comando.Parameters.AddWithValue("@Password", txtPassword.Text);
                comando.Parameters.AddWithValue("@UserType", cbKingdPerson.Text);
                comando.Parameters.AddWithValue("@Identification", txtIdentification.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("Successful registration", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear();


            }catch (Exception ex)
            {
                MessageBox.Show("could not register", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Error " + ex);
            }
        }

        #endregion

    }
}
