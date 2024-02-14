using Day2Task3.Business.Abstract;
using Day2Task3.DataAccess.Abstract;
using Day2Task3.Entities;

namespace Day2Task3.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryService;

    public CategoryManager(ICategoryDal categoryService)
    {
        _categoryService = categoryService;
    }

    public void Add(Category category)
    {
        _categoryService.Add(category);
        Console.WriteLine("kurs eklendi: " + category.Name);
    }

    public void Delete(Category category)
    {
        _categoryService.Delete(category);
        Console.WriteLine("Kurs silindi: " + category.Name);
    }

    public void GetAll()
    {
        IEnumerable<Category> categories = _categoryService.GetAll();

        foreach (var category in categories)
        {
            Console.WriteLine(category.Id + " " + category.Name);
        }
    }

    public void Update(Category category )
    {
        _categoryService.Update(category);
        Console.WriteLine("Kurs güncellendi: " + category.Name);
    }
}
