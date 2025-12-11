using System;   // 🎯 Grants access to the Console class and core runtime features.

namespace InterfaceQuittableDemo
{
    // 📝 This interface acts as a "contract" that forces any implementing class
    //     to provide a Quit() method. Think of it like an obligation note.
    public interface IQuittable
    {
        void Quit();   // 🛎️ The required Quit method — no body here!
    }

    // 🧑‍💼 Employee class from previous drill, now upgraded with quitting powers.
    //     It inherits from IQuittable, meaning it MUST implement Quit().
    public class Employee : IQuittable
    {
        // 🏷️ Simple auto-properties to keep track of employee identity.
        public int Id { get; set; }            // 🔢 Employee's unique identifier.
        public string FirstName { get; set; }  // 📝 Employee's first name.
        public string LastName { get; set; }   // 📝 Employee's last name.

        // 🚪 This is where we fulfill the "Quit()" contract from IQuittable.
        //     You can make this method do anything you want — here it prints a message.
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} (ID: {Id}) has dramatically quit the job! 😮💼");
        }
    }

    class Program
    {
        // 🚀 Entry point of the console app — everything begins here.
        static void Main(string[] args)
        {
            // 🧱 Creating a new Employee object with fun details.
            Employee emp = new Employee
            {
                Id = 190,
                FirstName = "Maha",
                LastName = "Ahmed"
            };

            // 🎭 POLYMORPHISM MOMENT:
            //    We assign the Employee object to a variable typed as IQuittable.
            //    This is allowed because Employee implements the IQuittable interface.
            IQuittable quittingPerson = emp;

            // 🎙️ Calling Quit() through the interface reference.
            //     The Employee's version of Quit() executes thanks to polymorphism.
            quittingPerson.Quit();

            // 🛑 Keep the console open so the user can admire their handiwork.
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
    }
}
