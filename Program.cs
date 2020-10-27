using System;

namespace Function
{
    public class Program
    {
        static void Main()
        {
        }
        static public void Proc1(double a, double b, double c, double d, double g)
        {
            double h = 1.0;
            Console.WriteLine(Double(a, h));
            Console.WriteLine(Double(b, h));
            Console.WriteLine(Double(c, h));
            Console.WriteLine(Double(d, h));
            Console.WriteLine(Double(g, h));
        }
        static public void Proc2(double a, double b, double c, double d, double g)
        {
            double h = 1.0;
            Console.WriteLine(Double(a, h));
            Console.WriteLine(Three(a, h));
            Console.WriteLine(Force(a, h));
            Console.WriteLine(Double(b, h));
            Console.WriteLine(Three(b, h));
            Console.WriteLine(Force(b, h));
            Console.WriteLine(Double(c, h));
            Console.WriteLine(Three(c, h));
            Console.WriteLine(Force(c, h)); 
            Console.WriteLine(Double(d, h));
            Console.WriteLine(Three(d, h));
            Console.WriteLine(Force(d, h)); 
            Console.WriteLine(Double(g, h));
            Console.WriteLine(Three(a, h));
            Console.WriteLine(Force(a, h));
        }
        static public void Proc3(double a, double b, double c, double d)
        {
            double h = 1.0;
            Console.WriteLine(Arf(a, b, h));
            Console.WriteLine(Geom(a, b, h));
            Console.WriteLine(Arf(a, c, h));
            Console.WriteLine(Geom(a, c, h));
            Console.WriteLine(Arf(a, d, h));
            Console.WriteLine(Geom(a, d, h));
        }
        static public void Proc4(double a, double b, double c)
        {
            double h = 1.0;
            Console.WriteLine(P(a, h));
            Console.WriteLine(S(a, h));
            Console.WriteLine(P(c, h));
            Console.WriteLine(S(c, h));
            Console.WriteLine(P(b, h));
            Console.WriteLine(S(b, h));
        }
        static public void Proc5(double a, double b, double c, double d, double g)
        {
            double h = 1.0;
            Console.WriteLine(Leng(a, h));
            Console.WriteLine(SumLeng(a, h));
            Console.WriteLine(Leng(c, h));
            Console.WriteLine(SumLeng(c, h));
            Console.WriteLine(Leng(b, h));
            Console.WriteLine(SumLeng(b, h));
            Console.WriteLine(Leng(d, h));
            Console.WriteLine(SumLeng(d, h));
            Console.WriteLine(Leng(g, h));
            Console.WriteLine(SumLeng(g, h));
        }
        static public void Proc6(double a, double b, double c, double d, double g)
        {
            Console.WriteLine(Change(a));
            Console.WriteLine(Change(c));
            Console.WriteLine(Change(b));
        }
        public (int,int) Proc7(int a, int b, int c)
        {
            return (PlusRight(a, c), PlusRight(a, b));
        }
        static public void Proc8(int a, int b, int c)
        {
            Console.WriteLine(PlusLeft(a, c));
            Console.WriteLine(PlusLeft(a, b));
        }
        static public void Proc9(int a, int b, int c,int d, int f, int g)
        {
            Console.WriteLine(ShiftRight3(a, b, c));
            Console.WriteLine(ShiftRight3(d, f, g));
        }
        static public void Proc10(int a, int b, int c, int d, int f, int g)
        {
            Console.WriteLine(ShiftLeft3(a, b, c));
            Console.WriteLine(ShiftLeft3(d, f, g));
        }
            static public (double, char, double, char, double) ShiftLeft3(double a, double b, double c)
            {
                double g = a;
                a = c;
                c = b;
                b = g;
                return (a, ' ', b, ' ', c);
            }
            static public (double,char,double,char,double) ShiftRight3(double a, double b, double c)
            {
                    double g=a;
                    a = b;
                    b = c;
                    c = g;
                    return (a,' ',b,' ',c);
            }
            static public double PlusLeft(int a, int b)
            {
                for (int J = 1; J <= 1; J++)
                {
                    b *= 10;
                }
                return a + b;
            }
            static public int PlusRight(int a, int b)
            {
                    for (int J = 1; J <= 1; J++)
                    {
                        a *= 10;
                    }
                return a+b;
            }
            static public double Change(double O)
            {
                double k = 0.0;
                double h=0;
                double len = Leng(O, h);
                for(int i = 1; 0 <= len;i++,len--)
                {
                    double l = O % 10;
                    O=O / 10;
                    for(int J = 1; J <= len-1; J++)
                    {
                        l *= 10;
                    }
                    k += l;
                }
                return k;
            }
            static public double Leng(double A, double B)
            {
                while (A != 0)
                {
                    A = A / 10;
                    B++;
                }
                return B;
            }
            static public double SumLeng(double A, double B)
            {
                while (A != 0)
                {
                    B += A % 10;
                    A = A / 10;
                }
                return B;
            }
            static public double P(double A, double B)
            {
                B = A * 3;
                return B;
            }
            static public double S(double A, double B)
            {
                B = (A * A * Math.Sqrt(3)) / 4;
                return B;
            }
            static public double Arf(double A, double B, double C)
            {
                C = (B+A)/2;
                return C;
            }
            static public double Geom(double A, double B, double C)
            {
                C = Math.Sqrt(A * B);
                return C;
            }
            static public double Double(double A, double B)
            {
                B = A * A * A;
                return B;
            }
            static public double Three(double A, double B)
            {
                B = A * A * A;
                return B;
            }
            static public double Force(double A, double B)
            {
                B = A * A * A * A;
                return B;
            }
    }
}
