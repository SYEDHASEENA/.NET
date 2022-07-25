using System;
class NaturalSum{
    static void Main(String[] args){
        int sum=0;
        String val;
        for (int k=0;k<10;k++){
            Console.WriteLine("Enter the user input:");
            val=Console.ReadLine();
           int i=Convert.ToInt32(val);

            sum=sum+i;
        }
        Console.WriteLine("The sum of first 10 natural numbers is:"+sum);

    }

    }
