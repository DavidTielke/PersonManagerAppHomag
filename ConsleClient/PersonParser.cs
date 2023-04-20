namespace ConsleClient;

internal class PersonParser
{
    public IEnumerable<Person> Parse(string[] rawData)
    {
        var persons =  rawData
            .Select(l => l.Split(","))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            });
        return persons;
    }
}