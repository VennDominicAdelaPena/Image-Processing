namespace Image_Processing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();
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
    }
}