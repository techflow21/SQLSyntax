namespace SQLSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t Use of Join with two Custom Lists and SQL Syntax \n\t ================================================");

            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "Johnson", Age = 30, City = "New York" },
                new Person { Id = 2, Name = "Janet", Age = 25, City = "Los Angeles" },
                new Person { Id = 3, Name = "Bolade", Age = 35, City = "Chicago" }
            };

            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, PersonId = 1, Amount = 100 },
                new Order { Id = 2, PersonId = 2, Amount = 200 },
                new Order { Id = 3, PersonId = 1, Amount = 300 }
            };

            var result = from person in people
                         join order in orders on person.Id equals order.Id
                         where person.Age <= 30 && order.Amount <= 200
                         select new { person.Name, person.City, order.Amount };

            foreach (var item in result)
                Console.WriteLine($"\n\t Name: {item.Name}, City: {item.City}, Amount: {item.Amount}");

        }
    }

    //////////////////////////////////////////////////////

    /*INSERT INTO users(Id, FirstName, LastName, State)
    VALUES
    (1, 'John', 'Doe', 'Lagos'), 
    (2, 'Jane', 'Doe', 'Oyo'), 
    (3, 'Bob', 'Smith', 'Imo'), 
    (4, 'Emma', 'Johnson', 'Lagos'), 
    (5, 'Michael', 'Brown', 'Ogun'), 
    (6, 'Emily', 'Davis', 'Plateaux'), 
    (7, 'Jacob', 'Miller', ' Ogun'), 
    (8, 'Olivia', 'Wilson', 'Oyo'), 
    (9, 'Ethan', 'Anderson', 'Oyo'), 
    (10, 'Ava', 'Taylor', 'Lagos');*/

    //////////////////////////////////////////////////////

    /*UPDATE users
    SET FirstName = 'NewFirstName', LastName = 'NewLastName', State = 'NewState'
    WHERE Id = X;*/

    //////////////////////////////////////////////////////

    /*SELECT *
    FROM users
    WHERE age >= 18 
    AND State = 'Lagos'*/


    /*SELECT *
    FROM users
    WHERE State = 'Oyo'
    LIMIT 2*/


    /*SELECT TOP 2 *
    FROM users
    WHERE State = 'Oyo'*/

    ///////////////////////////////////////////////////////

    /*DELETE FROM users
    WHERE Id = X;*/

    ///////////////////////////////////////////////////////

    internal class Order
    {
        public int Id { get; internal set; }
        public int PersonId { get; internal set; }
        public int Amount { get; internal set; }
    }


    internal class Person
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int Age { get; internal set; }
        public string City { get; internal set; }
    }
}