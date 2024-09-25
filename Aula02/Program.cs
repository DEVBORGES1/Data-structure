using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1

    = new Person("Fabiano Piroli", 26);
    Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Vladmir Ilich Ulyanov";
person2.Age = 70;
Console.WriteLine(person2.Name);

Person person3 = new()
{
    Name = "Leonel Bizola",
    Age = 80
};
Console.WriteLine(person3.Name);

