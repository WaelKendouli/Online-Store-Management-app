using LibraryLogicLayer;
using LogicLayer.BackGroundOperations;
using LogicLayer.ConvertersClasses;
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
    public partial class frmConvertToJSON : Form
    {

        DataTable _dt = new DataTable();
        string _TableName;
        string _FullPath;
        string _FolderPath;
        clsJSON_Converter JSON_Converter = new clsJSON_Converter();
        public frmConvertToJSON(DataTable Table , string TableName)
        {
            InitializeComponent();
            _dt = Table;
            _TableName = TableName;
        }
        private async Task<bool> Convert(IProgress<int> prog)
        {
            prog?.Report(10);
            var result = await clsBackgroundWorker.Converter(JSON_Converter, _dt, _FullPath, "Products");
            prog?.Report(100);
            return result;
        }


        private async void _ConvertToJSON()
        {
            Progress<int> prog = new Progress<int>(value =>
            {
                pbProgress.Value = value;
            }
            );

            try
            {
                var result = await  Convert(prog);
                if (result == true)
                {
                    MessageBox.Show("JSON file was created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("JSON file creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"JSON file creation failed {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmConvertToJSON_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtInput, e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtInput, e, clsInputValidator.IsJSON_FileNameNotValid, "XML file name is not valid");
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            _FolderPath = clsFolderSelector._SelectFolderPath();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() == false)
            {
                return;
            }
            _FullPath = _FolderPath + $"\\{txtInput.Text.ToString()}";
            _ConvertToJSON();
        }
    }
}
