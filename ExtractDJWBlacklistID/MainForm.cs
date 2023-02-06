using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ExtractDJWBlacklistID
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBox936ExcelFilePath.Text = Directory.GetCurrentDirectory() + "\\936list.xlsx";
            textBoxDJWListFilePath.Text = Directory.GetCurrentDirectory() + "\\PFA2_201906022200_D.xml";
            textBoxOutputExcelPath.Text = Directory.GetCurrentDirectory();
        }

        private void buttonRunExtract_Click(object sender, EventArgs e)
        {
            XmlUtility xmlUtility = new XmlUtility();
            ExcelUtility excelUtility = new ExcelUtility();
            try
            {
                // Read Excel
                var workbook = excelUtility.ReadExcelToWorkBook(textBox936ExcelFilePath.Text);
                IEnumerable<int> referenceIDs = excelUtility.Read936WorkBookToListReferenceID(workbook);

                //Read DJW List

                var xml = XDocument.Load(textBoxDJWListFilePath.Text);

                var hasSanctionsReferencesPersons = xmlUtility.GetHasSanctionsReferencesRecords(xml, "Person");

                var hasSanctionsReferencesEntities = xmlUtility.GetHasSanctionsReferencesRecords(xml, "Entity");                

                XSSFWorkbook outPutWorkBook = excelUtility.ReadExcelTemplate("./template.xlsx");
                
                
                int rowCount = 1;

                foreach (var item in hasSanctionsReferencesPersons)
                {
                    IEnumerable<int> sanctionsReferenceNumbers = xmlUtility.GetSanctionReferenceNumbers(item);                   

                    if (referenceIDs.Intersect(sanctionsReferenceNumbers).Any())
                    {
                        IDsModel model = xmlUtility.GetBlackListsID(item);

                        excelUtility.SaveRow(outPutWorkBook, rowCount, model);

                        rowCount++;
                    }
                }

                foreach (var item in hasSanctionsReferencesEntities)
                {
                    IEnumerable<int> sanctionsReferenceNumbers = xmlUtility.GetSanctionReferenceNumbers(item);

                    if (referenceIDs.Intersect(sanctionsReferenceNumbers).Any())
                    {
                        IDsModel model = xmlUtility.GetBlackListsID(item);

                        excelUtility.SaveRow(outPutWorkBook, rowCount, model);

                        rowCount++;
                    }
                }

                excelUtility.SaveFile(outPutWorkBook, textBoxOutputExcelPath.Text, $"result_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}");
                MessageBox.Show("Extract Ok");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button936ExcelFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBox936ExcelFilePath.Text = filePath;
            }
        }

        private void buttonDJWListFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML File (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBoxDJWListFilePath.Text = filePath;
            }
        }

        private void buttonOutputExcelPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputExcelPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
