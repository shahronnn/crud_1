using person;

namespace perser;
public class PersonService
{
    List<Person> persons=new List<Person>();

    public List<Person> GetAllPersons()=> persons;
    
    public void AddNewPerson(Person person)=> persons.Add(person);

    public void UpdatePerson(Person model)
    {
        var person=persons.FirstOrDefault(x => x.ID == model.ID);
        if (person == null)
        {
            System.Console.WriteLine("Person not found!");
        }
        person.FirstName = model.FirstName;
        person.LastName = model.LastName;
        person.Age = model.Age;
    }

    public Person GetPersonById(int id)
    {
        var person = persons.FirstOrDefault(x => x.ID == id);
        if (person == null)
        {
            System.Console.WriteLine("Person not found!");
        }
        return person;
    }

    public void DeletePerson(int id)
    {
        var person = persons.FirstOrDefault(x => x.ID == id);
        persons.Remove(person);
    }
}