using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPandCVLW3
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        public void Сanny(string filePath)
        {
            try
            {
                Image<Gray, byte> imgInput = new Image<Gray, byte>(filePath);
                Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgInput.Width, imgInput.Height);
                imgOutput = imgInput.Canny(Convert.ToDouble(textBoxThresh.Text), 
                    Convert.ToDouble(textBoxApertureSize.Text), 
                    Convert.ToInt16(textBoxThreshLinking.Text), 
                    checkBoxl2Gradient.Checked);

                CvInvoke.Imshow("CANNY", imgOutput);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void Laplasian(string filePath)
        {
            try
            {
                Image<Gray, byte> imgInput = new Image<Gray, byte>(filePath);
                Image<Gray, float> imgOutput = new Image<Gray, float>(imgInput.Width, imgInput.Height);
                imgOutput = imgInput.Laplace(Convert.ToInt16(textBoxApertureSizeL.Text));

                CvInvoke.Imshow("Laplasian", imgOutput);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void Kirsch(Bitmap img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            for (int i = 1; i < img.Width - 1; i++)
            {
                for (int j = 1; j < img.Height - 1; j++)
                {
                    Color cr = img.GetPixel(i + 1, j);
                    Color cl = img.GetPixel(i - 1, j);
                    Color cu = img.GetPixel(i, j - 1);
                    Color cd = img.GetPixel(i, j + 1);
                    Color cld = img.GetPixel(i - 1, j + 1);
                    Color clu = img.GetPixel(i - 1, j - 1);
                    Color crd = img.GetPixel(i + 1, j + 1);
                    Color cru = img.GetPixel(i + 1, j - 1);
                    int power = getMaxD(cr.R, cl.R, cu.R, cd.R, cld.R, clu.R, cru.R, crd.R);
                    if (power > Convert.ToInt16(textBoxApertureSizeK.Text))
                        bmp.SetPixel(i, j, Color.Black);
                    else
                        bmp.SetPixel(i, j, Color.White);
                }
            }

            this.Invoke((MethodInvoker)delegate () {
                CvInvoke.Imshow("Kirsch", new Image<Rgb, byte>(bmp));
            });
        }
        private int getD(int cr, int cl, int cu, int cd, int cld, int clu, int cru, int crd, int[,] matrix)
        {
            return Math.Abs(matrix[0, 0] * clu + matrix[0, 1] * cu + matrix[0, 2] * cru
               + matrix[1, 0] * cl + matrix[1, 2] * cr
                  + matrix[2, 0] * cld + matrix[2, 1] * cd + matrix[2, 2] * crd);
        }
        private int getMaxD(int cr, int cl, int cu, int cd, int cld, int clu, int cru, int crd)
        {
            int max = int.MinValue;
            for (int i = 0; i < templates.Count; i++)
            {
                int newVal = getD(cr, cl, cu, cd, cld, clu, cru, crd, templates[i]);
                if (newVal > max)
                    max = newVal;
            }
            return max;
        }

        private List<int[,]> templates = new List<int[,]>
        {
           new int[,] {{ -3, -3, 5 }, { -3, 0, 5 }, { -3, -3, 5 } },
           new int[,] {{ -3, 5, 5 }, { -3, 0, 5 }, { -3, -3, -3 } },
           new int[,] {{ 5, 5, 5 }, { -3, 0, -3 }, { -3, -3, -3 } },
           new int[,] {{ 5, 5, -3 }, { 5, 0, -3 }, { -3, -3, -3 } },
           new int[,] {{ 5, -3, -3 }, { 5, 0, -3 }, { 5, -3, -3 } },
           new int[,] {{ -3, -3, -3 }, { 5, 0, -3 }, { 5, 5, -3 } },
           new int[,] {{ -3, -3, -3 }, { -3, 0, -3 }, { 5, 5, 5 } },
           new int[,] {{ -3, -3, -3 }, { -3, 0, 5 }, { -3, 5, 5 } }
        };

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            filePath = openFile.FileName;
            pathTextBox.Text = openFile.FileName;
            examplePictureBox.Image = new Bitmap(filePath);
        }

        private void СannyBtn_Click(object sender, EventArgs e)
        {
            Сanny(filePath);
        }

        private void LaplasianBtn_Click(object sender, EventArgs e)
        {
            Laplasian(filePath);
        }

        private void KirschBtn_Click(object sender, EventArgs e)
        {
            new Thread(() => this.Kirsch(new Bitmap(filePath))).Start();
        }
    }
}
