using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PicOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            PicLater.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.png, *.bmp, *.jpg)|*.bmp;*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PicOriginal.Image = new Bitmap(openFile.FileName);
            }
        }

        private static void ConvertBmp(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int R, G, B;
                    R = pixelColor.R;
                    G = pixelColor.G;
                    B = pixelColor.B;
                    var val = (byte)(R * 0.2126 + G * 0.7152 + B * 0.0722);
                    R = B = G = val;
                    bitmap.SetPixel(i, j, Color.FromArgb(R, B, G));
                }
            }
        }

        private void BtnTransform_Click(object sender, EventArgs e)
        {
            var imageToEdit = PicOriginal.Image as Bitmap;
            ConvertBmp(imageToEdit);
            PicLater.Image = imageToEdit;
        }
    }
}