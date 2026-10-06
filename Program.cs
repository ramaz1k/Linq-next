
List<Student> students = new List<Student>
{
new Student { id = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
new Student { id = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
new Student { id = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) }
};


List<Course> courses = new List<Course>
{
new Course { id = 101, Title = "Mathematics", Credits = 4 },
new Course { id = 102, Title = "Computer Science", Credits = 3 },
new Course { id = 103, Title = "Physics", Credits = 4 }
};


List<Enrollment> enrollments = new List<Enrollment>
{
new Enrollment { id = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
new Enrollment { id = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
new Enrollment { id = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
new Enrollment { id = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
new Enrollment { id = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
new Enrollment { id = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) }
};





var persons = new List<Person>()
{

    new Person { Id = 1, Name = "Abubakr", Age = 20, CityId = 1 },
    new Person{Id=2,Name="Ali",Age=22,CityId=2},
    new Person{Id=3,Name="Ahmed",Age=21,CityId=3},
    new Person{Id=4,Name="Aisha",Age=23,CityId=1},
    new Person{Id=5,Name="Fatima",Age=27,CityId=2},
    new Person { Id = 6, Name = "Umar", Age = 30, CityId = 1 }
};

var cityes = new List<City>()
{
    new City{Id=1,Name="Dushanbe"},
    new City{Id=2,Name="Boxtar"},
    new City{Id=3,Name="Islamabad"}
};

// t1
// var res= from student in students
// join enrol in enrollments on student.id equals enrol.StudentId
// join  cours in courses on enrol.CourseId equals cours.id
// where cours.Title == "Mathematics"
// select new
// {
//     StudentName = student.Name,
//     CourseTitle = cours.Title,
//     EnrollmentDate = enrol.EnrollmentDate
// };
// foreach (var item in res)
// {
//     Console.WriteLine($"Student: {item.StudentName}, Course: {item.CourseTitle}, Enrollment Date: {item.EnrollmentDate.ToShortDateString()}");
// }

// t2
// var res=from student in students
// join enrol in enrollments on student.id equals enrol.StudentId
// join cours in courses on enrol.CourseId equals cours.id
// where student.Name=="Charlie"
// select new
// {
//     StudentName = student.Name,
//     CourseTitle = cours.Title,
//     EnrollmentDate = enrol.EnrollmentDate
// };


// foreach (var item in res)
// {
//     Console.WriteLine($"Student: {item.StudentName}, Course: {item.CourseTitle}, Enrollment Date: {item.EnrollmentDate.ToShortDateString()}");
// }

// t3





// 1

// var peopl=from p in persons
//         where p.Age>25
//         select new
//         {
//             Name=p.Name,
//             Age=p.Age
//         };

//     foreach(var i in peopl)
// {
//     System.Console.WriteLine($"Name: {i.Name}, Age: {i.Age}");
// }


// 2

// var people=from p in persons
// orderby p.Age descending
// , p.Name ascending
// select p;

// foreach(var i in people)
// {
//     System.Console.WriteLine($"Name: {i.Name}, Age: {i.Age}");
// }

// 3
// var grouppeople=from grops in persons 
// group grops by grops.Name[0] into groups
// select groups;

// foreach(var i in grouppeople)
// {
//     System.Console.WriteLine($"Буква {i.Key}");
//     foreach(var person in i)
//     {
//         System.Console.WriteLine($" - {person.Name}");
//     }

// }

// 4

// var res=from pers in persons
//     join city in cityes on pers.CityId equals city.Id
//     select new
//     {
//        personname= pers.Name,
//         cityname=city.Name
//     };

//     foreach(var i in res)
// {
    
//     System.Console.WriteLine($"Man :{i.personname} City :{i.cityname}");
// }

// 5
// string vovels="AEIOaeio";
// var res =from per in persons
// where vovels.Contains(per.Name[0])
// select per.Age;

// int totalage =res.Sum();
// System.Console.WriteLine(totalage);


// 6
// var grouppeople=from grops in persons 
// group grops by grops.Name[0] into groups
// select new
// {
//     Key=groups.Key,
//     Count=groups.Count()
// };


// foreach(var i in grouppeople)
// {
//     System.Console.WriteLine($"Буква {i.Key}");
//     System.Console.WriteLine($" - Количество: {i.Count}");
  



// 7
// var res =from city in cityes
// join pers in persons on city.Id equals pers.CityId into personGroup
// select new
// {
    
//     CityName=city.Name,
//     PersonCount=personGroup.Count()
// };

// foreach(var i in res)
// {
//     System.Console.WriteLine($"City : {i.CityName} - Количество людей: {i.PersonCount}");
// }


// 8
var res=from pers in persons
join city in cityes on pers.CityId equals city.Id 
where city.Name.StartsWith("A")&& pers.Age<=7&& pers.Age>=2
select new
{
    PersonName=pers.Name,
    CityName=city.Name,
    Age=pers.Age
};
foreach(var i in res)
{
    System.Console.WriteLine($"Person: {i.PersonName}, City: {i.CityName}, Age: {i.Age}");
}