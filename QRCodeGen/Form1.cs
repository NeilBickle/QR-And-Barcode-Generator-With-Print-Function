using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace QRCodeGen
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            PicBox1.Image = barcode.Draw(TxtBarc.Text, 50);
        }

        private void BtnQR_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            PicBox1.Image = qrcode.Draw(TxtQr.Text, 50);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog Dan = new PrintDialog();
            PrintDocument NS = new PrintDocument();
            NS.PrintPage += NS_PrintPage;
            Dan.Document = NS;
            if(Dan.ShowDialog() == DialogResult.OK)
            NS.Print();
        }

        private void NS_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(PicBox1.Width, PicBox1.Height);
            PicBox1.DrawToBitmap(bmp, new Rectangle(0, 0, PicBox1.Width, PicBox1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }
    }
}
