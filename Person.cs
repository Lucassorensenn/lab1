using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavoriteColour { get; set; }
    public int Age { get; set; }
    public bool IsWorking { get; set; }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name= {FirstName} {LastName}, personId: {PersonId}, {FirstName}'s favorite color is {FavoriteColour}");
    }

    public void ChangeFavoriteColour()
    {
        FavoriteColour = "white";
    }

    public int GetAgeInTenYears()
    {
        return Age + 10;
    }

    public override string ToString()
    {
        return $"PersonId: {PersonId}, Name: {FirstName} {LastName}, Favorite Colour: {FavoriteColour}, Age: {Age}, Is Working: {IsWorking}";
    }
}

class Relation
{
    public enum RelationshipType
    {
        Sister,
        Brother,
        Mother,
        Father
    }

}


class MainClass
{
    static void Main(string[] args)
    {
        // Create Person instances
        Person person1 = new Person { PersonId = 1, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "Red", Age = 30, IsWorking = true };
        Person person2 = new Person { PersonId = 2, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 18, IsWorking = false };
        Person person3 = new Person { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true };
        Person person4 = new Person { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true };

        int avgAge = person1.Age + person2.Age + person3.Age + person4.Age / 4;
        int[]  Ages = {person1.Age, person2.Age, person3.Age,person4.Age};
        int lowestAge = Ages.Min();
        int highAge = Ages.Max();

        // Display Gina’s information
        Console.WriteLine($"2: Gina James's favorite color is {person2.FavoriteColour}\n Personid {person3.PersonId}\n First Name: {person3.FirstName}\n Last Name: {person3.LastName}\n Age: {person3.Age}\n is Working: {person3.IsWorking}\n 1: Ian Brooks favorite color is {person1.FavoriteColour}\n Relation ship between Gina and Mary is: {}\n Relation ship between Ian and Mike is: {}\n Average age is: {avgAge}\n the youngest person is {lowestAge}\n the oldest person is {highAge} personid: {person3}\n Firstname {person3.FirstName}\n Last name:{person3.LastName} Favorite color: {person3.FavoriteColour}\n Age: {person3.Age}\n is working{person3.IsWorking}\n Personid {person4.PersonId}\n First name: {person4.FirstName}\n Last Name{person4.LastName}\n Favorite color: {person4.FavoriteColour}\n Age: {person4.Age}\n is Working{person4.IsWorking}\n personId: {person3.PersonId}\n First name: {person3.FirstName}\n last name: {person3.LastName}\n favorite color: {person3.FavoriteColour}\n Age: {person3.Age}\n is working: {person3.IsWorking}");

        
    }
}
