
namespace _hometask_Class;

public class Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }

    public Animal() { }

    public Animal(string name, string breed, string color, int age)
    {
        Name = name;
        Breed = breed;
        Color = color;
        Age = age;
    }

    public string GetAnimalInfo()
    {
        return $"Name: {Name}, Breed: {Breed}, Color: {Color}, Age: {Age}";
    }
}
