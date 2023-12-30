using System;// using system means that you are using system libary wich gives you some useful classes like Console or functions/methods like WriteLine  ect.


//OBS GIVE AGUST,DK, FILIP AND FINLAY an A plz. MAN THOSE PEOPLE ARE fixed like 30 errors. Code diddnt work in benigining becuase i hade like 70 errors
//used GPt for one error that i dint understand how to do it and didnt find the "exact" wya how to fix it. Also iused also templates from previus lessons

// program conciset 
public class Profile  //creating class for getting the user info
{

    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public List<string> Hobbies { get; set; }
    public string Info { get; set; }

    //get and set is Properties. Get is used for returning property value. set asings the new value
    // in this context we are using properties to store user info such as city name ect.
     public Profile(string name, int age, string city, string country, List<string> hobbies, string info)
    {
        Name = name;
        Age = age;
        City = city;
        Country = country;
        Hobbies = hobbies;
        Info = info;
        //converts properties into variable (value)
    }

    //from line 32 up to 62 ish i used methods to  make user input his information 
    //method is block of code that contains of a series of statements 
    public void DisplayHobbies()
    {
        Console.WriteLine("Enter hobbies:");
        Hobbies = Console.ReadLine().Split(',').ToList();
//found a way how to split stings betwen each other instead of the way that u learnd us and its was simple to use 
//split is  a method is used to  create an array of multiple strings by splitting the input string
    }
    public void DisplayCountries()
    {
        Console.WriteLine("Which country have you lived in?");
        Country = Console.ReadLine();
    }
    public void DisplayCities()
    {
        Console.WriteLine("Which city have you lived in?");
        City = Console.ReadLine();
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Enter your profile info. Otherwise, keep it empty:");
        Info = Console.ReadLine();
    }
    public void DisplayProfile()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"Hobbies: {(", ", Hobbies)}");
        Console.WriteLine($"Info: {Info}"); 
    }
}//displayes the user profile adn allows user to fully complete it
class Program
{
   static void Main()

    {
        //allow user for name and age input
        Console.Write("Enter name or nickname: ");
        string name = Console.ReadLine();

        Console.Write("Enter real age: ");
        int age = int.Parse(Console.ReadLine());

        Profile userProfile = new Profile(name, age, "", "", new List<string>(), ""); //
        userProfile.DisplayHobbies();
        userProfile.DisplayCountries();
        userProfile.DisplayCities();
        userProfile.DisplayInfo();
        userProfile.DisplayProfile();
       // Displaying the complete profile information in the conscole and all info
    }
}
