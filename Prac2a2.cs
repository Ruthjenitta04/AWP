using System;

class Demo
{
    public void func()
    {
        const double conversionRate = 74.50; 

        
        Console.Write("Enter amount in USD: ");
        double usdValue = Convert.ToDouble(Console.ReadLine());
        
        
        double inrValue = usdValue * conversionRate;

        
        Console.WriteLine("USD {0} = INR {1:0.00}", usdValue, inrValue);
    }
}
class Prac2a2
{
    public static void Main()
    {
        Demo obj1=new Demo();
	obj1.func();
    }
}
 