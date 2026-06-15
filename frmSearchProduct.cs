using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreProject
{
    public partial class frmSearchProduct : Form
    {
        public frmSearchProduct()
        {
            InitializeComponent();
        }

        private void frmSearchProduct_Load(object sender, EventArgs e)
        {
            ctrlSearchProduct1.FillListProductsFromDB_ForLoad();
        }
    }
}
