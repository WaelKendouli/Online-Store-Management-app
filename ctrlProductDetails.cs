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
    public partial class ctrlProductDetails : Form
    {
        public ctrlProductDetails(int productID)
        {
            InitializeComponent();
            _ProductID = productID;
        }
        int _ProductID = -1;
        private void ctrlProductDetails_Load(object sender, EventArgs e)
        {
            ctrlProductCardInfos1.LoadProductCardInfo(_ProductID);
        }
    }
}
