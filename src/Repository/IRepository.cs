namespace Capef.Repository;

public interface IRepository<T>
{
  public IEnumerable<T> ReadAll();

  public T? ReadOne(int id);

  public T Create(T employee);

  public T Update(T employee);

  public void Delete(int id);
}