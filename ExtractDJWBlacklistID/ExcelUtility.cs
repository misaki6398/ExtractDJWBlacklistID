using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractDJWBlacklistID
{
    class ExcelUtility
    {

        public XSSFWorkbook ReadExcelToWorkBook(string filePath)
        {   
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            XSSFWorkbook workbook = new XSSFWorkbook(file);            
            return workbook;
        }

        public List<int> Read936WorkBookToListReferenceID(XSSFWorkbook workbook)
        {
            ISheet sheet = workbook.GetSheetAt(0);
            List<int> referencIDs = new List<int>();
          
            for (int count=1;count< sheet.LastRowNum; count++)
            {
                try
                {
                    IRow row = sheet.GetRow(count);
                    referencIDs.Add((int)row.GetCell(0).NumericCellValue);
                    referencIDs.Add((int)row.GetCell(1).NumericCellValue);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Row {count} Got Error:{ex.ToString()}");
                }                
            }
            return referencIDs;
        }

        public void SaveFile(XSSFWorkbook workbook, string filepath, string fileName)
        {

            string fullFilePath = filepath + "\\" + fileName + ".xlsx";
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            if (File.Exists(fullFilePath))
            {
                File.Delete(fullFilePath);
            }
            using (FileStream fs = File.Open(fullFilePath, FileMode.Create))
            {
                fs.Seek(0, SeekOrigin.End);
                workbook.Write(fs);
            }

        }

        public XSSFWorkbook ReadExcelTemplate(string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            XSSFWorkbook workbook = new XSSFWorkbook(file);
            return workbook;
        }

        public void SaveRow(IWorkbook workbook, int rowCount, IDsModel model)
        {
            ISheet sheet = workbook.GetSheetAt(0);
            sheet.CreateRow(rowCount);
            sheet.GetRow(rowCount).CreateCell(0).SetCellValue(model.PersonID);
            sheet.GetRow(rowCount).CreateCell(1).SetCellValue(model.EUID);
            sheet.GetRow(rowCount).CreateCell(2).SetCellValue(model.OfacID);
            sheet.GetRow(rowCount).CreateCell(3).SetCellValue(model.UNID);
            
        }

    }
}
