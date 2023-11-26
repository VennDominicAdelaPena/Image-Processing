using System;
using System.Drawing;
using System.Windows.Forms;
using WebCamLib;
namespace Image_Processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        Bitmap imageA, colorgreen; //imageB=loaded
        private Device webCam;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fileName = saveFileDialog1.FileName;
            pictureBox2.Image.Save(fileName);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            loaded = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(loaded, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel(i, j, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int grey;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    grey = (pixel.R + pixel.G + pixel.B) / 3;
                    processed.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            pictureBox2.Image = processed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            pictureBox2.Image = processed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int grey;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    grey = (pixel.R + pixel.G + pixel.B) / 3;
                    processed.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            int[] hist = new int[256];

            Color sample;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    sample = processed.GetPixel(i, j);
                    hist[sample.R] = hist[sample.R] + 1;
                }
            }

            Bitmap histG = new Bitmap(256, 800);

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    histG.SetPixel(i, j, Color.White);
                }
            }

            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < Math.Min(hist[i] / 5, 800); j++)
                {
                    histG.SetPixel(i, 799 - j, Color.Black);
                }
            }
            pictureBox2.Image = histG;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int r, g, b, new_r, new_g, new_b;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    r = pixel.R;
                    b = pixel.B;
                    g = pixel.G;
                    new_r = Math.Min(((int)(.393 * r + .768 * g + .189 * b)), 255);
                    new_g = Math.Min(((int)(.349 * r + .686 * g + .168 * b)), 255);
                    new_b = Math.Min(((int)(.272 * r + .534 * g + .131 * b)), 255);
                    processed.SetPixel(i, j, Color.FromArgb(new_r, new_g, new_b));
                }
            }
            pictureBox2.Image = processed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog5.ShowDialog();
        }

        private void openFileDialog5_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog5.FileName);
            pictureBox3.Image = imageA;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //imageA = new Bitmap(openFileDialog5.FileName);
            //pictureBox3.Image = imageA;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    if (subtractvalue > threshold)
                    {
                        processed.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        processed.SetPixel(x, y, backpixel);
                    }
                }
            }
            pictureBox2.Image = processed;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartWebcam();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartWebcam()
        {
            webCam = new Device();
            webCam.ShowWindow(pictureBox1);
            timer1.Start();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopWebcam();
        }

        private void StopWebcam()
        {
            webCam?.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Color pixel;
            if (webCam != null)
            {
                // Capture the current frame from the webcam
                IDataObject data = Clipboard.GetDataObject();
                if (data != null && data.GetDataPresent(DataFormats.Bitmap))
                {
                    loaded = (Bitmap)data.GetData(DataFormats.Bitmap);

                    processed = new Bitmap(loaded.Width, loaded.Height);

                }
                switch (comboBox1.SelectedItem?.ToString())
                {
                    case "Copy":
                        webCam.Sendmessage();
                        for (int i = 0; i < loaded.Width; i++)
                        {
                            for (int j = 0; j < loaded.Height; j++)
                            {
                                pixel = loaded.GetPixel(i, j);
                                processed.SetPixel(i, j, pixel);
                            }
                        }
                        pictureBox2.Image = processed;

                        break;
                    case "GreyScale":
                        webCam.Sendmessage();
                        int grey;
                        for (int i = 0; i < loaded.Width; i++)
                        {
                            for (int j = 0; j < loaded.Height; j++)
                            {
                                pixel = loaded.GetPixel(i, j);
                                grey = (pixel.R + pixel.G + pixel.B) / 3;
                                processed.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                            }
                        }
                        pictureBox2.Image = processed;
                        break;
                    case "Invert":
                        webCam.Sendmessage();
                        for (int i = 0; i < loaded.Width; i++)
                        {
                            for (int j = 0; j < loaded.Height; j++)
                            {
                                pixel = loaded.GetPixel(i, j);
                                processed.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                            }
                        }
                        pictureBox2.Image = processed;
                        break;
                    case "Sepia":
                        webCam.Sendmessage();
                        int r, g, b, new_r, new_g, new_b;
                        for (int i = 0; i < loaded.Width; i++)
                        {
                            for (int j = 0; j < loaded.Height; j++)
                            {
                                pixel = loaded.GetPixel(i, j);
                                r = pixel.R;
                                b = pixel.B;
                                g = pixel.G;
                                new_r = Math.Min(((int)(.393 * r + .768 * g + .189 * b)), 255);
                                new_g = Math.Min(((int)(.349 * r + .686 * g + .168 * b)), 255);
                                new_b = Math.Min(((int)(.272 * r + .534 * g + .131 * b)), 255);
                                processed.SetPixel(i, j, Color.FromArgb(new_r, new_g, new_b));
                            }
                        }
                        pictureBox2.Image = processed;
                        break;
                    case "Subtraction":
                        webCam.Sendmessage();
                        Color mygreen = Color.FromArgb(0, 0, 255);
                        int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
                        int threshold = 5;

                        for (int x = 0; x < loaded.Width; x++)
                        {
                            for (int y = 0; y < loaded.Height; y++)
                            {
                                pixel = loaded.GetPixel(x, y);
                                Color backpixel = imageA.GetPixel(x, y);
                                grey = (pixel.R + pixel.G + pixel.B) / 3;
                                int subtractvalue = Math.Abs(grey - greygreen);
                                if (subtractvalue > threshold)
                                {
                                    processed.SetPixel(x, y, pixel);
                                }
                                else
                                {
                                    processed.SetPixel(x, y, backpixel);
                                }
                            }
                        }
                        pictureBox2.Image = processed;
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            webCam.Stop();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}