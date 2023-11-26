using System.Text.RegularExpressions;

namespace Struct_Enum_Upcasting_Downcasting.Domain
{
    public class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value >= 5 || value <= 18)
                {
                    _studentLimit = value;
                }
            }
        }
        private int _studentLimit { get; set; }
        private Student[] _students { get; set; }
        private int StudentCount;
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            _students = new Student[studentLimit];
            StudentCount = 0;
        }

        public bool CheckGroupNo(string groupNo)
        {
            return new Regex(@"^[A-Z]{2}[0-9]{3}$").IsMatch(groupNo);
        }
        /*        public void AddStudent(Student student)
                {
                    if (student.Id > StudentLimit)
                    {
                        _students[StudentCount++] = student;
                    }
                    else
                    {
                        Console.WriteLine("Group is full");
                    }

                }
                public Student GetStudent(int id)
                {
                    foreach (var student in _students)
                    {
                        if (student != null && student.Id == id)
                        {
                            return student;
                        }
                    }
                    return null;
                }*/
        public Student[] GetAllStudents()
        {
            return _students;
        }


    }
}
