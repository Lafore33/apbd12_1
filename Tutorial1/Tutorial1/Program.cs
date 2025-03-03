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
Car car = new Car("Opel", 15123123);
Console.WriteLine(car.model);

class Car
{
    public string model;
    public int weight;

    public Car(string model, int weight)
    {
        this.model = model;
        this.weight = weight;
    }
}

