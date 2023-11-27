using System.Text.RegularExpressions;

namespace Struct_Enum_Upcasting_Downcasting.Domain
{
    public class Group:Student
    {
        public string GroupNo { 
            get
            {
                return _groupno;
            }
            set
            {
                if(CheckGroupNo(value)) { 
                    _groupno = value;
                    return;
                }
                else
                {
                    Console.WriteLine("Group name doesn't match as wanted");
                }
            }
        }
        private string _groupno {  get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                    return;
                }
                else if (value < 5)
                {
                    Console.WriteLine("The number of students is under 5");
                    return;
                }
                Console.WriteLine("Error...");
            }
        }
        private int _studentLimit { get; set; }
        private Student[] _students = new Student[0];
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        public bool CheckGroupNo(string groupNo)
        {
            return new Regex(@"^[A-Z]{2}[0-9]{3}$").IsMatch(groupNo);
        }
        public void AddStudent(Student student)
        {
            if (_students.Length >= StudentLimit) return;
            Array.Resize(ref _students, _students.Length+1);
            _students[_students.Length-1] = student;
            if (_students.Length > StudentLimit)
            {
                Console.WriteLine("Group is full");
                return;
            }
                Console.WriteLine(student.StudentInfo()+" "+"added");
            
        }
        public void GetStudent(int id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id)
                {
                    Console.WriteLine(student.StudentInfo());
                    return;
                }
            }
            Console.WriteLine($"{id} ID Not found 404");
        }
        public void GetAllStudents()
        {
            foreach(var stu in _students)
            {
                Console.WriteLine(stu.StudentInfo());
            }
        }
    }
}
