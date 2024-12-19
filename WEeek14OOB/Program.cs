Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);  

Dog neighboursdog = new Dog("Good boy");
// Dog is class, but myDog and neighboursdog is object
// string, int but one class that is defined

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursdog.Name}.");

myDog.Rename("Bad Boy");
Console.WriteLine($"Level of happiness: {myDog.levelOfHappiness}");

while (myDog.levelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.TailWag();

Console.WriteLine($"Level of happiness: {myDog.levelOfHappiness}");
class Dog
{
    private string _name = "Kutsu";
    // string
    private int _levelOfHappiness;
    //int
    //constructor available outside class
    public Dog(string name) //name lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }
    // getter
    public string Name
    {
        get { return _name; }
    }
    public int levelOfHappiness
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
    public void TailWag()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}