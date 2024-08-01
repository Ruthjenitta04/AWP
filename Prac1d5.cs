class Demo
{
	public void func()
	{
		System.Console.Write("Enter a number: ");
		int num=System.Convert.ToInt32(System.Console.ReadLine());
		int reversedNum=0, sumOfDigits=0;

		while(num!=0)
		{
			int digit=num%10;
			reversedNum=reversedNum*10+digit;
			sumOfDigits +=digit;
			num/=10;
		}
	
		System.Console.WriteLine("Reversed number:{0}",reversedNum);
		System.Console.WriteLine("Sum of Digits:{0}",sumOfDigits);
		
	}
}
class Prac1d5
{
	public static void Main(string[] args)
	{
		Demo obj1=new Demo();
		obj1.func();	
	 }
} 