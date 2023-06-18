using System;

public class Class1
{
	public Class1()
	{
		static void Main()
        {
			int m1, m2, m3, m4, total;
			Console.WriteLine("enter runs scored by rohit sharma in four matches");
			m1 = Convert.ToInt32(Console.ReadLine());
			m2 = Convert.ToInt32(Console.ReadLine());
			m3 = Convert.ToInt32(Console.ReadLine());
			m4 = Convert.ToInt32(Console.ReadLine());
			total = m1 + m2 + m3 + m4;
			Console.WriteLine($"runs scored by Rohit sharma are {total}");
        }
	}
}
