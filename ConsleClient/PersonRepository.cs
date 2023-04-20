namespace ConsleClient;

internal class PersonRepository
{
    private readonly FileLoader _loader;
    private readonly PersonParser _parser;

    public PersonRepository()
    {
        _loader = new FileLoader();
        _parser = new PersonParser();
    }

    public IQueryable<Person> Query()
    {
        var lines = _loader.LoadLines("data.csv");
        var persons = _parser.Parse(lines);
        return persons.AsQueryable();
    }
}