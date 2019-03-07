using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionPoC.Converter
{
    interface IConverter
    {
        Image Convert(string filePath);
    }
}
