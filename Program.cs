using System;
    class Eligibility
    {
        static void Main(string[] args)
        {
            int math, phy, chem;
            Console.Write("Enter Maths Marks:");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics Marks:");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Marks:");
            chem = Convert.ToInt32(Console.ReadLine());
            int Sum = math + phy + chem;
            int MP = math + phy;
            if (math >= 65 && phy >= 55 && chem >= 50)
            {
                if (Sum >= 180 || MP >= 140)
                    Console.WriteLine("Student is eligible.");
                else
                    Console.WriteLine("Student is not eligible.");
            }
            else
                Console.WriteLine("Student is not eligible.");
        }
    }

