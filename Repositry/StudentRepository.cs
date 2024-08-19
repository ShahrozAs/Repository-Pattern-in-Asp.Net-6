using PracticeView.Models;

namespace PracticeView.Repositry
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel>getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentByID(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();   
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>{
            new StudentModel{rollNo=1,Name="Shehroz Ashraf",Gender="Male",standard=16},
            new StudentModel{rollNo=2,Name="Ali Arif",Gender="Male",standard=15},
            new StudentModel{rollNo=3,Name="Bilal Doger",Gender="Male",standard=14},
            new StudentModel{rollNo=4,Name="Ameer Hamza",Gender="Male",standard=15},
            new StudentModel{rollNo=5,Name="Zohaib Jutt",Gender="Male",standard=13}
            };
        }
    }
}
