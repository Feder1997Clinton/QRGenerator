using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace QRGenerator
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            try
            {               
                string nombreArchivo = Application.StartupPath + $@"\{txtCadena.Text}.png";               
                if (File.Exists(nombreArchivo))
                    File.Delete(nombreArchivo);
                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.Q);
                QrCode qrCode = qrEncoder.Encode(txtCadena.Text);
                GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(8, QuietZoneModules.Two), Brushes.Black, Brushes.White);
                using (FileStream stream = new FileStream(nombreArchivo, FileMode.Create))
                {
                    renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
                }                
                picQR.Image = Image.FromFile(nombreArchivo);              
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error en btnGenerarQR_Click(): " + ex.Message);
            }
        }
    }
}
