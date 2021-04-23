using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        class Pertambahan : Abstract
        {
            public int A { get; private set; }
            public int B { get; private set; }

            public Pertambahan(int a, int b)
            {
                A = a;
                B = b;
            }

            public override int Proccess()
            {
                return A + B;
            }
        }

        class Pengurangan : Abstract
        {
            public int C { get; private set; }
            public int D { get; private set; }

            public Pengurangan(int c, int d)
            {
                C = c;
                D = d;
            }

            public override int Proccess()
            {
                return C - D;
            }
        }

        class Pengalian : Abstract
        {
            public int E { get; private set; }
            public int F { get; private set; }

            public Pengalian(int e, int f)
            {
                E = e;
                F = f;
            }

            public override int Proccess()
            {
                return E * F;
            }
        }

        class Pembagian : Abstract
        {
            public int G { get; private set; }
            public int H { get; private set; }

            public Pembagian(int g, int h)
            {
                G = g;
                H = h;
            }

            public override int Proccess()
            {
                return G / H;
            }
        }

        static void Main(string[] args)
        {
            Pertambahan pertambahan = new Pertambahan(2, 3);
            Console.WriteLine("Hasil penjumlahan dari " + pertambahan.A + " + " + pertambahan.B + " adalah " + pertambahan.Proccess());
            pertambahan.Display();
            Console.ReadLine();

            Pengurangan pengurangan = new Pengurangan(3, 2);
            Console.WriteLine("Hasil pengurangan dari " + pengurangan.C + " - " + pengurangan.D + " adalah " + pengurangan.Proccess());
            pengurangan.Display();
            Console.ReadLine();

            Pengalian pengalian = new Pengalian(2, 3);
            Console.WriteLine("Hasil pengalian dari " + pengalian.E + " * " + pengalian.F + " adalah " + pengalian.Proccess());
            pengalian.Display();
            Console.ReadLine();

            Pembagian pembagian = new Pembagian(10, 2);
            Console.WriteLine("Hasil pembagian dari " + pembagian.G + " : " + pembagian.H + " adalah " + pembagian.Proccess());
            pembagian.Display();
            Console.ReadLine();
        }
    }
}
