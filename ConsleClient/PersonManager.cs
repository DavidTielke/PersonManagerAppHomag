namespace ConsleClient;

internal class PersonManager
{
    private readonly PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _repository.Query().Where(p => p.Age < 18);
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository.Query().Where(p => p.Age >= 18);
    }
}