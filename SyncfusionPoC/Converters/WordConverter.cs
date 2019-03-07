using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using SyncfusionPoC.Converter;

namespace SyncfusionPoC.Converters
{
    class WordConverter : IConverter
    {
        public Image Convert(string filePath)
        {
            Image image;
            using (WordDocument wordDocument = new WordDocument(filePath, FormatType.Docx))
            {
                //todo: examine ChartToImageConverter - do we need it for successfull conversion?
                image = wordDocument.RenderAsImages(0, ImageType.Bitmap);
            }
            return image;
        }
    }
}
