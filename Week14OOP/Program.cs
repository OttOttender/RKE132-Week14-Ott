Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);  //myDog on object
//myDog._name = "good boy";

Dog neighboursDog = new Dog("good girl");
//neighboursDog._name = "good girl";


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("bad boy");
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

//myDog.Bark();
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

class Dog //uldise kategooria kirjeldus
{
    private string _name; //field
    private int _levelOfHappiness;

    //constructor
    public Dog(string name) //lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}
 