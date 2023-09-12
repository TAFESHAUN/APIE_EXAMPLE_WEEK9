
using System.Linq.Expressions;

namespace APIE_EXAMPLE_WEEK9
{
    //CHILD DOG <- ANIMAL
    public class Dog : Animal // I in APIE
    {
        //VALUE OF GENDER LOCAL DOG
        //string _gender;
        //string _name;
        //string _description;
        //int _age;

        //Priavte OR kept secret value for age on a dog
        //private int _age;

        ////Public access modifier to age
        //public int Age
        //{
        //    get => _age; set => _age = value;   
        //}

        //int Age { get; set; }
        //METHOD TO EXPOSE AGE


        //_dogProps
        AniProps dogProps; 
        //private string eyecolor;

        //public override string Gender { get => gender; set => Gender = gender; }
        public override AniProps Props
        {
            get { return dogProps; }//READ Values are the local dog properties
            set { dogProps = value; }//WRITE Values are the local dog properites
        }

        //SET Object Properties when we make the objects
        public Dog(AniProps props) //: base(age,eyeColour) int age, string eyeColour,
        {
            dogProps = props;
            //eyecolor = eyeC;
        }

        //METHOD THAT SETS PROPS later
        public void SetMyProps(AniProps someprops)
        {
            try{
                if (someprops.age != null)
                {
                    dogProps.age = someprops.age;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            dogProps.name = someprops.name;
            dogProps.gender = someprops.gender;
            dogProps.description = someprops.description;
        }


        //P in APIE
        public override void AnimalSound()
        {
            Console.WriteLine("THE DOG BARKS!");
        }
    }
}
