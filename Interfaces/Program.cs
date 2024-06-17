﻿public interface IMovable
{
    void Move();
}

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");

    }
}

public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
} 

class Program
{
    static void Main(string[] args)
    {
        IMovable firstCar = new Car();
        IMovable firstBicycle = new Bicycle();

        firstCar.Move();
        firstBicycle.Move();
    }
}




