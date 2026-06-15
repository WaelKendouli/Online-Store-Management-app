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
    public partial class frmConvertToXML : Form
    {
        string _FolderPath;
        string _TableName;
        string _FullPath;
        DataTable _dt = new DataTable();
        clsXML_Converter XML_Converter = new clsXML_Converter();
        public frmConvertToXML(DataTable dt , string TableName)
        {
            InitializeComponent();
            _dt = dt;
            _TableName = TableName;
        }


        private async Task<bool> Convert(IProgress<int> prog)
        {
            prog?.Report(10);
            var result = await clsBackgroundWorker.Converter(XML_Converter, _dt, _FullPath, _TableName);
            prog?.Report(100);
            return result;
        }


        private async void _ConvertToXML()
        {
            Progress<int> prog = new Progress<int>(value =>
            {
                pbProgress.Value = value;
            }
            );

            try
            {
                var result = await Convert(prog);
                if (result == true)
                {
                    MessageBox.Show("XML file was created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("XML file was creation failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"XML file was creation failed {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            if (clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtInput, e, string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
            clsSunnyUIErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtInput, e, clsInputValidator.IsXML_FileNameNotValid, "XML file name is not valid");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            _FullPath = _FolderPath + $"\\{txtInput.Text.ToString()}";
            _ConvertToXML();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            _FolderPath = clsFolderSelector._SelectFolderPath();
        }
    }
}
