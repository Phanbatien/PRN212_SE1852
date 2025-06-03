            using System.Collections.Specialized;
            using System.Runtime.Serialization.Formatters;
            using System.Text;
partial class Program // Fixed CS0260 by adding 'partial' modifier  
{
    public delegate int[] MyDelegate(int n);

    static int[] ListEven(int n)
    {
        var list = new List<int>(); // Simplified collection initialization (IDE0028, IDE0090)  
        for (int i = 2; i <= n; i += 2) // Fixed 'For' to 'for' (CS0103) and corrected syntax  
        {
            list.Add(i);
        }
        return list.ToArray();
    }

    static int[] ListPrime(int n)
    {
        var list = new List<int>(); // Simplified collection initialization (IDE0028, IDE0090)  
        for (int i = 2; i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }
            if (count == 2)
                list.Add(i);
        }
        return list.ToArray();
    }

    static void Main(string[] args) // Fixed 'main' to 'Main' and corrected modifiers (CS8803, CS0106, CS8321)  
    {
        Console.OutputEncoding = Encoding.UTF8;
        MyDelegate d1 = new MyDelegate(ListEven);
        int[] result1 = d1(10);
        Console.WriteLine("Danh sách các số chẵn:");
        foreach (int i in result1)
            Console.WriteLine(i);

        d1 = new MyDelegate(ListPrime);
        int[] result2 = d1(10);
        Console.WriteLine("Danh sách các số nguyên tố:"); // Fixed missing semicolon (CS1002)  
        foreach (int i in result2)
            Console.WriteLine(i);
    }

    public static void main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        MyDelegate d1 = new MyDelegate(ListEven);
        int[] result1 = d1(10);
        Console.WriteLine("danh sach cac so chan");
        foreach (int i in result1)
            Console.WriteLine(i);
        d1 = new MyDelegate(ListPrime);
        int[] result2 = d1(10);
        Console.WriteLine("Danh sach ");
    }
}
