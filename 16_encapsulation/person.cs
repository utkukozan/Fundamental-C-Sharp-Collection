namespace _16_encapsulation
{
    class Person
    {
        // Encapsulated properties
        private string name;
        private int age;
        private string? socialSecurityNumber;

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Public properties (getters and setters)
        public string Name
        {
            get { return name; }
            // Name can not be set directly in this example, so no setter is provided
        }

        public int Age
        {
            private get { return age; }
            set { age = value; }
        }

        // Private property with a public method to set it
        public string? SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            private set { socialSecurityNumber = value; }
        }

        // Public method to set the private property
        public void SetSocialSecurityNumber(string ssn)
        {
            // You can add validation logic here if needed
            SocialSecurityNumber = ssn;
        }

        // Public method to display the person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Social Security Number: {SocialSecurityNumber}");
        }
    }
}
