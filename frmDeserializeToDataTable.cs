using LogicLayer.ConvertersClasses;
using LogicLayer.Interfaces;
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
    public partial class frmDeserializeToDataTable : Form
    {
        public frmDeserializeToDataTable()
        {
            InitializeComponent();
            converter = new clsXML_Converter();
        }

        IF_ConvertToDataTable converter;
        DataTable dt = new DataTable();
        public static async Task<DataTable> ConvertToDataTable(
     IF_ConvertToDataTable obj,
     string FilePath,
     IProgress<int> progress = null)
        {
            return await Task.Run(() =>
            {
                // Report progress at different stages
                progress?.Report(10); // Starting
                var result = obj.ConvertToDataTable(FilePath);
                progress?.Report(100); // Complete
                return result;
            });
        }

        private async void AddFiles()
        {
            string FilePath = ChooseFile();

            var progress = new Progress<int>(value =>
            {
                probProgress.Value = value;

            });

            try
            {
                probProgress.Visible = true;
                DataTable result = await ConvertToDataTable(converter, FilePath, progress);
                dt = result;
                // Handle successful conversion
                clsSunnyUIDataGridViewSettings.LoadData(result, dgv, cbItems , null , 170);
                
                MessageBox.Show("Conversion completed successfully!");
                probProgress.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                probProgress.Value = 0;
            }
        }


        private string ChooseFile()
        {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "XML Files|*.xml|JSON Files|*.json";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        return openFileDialog.FileName;
                    }
                    return null; // User cancelled
                }
        }

        private void frmDeserializeToDataTable_Load(object sender, EventArgs e)
        {
            probProgress.Visible = false;
            cbDeserialaztionTool.SelectedIndex = 0;
        }

        private void SelectDeserialaztionTool()
        {
            switch(cbDeserialaztionTool.SelectedText)
            {
                case "XML":
                    converter = new clsXML_Converter();
                    break;
                case "JSON":
                    converter = new clsJSON_Converter();
                    break;
            }
        }

        private void cbDeserialaztionTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDeserialaztionTool();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            clsSunnyUIDataGridViewSettings.HandleTextBoxChangingEvent(txtInput, cbItems, dt);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            AddFiles();
        }

        private void _Clear()
        {
            dgv.DataSource = new DataTable();
            cbItems.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Clear();
        }
    }
}
