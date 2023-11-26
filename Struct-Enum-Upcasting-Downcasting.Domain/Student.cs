namespace Struct_Enum_Upcasting_Downcasting.Domain
{
    public class Student
    {
        public int Id { get; }
        private static int _id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public Student()
        {

        }
        public Student(string fullname, int point)
        {
            Id = ++_id;
            Fullname = fullname;
            Point = point;
        }
        public string StudentInfo()
        {

            if (Point < 0 || Point > 100)
            {
                return $"Student ID:{Id}:{Fullname}'s point can't be {Point}";
            }
            return $"Student ID {Id}, Student name :{Fullname} Student Point :{Point}";
        }
    }
}
