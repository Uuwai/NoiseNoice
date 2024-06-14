using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Nodes;
namespace NoiseNoice
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1(string ImageFile)
        {
            InitializeComponent();
            if (String.IsNullOrWhiteSpace(ImageFile) == false)
            {
                image = Image.FromFile(ImageFile);
                pictureBox1.Image = image;
                pictureBox1.Size = pictureBox1.Image.Size;
                button1.Enabled = true;
                trackBar1.Enabled = true;
                textBox1.Text = String.Format("Width : {0}\r\nHeight : {1}\r\nTotal Pixels : {2}\r\nRaw Format : {3}\r\nPixel Format : {4}\r\n\r\nHorizontal Resolution : {5}\r\nVertical Resolution : {6}\r\nTotal Resolution : {7}", image.Width,image.Height,image.Width*image.Height,image.RawFormat,image.PixelFormat,image.HorizontalResolution,image.VerticalResolution,image.HorizontalResolution*image.VerticalResolution);
            }
            else
            {



            }

        }

        bool trmjson = false;
        public static Image? image;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (trmjson == false)
            {
                propertyGrid1.SelectedObject = Program.np;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox1.Size = pictureBox1.Image.Size;
                image = pictureBox1.Image;
            }

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                label1.Text = trackBar1.Value.ToString() + "%";
                pictureBox1.Size = new Size(image.Width * trackBar1.Value / 100, image.Height * trackBar1.Value / 100);
            }
            catch { }
        }
        Point initialMousePos;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            initialMousePos = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = initialMousePos.X - e.X;
                int deltaY = initialMousePos.Y - e.Y;
                panel1.AutoScrollPosition = new Point(-panel1.AutoScrollPosition.X + deltaX, -panel1.AutoScrollPosition.Y + deltaY);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Creating Noise...";
            Image tou = new Bitmap(image, image.Width, image.Height);
            Graphics g = Graphics.FromImage(tou);
            g.DrawImage(tou, 0, 0);

            for (int i = 0; i < Program.np.Iterations; i++)
            {
                Image noice0 = await Task.Run(() => Program.CreateImage(new Bitmap(image), Program.np.Division));
                g.DrawImage(Program.SetImageOpacity(noice0, Program.np.Opacity), 0, 0, tou.Width, tou.Height);
                button1.Text = "Creating Noise... Iteration " + (i + 1) + "/" + Program.np.Iterations;
            }
            pictureBox1.Image = tou;
            button1.Text = "Set Noise";
            button1.Enabled = true;
        }


        private void randomValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Program.np.Division = Program.RandomDouble(1, (int)Math.Sqrt(image.Width + image.Height) / 10);
                Program.np.Iterations = random.Next(1, 5);
                Program.np.Opacity = (float)Program.RandomDouble(0, 1);
                Program.np.RGapX = random.Next(4);
                Program.np.RGapY = random.Next(4);
                Program.np.np_RNoise.Scale = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 1000);
                Program.np.np_RNoise.Octaves = random.Next((int)Math.Sqrt(image.Width + image.Height) / 4);
                Program.np.np_RNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 10);
                Program.np.np_RNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) * 2);
                Program.np.np_RNoise.Frequency = Program.RandomDouble(0, 1);
                Program.np.np_GNoise.Scale = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 1000);
                Program.np.np_GNoise.Octaves = random.Next((int)Math.Sqrt(image.Width + image.Height) / 4);
                Program.np.np_GNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 10);
                Program.np.np_GNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) * 2);
                Program.np.np_GNoise.Frequency = Program.RandomDouble(0, 1);
                Program.np.np_BNoise.Scale = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 1000);
                Program.np.np_BNoise.Octaves = random.Next((int)Math.Sqrt(image.Width + image.Height) / 4);
                Program.np.np_BNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 10);
                Program.np.np_BNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) * 2);
                Program.np.np_BNoise.Frequency = Program.RandomDouble(0, 1);
            }
            else
            {
                Size fake = new Size(random.Next(Screen.PrimaryScreen.Bounds.Width), random.Next(Screen.PrimaryScreen.Bounds.Height));
                Program.np.Division = Program.RandomDouble(1, (int)Math.Sqrt(fake.Width + fake.Height) / 10);
                Program.np.Iterations = random.Next(1, 5);
                Program.np.Opacity = (float)Program.RandomDouble(0, 1);
                Program.np.RGapX = random.Next(4);
                Program.np.RGapY = random.Next(4);
                Program.np.np_RNoise.Scale = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) / 1000);
                Program.np.np_RNoise.Octaves = random.Next((int)Math.Sqrt(fake.Width + fake.Height) / 4);
                Program.np.np_RNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) / 10);
                Program.np.np_RNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) * 2);
                Program.np.np_RNoise.Frequency = Program.RandomDouble(0, 1);
                Program.np.np_GNoise.Scale = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) / 1000);
                Program.np.np_GNoise.Octaves = random.Next((int)Math.Sqrt(fake.Width + fake.Height) / 4);
                Program.np.np_GNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) / 10);
                Program.np.np_GNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) * 2);
                Program.np.np_GNoise.Frequency = Program.RandomDouble(0, 1);
                Program.np.np_BNoise.Scale = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) / 1000);
                Program.np.np_BNoise.Octaves = random.Next((int)Math.Sqrt(fake.Width + fake.Height) / 4);
                Program.np.np_BNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) / 10);
                Program.np.np_BNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(fake.Width + fake.Height) * 2);
                Program.np.np_BNoise.Frequency = Program.RandomDouble(0, 1);
            }
            propertyGrid1.SelectedObject = Program.np;
        }
        OpenFileDialog imagefile = new OpenFileDialog();
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagefile.Filter = "Image Files|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|*.*|*.*";
            if (imagefile.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(imagefile.FileName);
                pictureBox1.Image = image;
                pictureBox1.Size = pictureBox1.Image.Size;
                button1.Enabled = true;
                trackBar1.Enabled = true;
                label1.Text = trackBar1.Value.ToString() + "%";
                pictureBox1.Size = new Size(image.Width * trackBar1.Value / 100, image.Height * trackBar1.Value / 100);
                textBox1.Text = String.Format("Width : {0}\r\nHeight : {1}\r\nTotal Pixels : {2}\r\nRaw Format : {3}\r\nPixel Format : {4}\r\n\r\nHorizontal Resolution : {5}\r\nVertical Resolution : {6}\r\nTotal Resolution : {7}", image.Width, image.Height, image.Width * image.Height, image.RawFormat, image.PixelFormat, image.HorizontalResolution, image.VerticalResolution, image.HorizontalResolution * image.VerticalResolution);
            }
        }
        OpenFileDialog openjson = new OpenFileDialog();
        private void openjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openjson.Filter = "JSON|*.json|*.*|*.*";
            openjson.DefaultExt = "json";
            if (openjson.ShowDialog() == DialogResult.OK)
            {
                Program.importjson(File.ReadAllText(openjson.FileName));
                propertyGrid1.SelectedObject = Program.np;
            }
        }
        SaveFileDialog savejson = new SaveFileDialog();
        private void savejsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savejson.DefaultExt = "json";
            if (savejson.ShowDialog() == DialogResult.OK)
            {
                var jsonObject = new JsonObject
                {
                    ["division"] = Program.np.Division,
                    ["iterations"] = Program.np.Iterations,
                    ["opacity"] = Program.np.Opacity,
                    ["rgapx"] = Program.np.RGapX,
                    ["rgapy"] = Program.np.RGapY,
                    ["R"] = new JsonObject
                    {
                        ["scale"] = Program.np.np_RNoise.Scale,
                        ["octaves"] = Program.np.np_RNoise.Octaves,
                        ["persistence"] = Program.np.np_RNoise.Persistence,
                        ["amplifier"] = Program.np.np_RNoise.Amplifier,
                        ["frequency"] = Program.np.np_RNoise.Frequency
                    },
                    ["G"] = new JsonObject
                    {
                        ["scale"] = Program.np.np_GNoise.Scale,
                        ["octaves"] = Program.np.np_GNoise.Octaves,
                        ["persistence"] = Program.np.np_GNoise.Persistence,
                        ["amplifier"] = Program.np.np_GNoise.Amplifier,
                        ["frequency"] = Program.np.np_GNoise.Frequency
                    },
                    ["B"] = new JsonObject
                    {
                        ["scale"] = Program.np.np_BNoise.Scale,
                        ["octaves"] = Program.np.np_BNoise.Octaves,
                        ["persistence"] = Program.np.np_BNoise.Persistence,
                        ["amplifier"] = Program.np.np_BNoise.Amplifier,
                        ["frequency"] = Program.np.np_BNoise.Frequency
                    }
                };

                // Serialize to JSON string
                string jsonString = jsonObject.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(savejson.FileName, jsonString);
            }
        }
        SaveFileDialog saveimage = new SaveFileDialog();
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveimage.Filter = "Image Files|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|*.*|*.*";
            if (saveimage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveimage.FileName);
            }
        }

        private void view100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 100;
            label1.Text = trackBar1.Value.ToString() + "%";
            pictureBox1.Size = new Size(image.Width * trackBar1.Value / 100, image.Height * trackBar1.Value / 100);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 imagedialog = new Form2();
            if (imagedialog.ShowDialog() == DialogResult.OK)
            {
                image = imagedialog.createdimage;
                pictureBox1.Image = image;
                button1.Enabled = true;
                trackBar1.Enabled = true;
                label1.Text = trackBar1.Value.ToString() + "%";
                pictureBox1.Size = new Size(image.Width * trackBar1.Value / 100, image.Height * trackBar1.Value / 100);
                textBox1.Text = String.Format("Width : {0}\r\nHeight : {1}\r\nTotal Pixels : {2}\r\nRaw Format : {3}\r\nPixel Format : {4}\r\n\r\nHorizontal Resolution : {5}\r\nVertical Resolution : {6}\r\nTotal Resolution : {7}", image.Width, image.Height, image.Width * image.Height, image.RawFormat, image.PixelFormat, image.HorizontalResolution, image.VerticalResolution, image.HorizontalResolution * image.VerticalResolution);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutNoiseNoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void githubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process url = new Process();
            url.StartInfo.UseShellExecute = true;
            url.StartInfo.FileName = "https://github.com/Uuwai/NoiseNoice";
            url.Start();
        }
    }
}
