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

            TransformTypes.DataSource = Enum.GetValues(typeof(TransformStyle));
            TransformTypes.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void BtnTransform_Click(object sender, EventArgs e)
        {
            Bitmap imageToEdit = (Bitmap)PicOriginal.Image.Clone();
            var Selected = (TransformStyle)TransformTypes.SelectedValue;
            bgWorkerMain.RunWorkerAsync(argument: new object[] { imageToEdit, Selected });
        }

        private void bgWorkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = (object[])e.Argument;
            Bitmap imageToEdit = (Bitmap)args[0];
            switch ((TransformStyle)args[1])
            {
                case TransformStyle.GrayScale:
                    ImageProcessor.ConvertToGrascale(imageToEdit);
                    break;

                case TransformStyle.Negative:
                    ImageProcessor.ConvertToNegative(imageToEdit);
                    break;

                default:
                    break;
            }
            PicLater.Image = imageToEdit;
        }
    }

    public enum TransformStyle
    {
        GrayScale,
        Negative
    }
}