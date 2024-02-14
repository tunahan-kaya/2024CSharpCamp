using Day2Task3.Business.Concrete;
using Day2Task3.DataAccess.Concrete.EntityFramework;
using Day2Task3.Entities;
using System;

class Program
{
    static void Main(string[] args)
    {
        CourseManager courseManager = new CourseManager(new EfCourseDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

        Course course1 = new Course
        {
            CategoryId = 1,
            InstructorId = 1,
            Name = "C# Nesne Tabanlı Programlama",
        };
        Course course2 = new Course
        {
            CategoryId = 1,
            InstructorId = 3,
            Name = "Android Mobil Uygulama Kursu: Kotlin & Java"
        };
        Course course3 = new Course
        {
            CategoryId = 2,
            InstructorId = 2,
            Name = "A2 İngilizce Kursu"
        };

        courseManager.Add(course1);
        courseManager.Add(course2);
        courseManager.Add(course3);

        

        courseManager.GetAll();

        courseManager.Update(new Course
        {
            Id = 1,
            CategoryId = 1,
            InstructorId = 1,
            Name = "C# Windows Form uygulaması geliştirme kursu"
        });
        Console.WriteLine("-----------------Güncellenmiş hali-----------------------");
        courseManager.GetAll();

        Console.WriteLine("-----------------Silinmiş hali-----------------------");
        courseManager.Delete(course1);

        Console.WriteLine("Bütün Kurslar");
        courseManager.GetAll();

        Console.WriteLine("-----------------Kategoriler-----------------------");
        Category category1 = new Category { Name = "Yazılım" };
        Category category2 = new Category { Name = "Dil Öğrenme" };
        categoryManager.Add(category1);
        categoryManager.Add(category2);

        Console.WriteLine("-----------------Kategorileri Getir-----------------------");
        categoryManager.GetAll();
        Console.Read();
    }

}

