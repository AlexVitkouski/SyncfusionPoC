using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncfusionPoC.Converters;

namespace SyncfusionPoC
{
    class ConverterProvider
    {
        readonly WordConverter wordConverter =new WordConverter();
        readonly ExcelConverter excelConverter =new ExcelConverter();
        readonly PowerPointConverter powerPointConverter = new PowerPointConverter();
        
        public IConverter GetConverter(string filePath)
        {
            switch (AppChooser.Choose(filePath))
            {
                case SupportedApplications.Word:
                    return wordConverter;
                case SupportedApplications.Excel:
                    return excelConverter;
                case SupportedApplications.PowerPoint:
                    return powerPointConverter;
                default:
                    return null;
            }
        }
    }
}
