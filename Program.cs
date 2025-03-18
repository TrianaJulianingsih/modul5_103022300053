// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
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
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(1);
        data.PrintAllData();
    }
}
