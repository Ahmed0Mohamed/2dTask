using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dTask
{
    class Class2d
    {
        double[,] result = new double[3, 1];

        public void Transformation(double x, double y, double t1, double t2)
        {

            double[,] array1 = new double[,] { { 1, 0, t1 }, { 0, 1, t2 }, { 0, 0, 1 } };
            double[,] array2 = new double[,] { { x }, { y }, { 1 } };


            multiply(array1, array2);

        }

        public void Scaling(double x, double y, double s1, double s2)
        {

            double[,] array1 = new double[,] { { s1, 0, 0 }, { 0, s2, 0 }, { 0, 0, 1 } };
            double[,] array2 = new double[,] { { x }, { y }, { 1 } };


            multiply(array1, array2);

        }

        public void RotationAroundAxis(double x, double y, double theta)
        {
            double[,] array1;
            double[,] array2 = new double[,] { { x }, { y }, { 1 } };

            array1 = new double[,] { {Math.Cos((Math.PI / 180) * theta), -Math.Sin((Math.PI / 180) * theta), 0 },{ Math.Sin((Math.PI / 180) * theta), Math.Cos((Math.PI / 180) * theta), 0 }, { 0, 0, 1 } };
            multiply(array1, array2);
        }

        public void multiply(double[,] array1, double[,] array2)
        {
            double temp = 0;
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    temp = 0;
                    for (int k = 0; k < array1.GetLength(1); k++)
                    {
                        temp += array1[i, k] * array2[k, j];
                    }
                    result[i, j] = temp;
                }
            }
        }
        public void Reflection(double x, double y, double Xplane, double yplane)
        {
            double[,] array1;
            double[,] array2 = new double[,] { { x }, { y }, { 1 } };
            if (Xplane == 1)
            {
                array1 = new double[,] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1}};
            }
            else if (yplane == 1)
            {
                array1 = new double[,] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 }};

            }
            else
            {
                array1 = new double[,] { { -1, 0, 0 }, { 0, -1, 0}, { 0, 0, 1 } };
            }
            multiply(array1, array2);
        }
        public void Shearing(double x, double y, double sh1, double sh2)
        {
            double[,] array2 = new double[,] { { x }, { y },{ 1} };
            double[,] array1 = new double[,] { { 1, sh1, 0 }, { sh2, 1, 0 }, { 0, 0, 1 } };
            
            multiply(array1, array2);
        }
        public void Print()
        {
            Console.WriteLine("New Point\n");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.WriteLine(result[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
