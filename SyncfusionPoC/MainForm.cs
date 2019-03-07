using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.Presentation;
using Syncfusion.XlsIO;
using FormatType = Syncfusion.DocIO.FormatType;
using ImageType = Syncfusion.DocIO.DLS.ImageType;

namespace SyncfusionPoC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            const string pathToFolder = Common.PathTSrcFolder;
            var testRunner = new TestRunner(pathToFolder, pictureBox1);
            testRunner.Run();
            MessageBox.Show("Done.");
        }
    }
}
