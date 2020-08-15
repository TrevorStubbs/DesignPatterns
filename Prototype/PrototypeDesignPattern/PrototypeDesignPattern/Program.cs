using System;
using System.ComponentModel.DataAnnotations;

namespace PrototypeDesignPattern
{
    class Program
    {
        public class Person : ICloneable
        {
            public int Age { get; set; }
            public DateTime BirthDate { get; set; }
            public string Name { get; set; }
            public IdInfo IdInfo { get; set; }

            /// <summary>
            /// This Method already does the casting for you.
            /// </summary>
            /// <returns></returns>
            public Person ShallowCopy() // C# calls this type of cloning shallow copying
            {
                return (Person)MemberwiseClone();
            }

            /// <summary>
            /// If this method is used the caller has to cast it into the desired object.
            /// </summary>
            /// <returns></returns>
            public object Clone()
            {
                return MemberwiseClone();
            }

            
            public Person DeepCopy()
            {
                Person clone = (Person)MemberwiseClone();
                clone.IdInfo = new IdInfo(IdInfo.IdNumber);
                //clone.Name = String.Copy(Name);
                clone.Name = Name;
                return clone;
            }
        }

        public class IdInfo
        {
            public int IdNumber { get; set; }

            public IdInfo(int idNumber)
            {
                IdNumber = idNumber;
            }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Age = 42;
            person1.BirthDate = Convert.ToDateTime("1977-01-01");
            person1.Name = "Jack Daniels";
            person1.IdInfo = new IdInfo(666);

            Person person2 = person1.ShallowCopy();
            Person person3 = person1.DeepCopy();

            Console.WriteLine("Person 1 Values: ");
            DisplayValues(person1);
            Console.WriteLine();
            Console.WriteLine("Person 2 Values: ");
            DisplayValues(person2);
            Console.WriteLine();
            Console.WriteLine("Person 3 Values: ");
            DisplayValues(person3);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Test the memory references");
            Console.WriteLine("Person1 vs Person2");
            Console.WriteLine(Object.ReferenceEquals(person1, person2));
            Console.WriteLine("Person2 vs Person3");
            Console.WriteLine(Object.ReferenceEquals(person2, person3));
            Console.WriteLine("Person1 vs Person3");
            Console.WriteLine(Object.ReferenceEquals(person1, person3));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person2.GetHashCode());
            Console.WriteLine(person3.GetHashCode());

            Console.WriteLine();
            Console.WriteLine();


            person1.Age = 32;
            person1.BirthDate = Convert.ToDateTime("1900-01-01");
            person1.Name = "Frank";
            person1.IdInfo.IdNumber = 78787;

            Console.WriteLine("After Changes");
            Console.WriteLine("Person 1 Values: ");
            DisplayValues(person1);
            Console.WriteLine();
            Console.WriteLine("Person 2 Values: ");
            DisplayValues(person2);
            Console.WriteLine();
            Console.WriteLine("Person 3 Values: ");
            DisplayValues(person3);

            Console.WriteLine("Test the memory references of object members");
            Console.WriteLine("Person1.IdInfo vs Person2.IdInfo");
            Console.WriteLine(Object.ReferenceEquals(person1.IdInfo, person2.IdInfo));
            Console.WriteLine("Person2.IdInfo vs Person3.IdInfo");
            Console.WriteLine(Object.ReferenceEquals(person2.IdInfo, person3.IdInfo));
            Console.WriteLine("Person1.IdInfo vs Person3.IdInfo");
            Console.WriteLine(Object.ReferenceEquals(person1.IdInfo, person3.IdInfo));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(person1.IdInfo.GetHashCode());
            Console.WriteLine(person2.IdInfo.GetHashCode());
            Console.WriteLine(person3.IdInfo.GetHashCode());

        }

        public static void DisplayValues(Person person)
        {
            Console.WriteLine($"     Name: {person.Name}, Age: {person.Age}, BirthDate: {person.BirthDate:MM/dd/yy}");
            Console.WriteLine($"     ID: {person.IdInfo.IdNumber}");
        }
    }
}
