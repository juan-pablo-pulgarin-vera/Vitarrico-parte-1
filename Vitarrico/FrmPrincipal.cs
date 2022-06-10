using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitarrico
{
    public partial class FrmPrincipal : Form
    {
        #region Atributos y Metodos

        public static FrmPrincipal FormPrincipal;
        #endregion

        #region Constructores

        public FrmPrincipal()
        {
            InitializeComponent();
            FormPrincipal = this;
        }

        public FrmPrincipal(bool esAdministrador, string users, bool esVendedor = false){
            InitializeComponent();

            if (esAdministrador)
            {
                sellers1.Visible = false;
                winemaker1.Visible = false;
            }
            else
            {
                if (esVendedor)
                {
                    administrator1.Visible = false;
                    winemaker1.Visible=false;
                }
                else
                {
                    administrator1.Visible=false;
                    sellers1.Visible=false;
                }
            }

            lblNameUser.Text = "Bienvenido/a " + users;
            FormPrincipal = this;
        }
        #endregion

        #region Métodos

        public void receiveSelected(string opcionSeleccionada)
        {
            pbPrincipal.Visible = false;

            if (opcionSeleccionada == "PRODUCTS")
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FrmProviders))
                    {
                        frm.Close();
                        break;
                    }
                }

                FrmProducts frmProducts = new FrmProducts();
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
            else if (opcionSeleccionada == "PROVIDERS")
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FrmProducts))
                    {
                        frm.Close();
                        break;
                    }
                }

                FrmProviders frmProviders = new FrmProviders();
                frmProviders.MdiParent = this;
                frmProviders.Show();
            }
        }
        #endregion

        #region Eventos

        #endregion


    }
}
