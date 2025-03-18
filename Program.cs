
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

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data 1 berisi: {storedData[i]}" + $" , yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main()
    {

        PemrosesData data = new PemrosesData();
      
        data.DapatkanNilaiTerbesar<double>(30,00,53);

        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(1);
        data.PrintAllData();

    }
}
