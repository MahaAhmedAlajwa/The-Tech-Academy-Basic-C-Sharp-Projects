using System;   // 🎯 Pulling in System so we get access to Console and basic runtime tools.

namespace EmployeeComparisonApp
{
    // 🧑‍💼 The Employee class models a simple worker with an ID and their name details.
    class Employee
    {
        // 🏷️ Auto-properties — simple data holders without extra logic.
        public int Id { get; set; }            // 🔢 Unique Employee ID.
        public string FirstName { get; set; }  // 📝 First name.
        public string LastName { get; set; }   // 📝 Last name.

        // 🧪 Overloading the == operator so that comparing two Employee objects
        //     directly uses their ID values instead of reference comparison.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // 🛡️ Safety first: check if they reference the same memory location.
            if (ReferenceEquals(emp1, emp2))
                return true;   // ✨ Same object? They are absolutely equal.

            // 🚫 If either one is null, but not both, they cannot be equal.
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // 🎯 Final comparison: equality depends ONLY on matching IDs.
            return emp1.Id == emp2.Id;
        }

        // 🔁 Overloading != because operator pairs must be implemented together.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // 🙃 Just return the exact opposite of the == operator.
            return !(emp1 == emp2);
        }

        // 🧹 Overriding Equals() ensures proper logical comparison when using .Equals().
        public override bool Equals(object obj)
        {
            // 📌 Attempt to convert incoming object into an Employee.
            Employee other = obj as Employee;

            // 🚫 If conversion fails, they're not equal.
            if (other == null)
                return false;

            // 🎯 Again — comparison based solely on ID.
            return this.Id == other.Id;
        }

        // 🔐 Overriding GetHashCode() since Equals() was overridden.
        public override int GetHashCode()
        {
            // 🤝 Use ID as the basis for the hash to stay consistent with Equals().
            return this.Id.GetHashCode();
        }
    }

    class Program
    {
        // 🚪 Application entry point — everything starts here.
        static void Main(string[] args)
        {
            // 🧱 Crafting the first Employee with customized identity values.
            Employee empA = new Employee
            {
                Id = 101,
                FirstName = "Maha",
                LastName = "Ahmed"
            };

            // 🧱 Crafting the second Employee — alter ID to test equality.
            Employee empB = new Employee
            {
                Id = 102,
                FirstName = "Ahmed",
                LastName = "AlAjwa"
            };

            // 🧪 Using our overloaded == operator to compare Employee objects by ID.
            bool areEqual = empA == empB;
            Console.WriteLine($"Are Employee A and Employee B equal? ➜ {areEqual}");

            // 🔁 Testing the != operator for completeness.
            bool areNotEqual = empA != empB;
            Console.WriteLine($"Are Employee A and Employee B NOT equal? ➜ {areNotEqual}");

            // 🛑 Pausing to avoid an abrupt console disappearance.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
