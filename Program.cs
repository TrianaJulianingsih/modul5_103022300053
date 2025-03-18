// See https://aka.ms/new-console-template for more information
using System;
public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T Nilai1, T Nilai2, T Nilai3 )
    {
        dynamic temp1 = Nilai1;
        dynamic temp2 = Nilai2;
        dynamic temp3 = Nilai3;
        dynamic terbesar = temp1;
        if (temp2 > terbesar)
        {
            terbesar  = temp2;
        }

        if (temp3 > terbesar)
        {
            terbesar = temp3;
        }

        Console.WriteLine("terbesar: " + terbesar);
    }
}

class Program
{
    static void Main()
    {
        PemrosesData data = new PemrosesData();
      
        data.DapatkanNilaiTerbesar<double>(30,00,53);
    }
}
