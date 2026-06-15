using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer;
using LogicLayer.BackGroundOperations;
using LogicLayer.ConvertersClasses;
using LogicLayer.Interfaces;
using OnlineStoreProject.UI_Tools;
namespace OnlineStoreProject
{
    public partial class frmPDFConverter : Form
    {
        
        DataTable _dt = new DataTable();
        string _TableName;
        clsPDF_Converter conv = new clsPDF_Converter();
        public frmPDFConverter(DataTable dt , string TableName)
        {
            InitializeComponent();
            _TableName = TableName;
            _dt = dt;
        }
        string Folder_Path = "D:\\OS 2 Courses";
        string Full_Path = "";
        private string _SelectFolderPath()
        {
            string FolderPath = "";
            using (FolderBrowserDialog diag = new FolderBrowserDialog())
            {
                diag.Description = "Select a folder";
                diag.ShowNewFolderButton = true;

                if (diag.ShowDialog()==DialogResult.OK)
                {
                    FolderPath = diag.SelectedPath;
                }
                return FolderPath;
            }
        }

        private void frmPDFConverter_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck , txtInput,e,string.IsNullOrEmpty , "this field shouldn't be empty"))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtInput, e, clsInputValidator.IsPDF_FileNameNotValid, "PDF file name is not valid");
        }

        private  async Task<bool> Convert(IProgress<int> prog)
        {
            prog?.Report(10);
            var result = await clsBackgroundWorker.Converter(conv, _dt, Full_Path, "ProductTable");
            prog?.Report(100);
            return result;
        }


        private async void _ConvertToPDF()
        {
            Progress<int> prog = new Progress<int>(value =>
            {
                pbProgress.Value = value;
            }
            );

            try
            {
                var result = await Convert(prog);
                if (result==true)
                {
                    MessageBox.Show("PDF file was created successfully","",MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PDF file was creation failed","",MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PDF file was creation failed {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            Folder_Path = _SelectFolderPath();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            Full_Path = Folder_Path + $"\\{txtInput.Text}";
            _ConvertToPDF();
        }
    }
}
