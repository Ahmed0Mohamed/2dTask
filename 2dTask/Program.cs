using System;

namespace _2dTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Class2d Operation2d = new Class2d();

                Console.WriteLine("Please enter a choice\n 1-Transformation\n 2-Scaling\n 3-Reflection\n 4-Rotation Arround Axis\n 5-shearing\n 6-exit\n");
                string val;
                val = Console.ReadLine();
                double x, y;
                Console.WriteLine("Please enter x and y\n");
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                if (val == "1")
                {
                    Console.WriteLine("Please enter t1 and t2\n");
                    double t1, t2;

                    t1 = Convert.ToDouble(Console.ReadLine());
                    t2 = Convert.ToDouble(Console.ReadLine());
                    Operation2d.Transformation(x, y, t1, t2);


                }
                else if (val == "2")
                {
                    Console.WriteLine("Please enter t1 and t2\n");
                    double s1, s2;
                    s1 = Convert.ToDouble(Console.ReadLine());
                    s2 = Convert.ToDouble(Console.ReadLine());
                    Operation2d.Scaling(x, y,s1, s2);

                }
                else if (val == "3")
                {
                    Console.WriteLine("Please choose the reflection 1- X-axis , 2- y-axis or 3- Both 'Write Your choice number'\n");

                    val = Console.ReadLine();
                    if (val == "1")
                    {
                        Operation2d.Reflection(x, y, 1, 0);
                    }
                    else if (val == "2")
                    {
                        Operation2d.Reflection(x, y, 0,1);
                    }
                    else
                    {
                        Operation2d.Reflection(x, y,1, 1);
                    }


                }
                else if (val == "4")
                {
                    Console.WriteLine("Please choose the rotation angle\n");
                    double angle;
                    angle = Convert.ToDouble(Console.ReadLine());

                        Operation2d.RotationAroundAxis(x, y, angle);

                }
                else if (val == "5")
                {
                    Console.WriteLine("Please choose the shearing in which axis\n 1-x axis\n 2-y axis\n ");
                    val = Console.ReadLine();
                    double sh1;
                    if (val == "1")
                    {
                        Console.WriteLine("Please enter shear x\n");
                        sh1 = Convert.ToDouble(Console.ReadLine());
                        Operation2d.Shearing(x, y, sh1,0);
                    }
                    else if (val == "2")
                    {
                        Console.WriteLine("Please enter shear y \n");
                        sh1 = Convert.ToDouble(Console.ReadLine());
                        Operation2d.Shearing(x, y, 0, sh1);
                    }
       
                }
                else if (val == "6")
                {
                   break;
                }
                else
                {
                    Console.WriteLine("invalid choice\n");
                    continue;
                }
                Operation2d.Print();
            }
        }
    }
}
