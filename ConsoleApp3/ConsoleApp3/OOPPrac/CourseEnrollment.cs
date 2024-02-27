using ConsoleApp3.OOPEntities;

namespace ConsoleApp3.OOPPrac
{
    public class CourseEnrollment
    {
        
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; }

        public double CalculateGPA()
        {
            if (Grade == Grade.A)
            {
                return 95;
            }else if (Grade == Grade.B)
            {
                return 87;
            }
            else if (Grade == Grade.C)
            {
                return 79;
            }
            else if (Grade == Grade.D)
            {
                return 69;
            }
            else
            {
                return 59;
            }
        }

    }
}