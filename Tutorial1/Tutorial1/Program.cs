// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");


void printNums() {
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }
}

printNums();
Car car = new("Opel", 15123123);
car.GetModel();


class Car
{
    private readonly string model;
    private readonly int weight;

    public Car(string model, int weight)
    {
        this.model = model;
        this.weight = weight;
    }

    public void GetModel() 
    {
        Console.WriteLine(model);
    }

    public int GetWeight()
    {
        return weight;
    }

}
