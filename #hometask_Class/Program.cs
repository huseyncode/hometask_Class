using _hometask_Class;

class Program
{
    static void Main(string[] args)
    {
        //Animal
        Animal animal = new Animal { Name = "It", Breed = "Bulldog", Color = "Qara", Age = 5 };
        Console.WriteLine(animal.GetAnimalInfo());

        //Building
        Building building = new Building { Name = "Empire State", Height = 443.2, Area = 257211, Address = "350 5th Ave, New York, NY 10118, United States" };
        Console.WriteLine(building.GetBuildingInfo());

        //Student
        Student student = new Student
        {
            Name = "John",
            Surname = "Doe",
            Age = 20,
            HomeworkGrades = new int[] { 85, 90, 95 },
            ProjectGrades = new int[] { 80, 85, 90 },
            QuizGrades = new int[] { 75, 80, 85 },
            FinalGrade = 90,
            Continuity = new bool[] { true, true, false, true, true }
        };
        Console.WriteLine(student.GetStudentStatus());

        //Gun
        Gun gun = new Gun { Name = "AK-47", MaxCapacity = 30, CurrentBullet = 30, TotalBullet = 90, Type = "assault" };
        gun.Fire();
        Console.WriteLine(gun.GetGunStatus());
        gun.Reload();
        Console.WriteLine(gun.GetGunStatus());

        //Calculator
        Calculator calculator = new Calculator();
        Console.WriteLine($"Add: {calculator.Add(5, 3)}");
        Console.WriteLine($"Subtract: {calculator.Subtract(5, 3)}");
        Console.WriteLine($"Multiply: {calculator.Multiply(5, 3)}");
        Console.WriteLine($"Divide: {calculator.Divide(5, 3)}");
    }
}
