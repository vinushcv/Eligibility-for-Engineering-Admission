using System;
    class Eligibility
    {
        static void Main(string[] args)
        {
           int m1,m2,m3;
           Console.Write("Enter Maths marks:");
           m1=Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter Physics marks:");
           m2=Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter Chemistry marks:");
           m3=Convert.ToInt32(Console.ReadLine());
           int total=m1+m2+m3;
           int mathphy=m1+m2;
           if(m1>=65 && m2>=55 && m3>=50)
           {
            if(total>=180 || mathphy>=140)
            {
                Console.WriteLine("The candidate is eligible for the admission.");
            }
            
           }
           else
           {
            Console.WriteLine("The candidate is not eligible for the admission.");
           }
        }
    }