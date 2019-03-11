using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.ExcelChartToImageConverter;
using Syncfusion.XlsIO;

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
                image = sheet.ConvertToImage(1, 1, 42, 10);
            }
            return image;
        }
    }
}
