//APP START
using APIE_EXAMPLE_WEEK9;

Console.WriteLine("WELCOME TO THE ANIMAL APP");

AniProps myDogProps = new AniProps();
myDogProps.name = "Sparky";
myDogProps.gender = "Male";
myDogProps.description = "Sparky is a blueheeler";
myDogProps.age = 2;


Dog myDog = new Dog(myDogProps);
//myDog.SetMyProps(myDogProps);
//Dog myDog = new Dog(2, "Green", myDogProps);

Console.WriteLine($"Age: {myDog.Props.age}, Name:{myDog.Props.name}, Gender: {myDog.Props.gender}, About:{myDog.Props.description}");


//APP END
Console.ReadKey();