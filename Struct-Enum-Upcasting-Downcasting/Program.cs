#region task-1
/*Student class
- Id
- Fullname
- Point
- StudentInfo() - Student-in bütün məlumatlarını ekrana console-a yazdırır


ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar. Fullname və point olmadan student obyekti yaratmaq olmaz.


Group class
- GroupNo
- StudentLimit - qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.
- Students - Student tipindən bir array-dir özündə student obyektləri saxlayacaq və private olacaq.
- CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə true/false dəyərləri qaytarır. 
                                  Şərtlər: 2 böyük hərf əvvəldə və 3 rəqəmdən ibarət olmalıdır
- AddStudent() - parametr olaraq Student obyekti qəbul edir və gələn student obyektini Group class-ında olan Students arrayinə əlavə edir əgər arrayin uzuluğu StudentLimit-i keçirsə əlavə etməməlidi.
- GetStudent() - parametr olaraq nullable int tipindən bir id dəyəri alacaq və həmin id-li Student obyektini tapıb geriyə qaytaracaq.
- GetAllStudents() - geriyə Student arrayi qaytaracaq.*/
using Struct_Enum_Upcasting_Downcasting.Domain;

Student student1 = new Student("Lorem Ipsum", 85);
Student student2 = new Student("Filankes Filankesov", 88);
Student student3 = new Student("None Null", 90);
Student student4 = new Student("neb snesu4", 85);
Student student5 = new Student("neb snesu4", 85);
Student student6 = new Student("neb snesu4", 85);

Group group = new Group("PP518",5);

group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);
group.AddStudent(student5);
group.AddStudent(student6);

/*Console.WriteLine("<=================>Get Student Method<=================>");
group.GetStudent(5);
Console.WriteLine("<=================>Get All Students Method<=================>");
group.GetAllStudents();*/

#endregion