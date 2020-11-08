using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


class  primeNumbers
{
	public static void Main(String[] args)
	{
		var isPrime = true;
		Console.Write("Prime Numbers: ");
		for(var i = 2; i <= 100; i++)
		{
			for(var j = 2; j <= 100; j++)
			{
				if(i != j && i % j == 0)
				{
					isPrime = false;
					break;
				}
			}
			if(isPrime)
			{
				Console.Write("\t" +i);
			}
			isPrime = true;
		}
		Console.ReadKey();
	}
}