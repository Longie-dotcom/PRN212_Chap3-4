// Create 5 employees, including 4 fulltimes and 1 partime

using OOP;

List<Employee> employee = new List<Employee>();
FulltimeEmployee fulltimeEmployee1 = new FulltimeEmployee()
{
    Name = "Long",
    DOB = new DateTime(1991,1,1)
};
employee.Add(fulltimeEmployee1);
FulltimeEmployee fulltimeEmployee2 = new FulltimeEmployee()
{
    Name = "Longie",
    DOB = new DateTime(1992, 1, 1)
};
employee.Add(fulltimeEmployee2);
FulltimeEmployee fulltimeEmployee3 = new FulltimeEmployee()
{
    Name = "Long Dong",
    DOB = new DateTime(1941, 1, 1)
};
employee.Add(fulltimeEmployee3);
FulltimeEmployee fulltimeEmployee4 = new FulltimeEmployee()
{
    Name = "Longie the Ministry of Education",
    DOB = new DateTime(1891, 1, 1)
};
employee.Add(fulltimeEmployee4);
ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
{
    Name = "Longie partime",
    DOB = new DateTime(1999, 1, 1)
};
employee.Add(parttimeEmployee);

// Read all employees in the employee list
employee.ForEach(e => Console.WriteLine(e));
Console.WriteLine();
// Sort employees by birth date
int i = 0;
int j = 0;
List<Employee> sort = new List<Employee>();
while (i < employee.Count)
{
    while(j < i)
    {
        Employee temp1 = employee[i];
        Employee temp2 = employee[j];
        if (employee[i].DOB.Year > employee[j].DOB.Year)
        {
            employee[i] = temp2;
            employee[j] = temp1;
        }
        j++;
    }
    j = 0;
    i++;
}
employee.ForEach(e => Console.WriteLine(e));


