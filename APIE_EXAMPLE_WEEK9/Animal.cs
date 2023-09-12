
using System.Security.Cryptography.X509Certificates;

namespace APIE_EXAMPLE_WEEK9
{
    //PARENT
    public abstract class Animal
    {
        //eyecol
        //name
        //height
        //gender
        //etc
        //What the anima is IN this PROGRAM

        //ALL ANIMALS HAVE AGE

        //Animals fields as private/protected
        //private int _age;
        //private string _eyeColour;

        ////When an animal is contructed we will assign those fields then
        //public Animal(int age, string eyeColour)
        //{
        //    _age = age;
        //    _eyeColour = eyeColour;
        //}

        //public abstract string Gender { get; set; }

        public abstract AniProps Props { get; set; }

        //ALL ANIMALS MAKE SOUNDS
        //ABSTRACT METHOD 
        //HAS NO BODY BUT IS DEFINED
        //P in APIE
        public abstract void AnimalSound();
    }
}
