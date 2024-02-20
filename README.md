# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:
### Step1: 
Get the maths, chemistry and physics marks from the user using ReadLine().
### Step2: 
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180

### Step3:
Calculate the sum of physics and maths and check the condition

### Step4:
Calculate the total marks then calculate maths and physics combined
### Step5:

### Step6:

## Program:
```c#
﻿using System;
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
```
## Output:


## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed

