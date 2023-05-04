
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var student = new Student() { Name = "Ahmet", Age = 23 };

    List<Teacher> teachers = new List<Teacher>();

    teachers.Add(new Teacher() { Name = "Ahmet öğretmen" });
    teachers.Add(new Teacher() { Name = "Mehmet öğretmen" });

    student.Teachers = teachers;

    _context.Add(student);

    _context.SaveChanges();

}

