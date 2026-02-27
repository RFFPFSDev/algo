class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Alice", "IT", new DateTime(2020, 5, 1), false),
            new Employee("Bob", "HR", new DateTime(2018, 3, 10), true),
            new Employee("Charlie", "IT", new DateTime(2019, 7, 15), true),
            new Employee("David", "HR", new DateTime(2021, 1, 20), false),
            new Employee("Eve", "Finance", new DateTime(2017, 9, 5), true)
        };

        // Custom Sort
        employees.Sort((a, b) =>
        {
            // 1️⃣ Managers first
            if (a.IsManager != b.IsManager)
                return b.IsManager.CompareTo(a.IsManager);

            // 3️⃣ Hire date (oldest first)
            return a.HireDate.CompareTo(b.HireDate);
        });
        // Eve | Finance | 9/5/2017 | Manager: True
        // Bob | HR | 3/10/2018 | Manager: True
        // Charlie | IT | 7/15/2019 | Manager: True
        // Alice | IT | 5/1/2020 | Manager: False
        // David | HR | 1/20/2021 | Manager: False

        foreach (var e in employees)
        {
            Console.WriteLine($"{e.Name} | {e.Department} | {e.HireDate:d} | Manager: {e.IsManager}");
        }
    }
}

class Employee
{
    public string Name { get; }
    public string Department { get; }
    public DateTime HireDate { get; }
    public bool IsManager { get; }

    public Employee(string name, string dept, DateTime hireDate, bool isManager)
    {
        Name = name;
        Department = dept;
        HireDate = hireDate;
        IsManager = isManager;
    }
}