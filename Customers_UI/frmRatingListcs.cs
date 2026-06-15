using LogicLayer;
using OnlineStoreProject.UI_Tools;
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
    public partial class frmRatingListcs : Form
    {
        int _CustomerID = 0;
        DataTable dt = new DataTable();
        public frmRatingListcs(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            dt = clsCustomer.GetRatingHistory(CustomerID);
        }

        private void frmRatingListcs_Load(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.LoadData(dt, dgvList, cbItems, new List<string> { "rating_score", "price" }, 150);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.HandleTextBoxChangingEvent(txtInput, cbItems, dt);
        }
    }
}
