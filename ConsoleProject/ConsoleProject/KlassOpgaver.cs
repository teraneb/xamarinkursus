using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Dyreart
    {
        private string Name;
        private int Legs;
        private int Eyes;
        private AnimalType Type = AnimalType.Fish;
        public string Talk()
        {
            if (Type == AnimalType.Bird)
            {
                return "pip pip";
            }
            {
                return "...";
            } 
        }   

        public Dyreart(string name, int legs, int eyes)
        {
            this.Name = name;
            this.Legs = legs;
            this.Eyes = eyes; 
        }       
    }

    public enum AnimalType
    {
        Bird, Fish
    }


    class Pet
    {
        public Dyreart Kind;
        public string Name;        
    }

    public delegate bool Filter(People name);
    static class PersonExtension
    {
        public static List<People> FilterOut(this List<People> persons, Filter filter)
        {
            List<People> result = new List<ConsoleProject.People>();
            foreach (People person in persons)
            {
                if (!filter.Invoke(person))
                {
                    result.Add(person);
                }
            }
            return result;
        }
    }


    public class People : INotifyPropertyChanged
    {
        public string name;
        public int Birth;
        public Pet Pet;

            public string GetPeopleName()
        {
            return Name;            
        } 
        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Birth;
        }
        public float GetPetEyes()
        {
            return 0; // this.Pet.Kind.eyes;
        }

        //constructor
        public People(string name)
        {
            this.Name = name;
        }
        private People(string name, Pet pet)
        {
            this.Name = name;
            this.Pet = pet;
        }
        public People(string personName, string petName, Dyreart petSpecies)
        {
            this.Name = personName;
            this.Pet = new Pet();
            this.Pet.Name = petName;
            this.Pet.Kind = petSpecies;
        }

        public event EventHandler<string> NameChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNameChanged(string name)
        {
            var handler = NameChanged;
            if (handler != null) handler(this, name);
        }

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
                OnNameChanged(value);
                OnPropertyChanged(nameof(this.Name));
            }
        }


    }

    class Vector
    {
        //felter
        public float x;
        public float y;
        public float z;
        
        //constructor
        public Vector(float x, float y, float z)

        {
            this.x = x;
            this.y = y;
            this.z = z;
        }      

        //metoder
        public float Getlength()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public void Add(Vector other)
        {
            this.x = this.x + other.x;
            this.y = this.y + other.y;
            this.z = this.z + other.z;
        }

        public void Add(params Vector[] others)
        {
            foreach (Vector other in others)
            {
                this.x = this.x + other.x;
                this.y = this.y + other.y;
                this.z = this.z + other.z;
            }
        }
 
    }


}
