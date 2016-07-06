using System;



namespace UsingDependencyService
{
  public class Car
  {
    public Car(string make, string model, int doors)
    {
      Make = make;
      Model = model;
      Doors = doors;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Doors { get; set; }
  }
}

