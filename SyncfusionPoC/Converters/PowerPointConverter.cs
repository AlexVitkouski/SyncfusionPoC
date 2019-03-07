using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Presentation;
using SyncfusionPoC.Converter;

namespace SyncfusionPoC.Converters
{
    class PowerPointConverter : IConverter
    {
        public Image Convert(string filePath)
        {
            Image image;
            using (IPresentation pptxDoc = Presentation.Open(filePath))
            {
                image = pptxDoc.Slides[0].ConvertToImage(Syncfusion.Drawing.ImageType.Metafile);
            }
            return image;
        }
    }
}
