namespace Demo;

public class Entity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
public class Personne: Entity
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
}

public interface Repository<TKey, TValue> where TValue: Entity
{
    TValue Insert(TValue obj);
    TValue FindOneById(TKey id);
    List<TValue> FindAll();
    TValue Update(TKey id, TValue obj);
    void Delete(TKey id);
}

public class EnfantRepository : Repository<int, Personne>
{
    public Personne Insert(Personne obj)
    {
        throw new NotImplementedException();
    }

    public Personne FindOneById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Personne> FindAll()
    {
        throw new NotImplementedException();
    }

    public Personne Update(int id, Personne obj)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}
public class PersonneRepository : Repository<int, Personne>
{
    public Personne Insert(Personne obj)
    {
        throw new NotImplementedException();
    }

    public Personne FindOneById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Personne> FindAll()
    {
        throw new NotImplementedException();
    }

    public Personne Update(int id, Personne obj)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}