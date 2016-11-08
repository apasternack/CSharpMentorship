

namespace Homework3
{
    public abstract class Student
    {
        private string studentName;
        private int id;
        protected double averageGrade;

        public Student(string studentName, int id)
        {
            this.studentName = studentName;
            this.id = id;
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public abstract double AverageGrade { get; set; }

    }
}
