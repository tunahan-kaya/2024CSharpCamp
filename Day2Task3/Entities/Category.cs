using Day2Task3.Core.Entities;

namespace Day2Task3.Entities;

public class Category:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
