using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pField.Text = 53.ToString();
            this.qField.Text = 61.ToString();
            this.eField.Text = 71.ToString();

            int E = Int32.Parse(eField.Text);
            int P = Int32.Parse(pField.Text);
            int Q = Int32.Parse(qField.Text);
            int D = ModulMath.EuclidEx(E, (P - 1) * (Q - 1)).x;
            if (!this.Examination(P, Q, E, D)) return;
            this.dField.Text = D.ToString();
            this.nField.Text = (P * Q).ToString();
            this.w_nField.Text = ((P - 1) * (Q - 1)).ToString();            
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int E = Int32.Parse(eField.Text);
            int P = Int32.Parse(pField.Text);
            int Q = Int32.Parse(qField.Text);
            int D = ModulMath.EuclidEx(E, (P - 1) * (Q - 1)).x;
            if (!this.Examination(P, Q, E, D)) return;
            this.dField.Text = D.ToString();
            this.nField.Text = (P*Q).ToString();
            this.w_nField.Text = ((P - 1) * (Q - 1)).ToString();
        }

        private bool Examination(int P, int Q, int E, int D)
        {
            if (P == Q)
            {
                MessageBox.Show("Error: P = Q");
                return false;
            }
            else if (P <= 1)
            {
                MessageBox.Show("Error: p <= 1");
                return false;
            }
            else if (Q <= 1)
            {
                MessageBox.Show("Error: q <= 1");
                return false;
            }
            else if (P * Q <= 256)
            {
                MessageBox.Show("Error: n is too small");
                return false;
            }
            else if (E <= 1)
            {
                MessageBox.Show("Error: e <= 1");
                return false;
            }
            else if (D <= 1)
            {
                MessageBox.Show("Error: d <= 1");
                return false;
            }
            else if (!ModulMath.IsSimple(P))
            {
                MessageBox.Show("Error: P is not simple");
                return false;
            }
            else if (!ModulMath.IsSimple(Q))
            {
                MessageBox.Show("Error: Q is not simple");
                return false;
            }
            else if (ModulMath.Euclid(E, (P - 1) * (Q - 1)) != 1)
            {
                MessageBox.Show("Error: E and w(n) are not coprime");
                return false;
            }
            else if (ModulMath.Euclid(D, (P - 1) * (Q - 1)) != 1)
            {
                MessageBox.Show("Error: D and w(n) are not coprime");
                return false;
            }
            return true;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            int Hash = HashFunction.GetHash(this.PlainTextField.Text, Int32.Parse(this.nField.Text));

            int P = Int32.Parse(pField.Text);
            int Q = Int32.Parse(qField.Text);
            int E = Int32.Parse(eField.Text);
            int D = Int32.Parse(dField.Text);
            if (!this.Examination(P, Q, E, D)) return;
            Key key = new Key { x = D, n = P * Q };

            this.TranHashField.Text = RSA.Encipher(Hash, key).ToString();
            this.TransmittedTextField.Text = this.PlainTextField.Text;
        }

        private void DecipherHash_Click(object sender, EventArgs e)
        {
            int P = Int32.Parse(pField.Text);
            int Q = Int32.Parse(qField.Text);
            int E = Int32.Parse(eField.Text);
            int D = Int32.Parse(dField.Text);
            if (!this.Examination(P, Q, E, D)) return;
            Key key = new Key { x = E, n = P * Q };

            this.DecipheredHash.Text = RSA.Encipher(Int32.Parse(this.TranHashField.Text), key).ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int Hash = HashFunction.GetHash(this.TransmittedTextField.Text, Int32.Parse(this.nField.Text));
            this.CalcHashField.Text = Hash.ToString();
        }
    }

    public class ModulMath : Object
    { 
        public static int FastExp(int a, int z, int m)
        {
            int x = 1, a1 = a, z1 = z;

            while (z1 != 0)
            {
                while ((z1 % 2) == 0)
                {
                    z1 >>= 1;
                    a1 = (a1 * a1) % m;
                }
                z1 -= 1;
                x = (x * a1) % m;
            }

            return x;
        }

        public static DXY EuclidEx(int a, int b)
        {
            int A = a, B = b, q, r, t, a0 = 1, a1 = 0, b0 = 0, b1 = 1;
            do
            {
                r = a % b;
                q = (int)((a - r) / b);
                a = b;
                b = r;
                t = a0;
                a0 = a1;
                a1 = t - a1 * q;
                t = b0;
                b0 = b1;
                b1 = t - b1 * q;
            }
            while (r != 0);
            return new DXY { d = A * a0 + B * b0, x = a0, y = b0 };
        }

        public static int Euclid(int a, int b)
        {
            int x = 1;
            while (true)
            {
                if (a < b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
                if (a != b)
                {
                    if ((a % 2 == 0) && (b % 2 == 0))
                    {
                        a >>= 1;
                        b >>= 1;
                        x <<= 1;
                    }
                    else if (a % 2 == 0)
                    {
                        a >>= 1;
                    }
                    else if (b % 2 == 0)
                    {
                        b >>= 1;
                    }
                    else 
                    {
                        int temp = b;
                        b = a - b;
                        a = temp;
                    }
                }
                else
                {
                    return x*a;
                }
            }
        }

        public static bool IsSimple(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i <= (int)Math.Truncate(Math.Sqrt(x)); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }

    public class RSA: Object
    {
        public static string Encipher(string PlainText, Key key)
        {
            char[] PlainTextChars = PlainText.ToCharArray();
            for (int i = 0; i < PlainTextChars.Length; i++)
            {
                PlainTextChars[i] = (char)ModulMath.FastExp((Int32)PlainTextChars[i], key.x, key.n);
            }
            string CipherText = new string(PlainTextChars);
            return CipherText;
        }

        public static int Encipher(int number, Key key)
        {
            return (char)ModulMath.FastExp(number, key.x, key.n);
        }
    }

    public class HashFunction : Object
    {
        public static int GetHash(string PlainText, int n)
        {
            int H0 = 2346, H1 = 0;
            char[] PlainTextChars = PlainText.ToCharArray();
            for (int i = 0; i < PlainTextChars.Length; i++)
            {
                H1 = (((Int32)PlainTextChars[i] + H0) * ((Int32)PlainTextChars[i] + H0)) % n;
                H0 = H1;
            }
            return H1;
        }
    }

    public struct Key
    {
        public int x, n;
    }

    public struct DXY
    {
        public int d, x, y;   
    }
}