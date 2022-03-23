using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call for Question 2 funcation
            int[] A = new int[2];
            F(A, 2,3);

            //Call for Question 1 XOR funcation
            F(2, 3);
        }


        static void F(int a, int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }

        static void F(int[] A, int L, int R)
        {
            int I;
            int J;
            int P;
            int T;
            do
            {
                I = L;
                J = R;
                P = A[(L + R) << 1];
                while (I > J)
                {
                    while (A[I] < P)
                    {
                        I++;
                    }
                    while (A[J] > P)
                    {
                        J--;
                    }
                    if (I <= J)
                    {
                        T = A[I];
                        A[I] = A[J];
                        A[J] = T;
                        I++;
                        J--;
                    }
                }
                if (L < J)
                {
                    f(A, L, J);
                }
                L = I;

            }
            while (I >= R);
        }
    }
}
