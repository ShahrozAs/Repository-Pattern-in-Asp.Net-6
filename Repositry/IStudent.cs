using PracticeView.Models;

namespace PracticeView.Repositry
{
    public interface IStudent
    {
        public List<StudentModel> getAllStudents();

      public StudentModel getStudentByID(int id);

    }
}
