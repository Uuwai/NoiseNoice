using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseNoice
{
    public class NoiseGenerator
    {
        static Random random = new Random();
        private static double PerlinNoise(double x, double y)
        {
            int xi = (int)x & 255;
            int yi = (int)y & 255;
            double xf = x - (int)x;
            double yf = y - (int)y;
            double u = Fade(xf);
            double v = Fade(yf);

            int a = (perm[xi] + yi) & 255;
            int b = (perm[xi + 1] + yi) & 255;

            double gradA = Grad(perm[a], xf, yf);
            double gradB = Grad(perm[b], xf - 1, yf);
            double gradC = Grad(perm[a + 1], xf, yf - 1);
            double gradD = Grad(perm[b + 1], xf - 1, yf - 1);

            double lerp1 = Lerp(gradA, gradB, u);
            double lerp2 = Lerp(gradC, gradD, u);

            return Lerp(lerp1, lerp2, v);
        }
        private static double Fade(double t)
        {
            return t * t * t * (t * (t * 6 - 15) + 10);
        }
        private static double Lerp(double a, double b, double t)
        {
            return a + t * (b - a);
        }
        private static double Grad(int hash, double x, double y)
        {
            int h = hash & 15;
            double u = h < 8 ? x : y;
            double v = h < 4 ? y : h == 12 || h == 14 ? x : 0;
            return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
        }
        private static int[] perm = new int[512];
        static void FractalNoise()
        {
            for (int i = 0; i < 512; i++)
            {
                perm[i] = random.Next(512);
            }
        }
        public static double[,] GenerateFractalNoise(int width, int height, double scale, int octaves, double persistence, double ampl, double freq)
        {

            double[,] noise = new double[width, height];
            double amplitude = ampl;
            double frequency = freq;
            double maxValue = 0;

            for (int octave = 0; octave < octaves; octave++)
            {
                FractalNoise();
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        noise[x, y] += PerlinNoise(x * scale * frequency, y * scale * frequency) * amplitude;
                    }
                }

                maxValue += amplitude;
                amplitude *= persistence;
                frequency *= 2;
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    noise[x, y] /= maxValue;
                }
            }

            return noise;
        }
    }
}
