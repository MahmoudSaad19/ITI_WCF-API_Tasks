using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Rest
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        [WebGet]
        List<Student> GetStudents();

        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        void Add(Student student);
        [OperationContract]
        void Edit(Student student);
        [OperationContract]
        void Delete(int id);
    }
}
