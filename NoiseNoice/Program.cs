using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace NoiseNoice
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)//image file, output, json file
        {
            var handle = GetConsoleWindow();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (args.Length == 0) {
                Console.WriteLine("GUI is running, Closing the console will close the GUI.");
                ShowWindow(handle, 0);
                Application.Run(new Form1("")); }
            else if (args.Length == 1)
            {
                if (args[0] == "?")
                {
                    Console.WriteLine("How to Use\r\n\r\n" + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + " \"image location\" \"output location\" \".json file location\" ");
                }
                else
                {
                    try
                    {
                        Console.WriteLine("GUI is running, Closing the console will close the GUI.");
                        ShowWindow(handle, 0); Application.Run(new Form1(args[0]));
                    }
                    catch (Exception ex) { Console.WriteLine(ex + "\r\n\r\nHow to Use\r\n\r\n" + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + " \"image location\" \"output location\" \".json file location\" "); }
                }
            }
            else if (args.Length > 1)
            {
                try
                {
                    Image image = Image.FromFile(args[0]);
                    if (args.Length > 2)
                    {
                        importjson(File.ReadAllText(args[2]));
                    }
                    else { change(image); }
                    Console.WriteLine(String.Format("Settings\r\nnp.Division : {0}\r\nnp.Iterations : {1}\r\nnp.Opacity : {2}\r\nnp.RGapX : {3}\r\nnp.RGapY : {4}\r\nnp.np_RNoise.Scale : {5}\r\nnp.np_RNoise.Octaves : {6}\r\nnp.np_RNoise.Persistence : {7}\r\nnp.np_RNoise.Amplifier : {8}\r\nnp.np_RNoise.Frequency : {9}\r\nnp.np_GNoise.Scale : {10}\r\nnp.np_GNoise.Octaves : {11}\r\nnp.np_GNoise.Persistence : {12}\r\nnp.np_GNoise.Amplifier : {13}\r\nnp.np_GNoise.Frequency : {14}\r\nnp.np_BNoise.Scale : {15}\r\nnp.np_BNoise.Octaves : {16}\r\nnp.np_BNoise.Persistence : {17}\r\nnp.np_BNoise.Amplifier : {18}\r\nnp.np_BNoise.Frequency : {19}\r\n", np.Division, np.Iterations, np.Opacity, np.RGapX, np.RGapY, np.np_RNoise.Scale, np.np_RNoise.Octaves, np.np_RNoise.Persistence, np.np_RNoise.Amplifier, np.np_RNoise.Frequency, np.np_GNoise.Scale, np.np_GNoise.Octaves, np.np_GNoise.Persistence, np.np_GNoise.Amplifier, np.np_GNoise.Frequency, np.np_BNoise.Scale, np.np_BNoise.Octaves, np.np_BNoise.Persistence, np.np_BNoise.Amplifier, np.np_BNoise.Frequency));

                    Image tou = new Bitmap(image, image.Width, image.Height);
                    Graphics g = Graphics.FromImage(tou);
                    g.DrawImage(tou, 0, 0);

                    for (int i = 0; i < np.Iterations; i++)
                    {
                        Image noice0 = Program.CreateImage(new Bitmap(image), np.Division);
                        g.DrawImage(Program.SetImageOpacity(noice0, np.Opacity), 0, 0, tou.Width, tou.Height);
                        Console.WriteLine(String.Format("Iteration no.{0}/{1} Done. ", (i + 1), np.Iterations));
                    }

                    tou.Save(args[1]);
                    Environment.Exit(0);
                }
                catch (Exception ex) { Console.WriteLine(ex + "\r\n\r\nHow to Use\r\n\r\n" + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + " \"image location\" \"output location\" \".json file location\" "); }
            }

            Environment.Exit(0);
        }
        public static NoiseProperties np = new NoiseProperties();
        static Random random = new Random();
        public static void change(Image image)
        {
            np.Division = Program.RandomDouble(1, (int)Math.Sqrt(image.Width + image.Height) / 10);
            np.Iterations = random.Next(1, 5);
            np.Opacity = (float)Program.RandomDouble(0, 0.1);
            np.RGapX = random.Next(3);
            np.RGapY = random.Next(3);
            np.np_RNoise.Scale = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 1000);
            np.np_RNoise.Octaves = random.Next((int)Math.Sqrt(image.Width + image.Height) / 4);
            np.np_RNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 10);
            np.np_RNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) * 2);
            np.np_RNoise.Frequency = Program.RandomDouble(0, 1);
            np.np_GNoise.Scale = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 1000);
            np.np_GNoise.Octaves = random.Next((int)Math.Sqrt(image.Width + image.Height) / 4);
            np.np_GNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 10);
            np.np_GNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) * 2);
            np.np_GNoise.Frequency = Program.RandomDouble(0, 1);
            np.np_BNoise.Scale = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 1000);
            np.np_BNoise.Octaves = random.Next((int)Math.Sqrt(image.Width + image.Height) / 4);
            np.np_BNoise.Persistence = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) / 10);
            np.np_BNoise.Amplifier = Program.RandomDouble(0, Math.Sqrt(image.Width + image.Height) * 2);
            np.np_BNoise.Frequency = Program.RandomDouble(0, 1);
        }
        public static double RandomDouble(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public static Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    ColorMatrix matrix = new ColorMatrix();

                    matrix.Matrix33 = opacity;

                    ImageAttributes attributes = new ImageAttributes();

                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static Image CreateImage(Bitmap img, double division = 1)
        {
            Bitmap bmp = new Bitmap(img, new Size(img.Width / (int)division, img.Height / (int)division));
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            int width = bmp.Width;
            int height = bmp.Height;

            int itey = 1;
            int itex = 1;
            double[] scale = { np.np_RNoise.Scale, np.np_GNoise.Scale, np.np_BNoise.Scale };
            int[] octaves = { np.np_RNoise.Octaves, np.np_GNoise.Octaves, np.np_BNoise.Octaves };
            double[] persistence = { np.np_RNoise.Persistence, np.np_GNoise.Persistence, np.np_BNoise.Persistence };
            double[] amplifier = { np.np_RNoise.Amplifier, np.np_GNoise.Amplifier, np.np_BNoise.Amplifier };
            double[] frequency = { np.np_RNoise.Frequency, np.np_GNoise.Frequency, np.np_BNoise.Frequency };
            double[,] noiser = NoiseGenerator.GenerateFractalNoise(width, height, scale[0], octaves[0], persistence[0], amplifier[0], frequency[0]);
            double[,] noiseg = NoiseGenerator.GenerateFractalNoise(width, height, scale[1], octaves[1], persistence[1], amplifier[1], frequency[1]);
            double[,] noiseb = NoiseGenerator.GenerateFractalNoise(width, height, scale[2], octaves[2], persistence[2], amplifier[2], frequency[2]);

            for (int y = 0; y < height; y += itey)
            {
                for (int x = 0; x < width; x += itex)
                {
                    itex = random.Next(1, np.RGapX + 1);
                    itey = random.Next(1, np.RGapY + 1);
                    int index = (y * bmpData.Stride) + (x * 4);

                    byte noiseValuer = (byte)(noiser[x, y] * 255);
                    byte noiseValueg = (byte)(noiseg[x, y] * 255);
                    byte noiseValueb = (byte)(noiseb[x, y] * 255);

                    rgbValues[index] = noiseValueb;
                    rgbValues[index + 1] = noiseValueg;
                    rgbValues[index + 2] = noiseValuer;
                    rgbValues[index + 3] = 255;
                }
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);

            return bmp;
        }
        public static void importjson(string json)
        {
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                np.Division = root.GetProperty("division").GetDouble();
                np.Iterations = (int)root.GetProperty("iterations").GetDouble();
                np.Opacity = (float)root.GetProperty("opacity").GetDouble();
                np.RGapX = root.GetProperty("rgapx").GetInt32();
                np.RGapY = root.GetProperty("rgapy").GetInt32();

                JsonElement R = root.GetProperty("R");
                np.np_RNoise.Scale = R.GetProperty("scale").GetDouble();
                np.np_RNoise.Octaves = R.GetProperty("octaves").GetInt32();
                np.np_RNoise.Persistence = R.GetProperty("persistence").GetDouble();
                np.np_RNoise.Amplifier = R.GetProperty("amplifier").GetDouble();
                np.np_RNoise.Frequency = R.GetProperty("frequency").GetDouble();

                JsonElement G = root.GetProperty("G");
                np.np_GNoise.Scale = G.GetProperty("scale").GetDouble();
                np.np_GNoise.Octaves = G.GetProperty("octaves").GetInt32();
                np.np_GNoise.Persistence = G.GetProperty("persistence").GetDouble();
                np.np_GNoise.Amplifier = G.GetProperty("amplifier").GetDouble();
                np.np_GNoise.Frequency = G.GetProperty("frequency").GetDouble();

                JsonElement B = root.GetProperty("B");
                np.np_BNoise.Scale = B.GetProperty("scale").GetDouble();
                np.np_BNoise.Octaves = B.GetProperty("octaves").GetInt32();
                np.np_BNoise.Persistence = B.GetProperty("persistence").GetDouble();
                np.np_BNoise.Amplifier = B.GetProperty("amplifier").GetDouble();
                np.np_BNoise.Frequency = B.GetProperty("frequency").GetDouble();
            }
        }
        public class NoiseProperties
        {
            double np_Division = 1;
            [Category("Noise")]
            [DisplayName("Resolution Division")]
            [Description("Divides the noise resolution, High values for large images will be faster.")]
            public double Division
            {
                get
                {
                    if (np_Division <= 0)
                    {
                        return np_Division = 1;
                    }
                    else
                    {
                        return np_Division;
                    }
                }
                set
                {
                    if (np_Division <= 0)
                    {
                        np_Division = 1;
                    }
                    else
                    {
                        np_Division = value;
                    }
                }
            }
            float np_Opacity = 0.05f;
            [Category("Noise")]
            [DisplayName("Noise Opacity")]
            [Description("Opacity of the noise to show.")]
            public float Opacity
            {
                get { return np_Opacity; }
                set { np_Opacity = value; }
            }
            int np_RGapX = 0;
            [Category("Noise")]
            [DisplayName("X Random Gap")]
            [Description("Number of Randomized Pixel gap in X Position")]
            public int RGapX
            {
                get { return np_RGapX; }
                set { np_RGapX = value; }
            }
            int np_RGapY = 0;
            [Category("Noise")]
            [DisplayName("Y Random Gap")]
            [Description("Number of Randomized Pixel gap in Y Position")]
            public int RGapY
            {
                get { return np_RGapY; }
                set { np_RGapY = value; }
            }
            int np_Iterations = 1;
            [Category("Noise")]
            [DisplayName("Noise Iterations")]
            [Description("Number of times to put noise")]
            public int Iterations
            {
                get { return np_Iterations; }
                set { np_Iterations = value; }
            }
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public class np_RNoiseC
            {
                double scale = .1;
                [DisplayName("Scale")]
                [Description("Scale of the Noise, Higher number will have more noise.")]
                public double Scale
                {
                    get { return scale; }
                    set { scale = value; }
                }
                int octaves = 3;
                [DisplayName("Octaves")]
                [Description("Octaves of the noise.")]
                public int Octaves
                {
                    get { return octaves; }
                    set { octaves = value; }
                }
                double persistence = .1;
                [DisplayName("Persistence")]
                [Description("Persistence of the noise")]
                public double Persistence
                {
                    get { return persistence; }
                    set { persistence = value; }
                }
                double amplifier = .1;
                [DisplayName("Amplifier")]
                [Description("Amplification of the noise")]
                public double Amplifier
                {
                    get { return amplifier; }
                    set { amplifier = value; }
                }
                double frequency = .1;
                [DisplayName("Frequency")]
                [Description("Frequency of the noise")]
                public double Frequency
                {
                    get { return frequency; }
                    set { frequency = value; }
                }
            }
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public class np_GNoiseC
            {
                double scale = .1;
                [DisplayName("Scale")]
                [Description("Scale of the Noise, Higher number will have more noise.")]
                public double Scale
                {
                    get { return scale; }
                    set { scale = value; }
                }
                int octaves = 3;
                [DisplayName("Octaves")]
                [Description("Octaves of the noise.")]
                public int Octaves
                {
                    get { return octaves; }
                    set { octaves = value; }
                }
                double persistence = .1;
                [DisplayName("Persistence")]
                [Description("Persistence of the noise")]
                public double Persistence
                {
                    get { return persistence; }
                    set { persistence = value; }
                }
                double amplifier = .1;
                [DisplayName("Amplifier")]
                [Description("Amplification of the noise")]
                public double Amplifier
                {
                    get { return amplifier; }
                    set { amplifier = value; }
                }
                double frequency = .1;
                [DisplayName("Frequency")]
                [Description("Frequency of the noise")]
                public double Frequency
                {
                    get { return frequency; }
                    set { frequency = value; }
                }
            }
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public class np_BNoiseC
            {
                double scale = .1;
                [DisplayName("Scale")]
                [Description("Scale of the Noise, Higher number will have more noise.")]
                public double Scale
                {
                    get { return scale; }
                    set { scale = value; }
                }
                int octaves = 3;
                [DisplayName("Octaves")]
                [Description("Octaves of the noise.")]
                public int Octaves
                {
                    get { return octaves; }
                    set { octaves = value; }
                }
                double persistence = .1;
                [DisplayName("Persistence")]
                [Description("Persistence of the noise")]
                public double Persistence
                {
                    get { return persistence; }
                    set { persistence = value; }
                }
                double amplifier = .1;
                [DisplayName("Amplifier")]
                [Description("Amplification of the noise")]
                public double Amplifier
                {
                    get { return amplifier; }
                    set { amplifier = value; }
                }
                double frequency = .1;
                [DisplayName("Frequency")]
                [Description("Frequency of the noise")]
                public double Frequency
                {
                    get { return frequency; }
                    set { frequency = value; }
                }
            }
            private np_RNoiseC np_R = new np_RNoiseC();
            private np_GNoiseC np_G = new np_GNoiseC();
            private np_BNoiseC np_B = new np_BNoiseC();
            [Category("Colors")]
            [DisplayName("Red Noise")]
            [Description("Properties of Red Noise")]
            public np_RNoiseC np_RNoise
            {
                get { return np_R; }
                set { np_R = value; }
            }
            [Category("Colors")]
            [DisplayName("Green Noise")]
            [Description("Properties of Green Noise")]
            public np_GNoiseC np_GNoise
            {
                get { return np_G; }
                set { np_G = value; }
            }
            [Category("Colors")]
            [DisplayName("Blue Noise")]
            [Description("Properties of Blue Noise")]
            public np_BNoiseC np_BNoise
            {
                get { return np_B; }
                set { np_B = value; }
            }
        }
    }

}