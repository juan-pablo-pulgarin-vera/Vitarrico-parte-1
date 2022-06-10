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
    public partial class FrmVendedor : Form
    {

        public FrmVendedor(string Users)
        {
            InitializeComponent();
            lblNameUserVende.Text = "Bienvenido, "+ Users;
            
        }
    }
}
