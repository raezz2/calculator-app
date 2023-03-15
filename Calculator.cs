class Calculator
{
	static void main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("hasil penambahan: {0} + {1} = {2}", a, b, penambahan(a, b));
		Console.WriteLine("hasil pengurangan: {0} - {1} = {2}", a, b, pengurangan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.Readkey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}