using System;
class NNaturalSum{
    static void Main(String[] args){
        int sum=0;
        String val;
        
          Console.WriteLine("Enter the how many natural numbers you want:");
           int n=int.Parse(Console.ReadLine());
          

        for (int k=0;k<n;k++){
            Console.WriteLine("Enter the user input:");
            val=Console.ReadLine();
           int i=Convert.ToInt32(val);

            sum=sum+i;
        }
        Console.WriteLine("The sum of first 10 natural numbers is:"+sum);

    }

    }
