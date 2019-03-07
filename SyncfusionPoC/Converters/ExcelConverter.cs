using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;
using SyncfusionPoC.Converter;

namespace SyncfusionPoC.Converters
{
    class ExcelConverter : IConverter
    {
        public Image Convert(string filePath)
        {
            Image image;
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;
                IWorkbook workbook = application.Workbooks.Open(filePath, ExcelOpenType.Automatic);
                IWorksheet sheet = workbook.Worksheets[0];

                image = sheet.ConvertToImage(1, 1, 50, 30);
            }
            return image;
        }
    }
}
