using perser;
using person;

var odam = new PersonService();
while (true)
{
    System.Console.WriteLine("------- commands ------");
    System.Console.WriteLine();
    System.Console.WriteLine("add      add new Person");
    System.Console.WriteLine("get      show all");
    System.Console.WriteLine("getid    get by id");
    System.Console.WriteLine("delete   delete person");
    System.Console.WriteLine("update   update person");
    System.Console.WriteLine();
    System.Console.WriteLine("------- commands ------");
    System.Console.WriteLine();


    string n = Console.ReadLine();
    if (n == "add")
    {
        Person pers = new Person();
        System.Console.Write("Enter your ID: ");
        pers.ID = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter your firstname: ");
        pers.FirstName = Console.ReadLine();
        System.Console.Write("Enter your lastname: ");
        pers.LastName = Console.ReadLine();
        System.Console.Write("Enter your age: ");
        pers.Age = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();
        odam.AddNewPerson(pers);
    }
    else if (n == "get")
    {
        var d = odam.GetAllPersons();
        foreach (var per in d)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"ID: {per.ID}");
            System.Console.WriteLine($"Fisrtname: {per.FirstName}");
            System.Console.WriteLine($"Lastname: {per.LastName}");
            System.Console.WriteLine($"Age: {per.Age}");
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine();
        }
    }
    else if (n == "getid")
    {
        System.Console.WriteLine();
        System.Console.Write("Enter ID: ");
        var per = odam.GetPersonById(Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine();
        System.Console.WriteLine($"Firstname : {per.FirstName}");
        System.Console.WriteLine($"Lastname : {per.LastName}");
        System.Console.WriteLine($"Age : {per.Age}");
        System.Console.WriteLine();
    }
    else if (n=="delete")
    {
        System.Console.WriteLine();
        System.Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        odam.DeletePerson(id);
    }

    else if (n == "update")
    {
        Person updateperson = new Person();
        System.Console.WriteLine();
        System.Console.Write("Enter ID: ");
        updateperson.ID = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine();
        System.Console.Write("Enter firstname: ");
        updateperson.FirstName = Console.ReadLine();
        System.Console.Write("Enter lastname: ");
        updateperson.LastName = System.Console.ReadLine();
        System.Console.Write("Enter age: ");
        updateperson.Age = Convert.ToInt32(Console.ReadLine());
        odam.UpdatePerson(updateperson);
        System.Console.WriteLine();
    }
}