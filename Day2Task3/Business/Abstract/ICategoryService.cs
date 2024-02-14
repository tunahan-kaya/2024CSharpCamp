using Day2Task3.Entities;

namespace Day2Task3.Business.Abstract;

public interface ICategoryService
{
    public void Add(Category category);
    public void Update(Category category);
    public void Delete(Category category);
    public void GetAll();
}
