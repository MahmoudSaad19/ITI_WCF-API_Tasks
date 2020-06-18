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
        [WebGet(UriTemplate ="employees")]
        List<Student> GetStudents();

        [WebGet(UriTemplate ="employee/{id}")]
        [OperationContract]
        Student GetStudent(int id);

        [OperationContract]
        [WebInvoke()]
        void Add(Student student);
        
        [OperationContract]
        [WebInvoke]
        void Edit(Student student);
        
        [OperationContract]
        [WebInvoke]
        void Delete(int id);
    }
}
