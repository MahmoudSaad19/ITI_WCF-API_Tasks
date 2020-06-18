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
        [WebGet(UriTemplate ="students")]
        List<Student> GetStudents();

        [WebGet(UriTemplate ="student/{id}")]
        [OperationContract]
        Student GetStudent(string id);

        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="student")]
        void Add(Student student);
        
        [OperationContract]
        [WebInvoke(Method ="PUT", UriTemplate ="student")]
        void Edit(Student student);
        
        [OperationContract]
        [WebInvoke(Method ="DELETE", UriTemplate ="student/{id}")]
        void Delete(string id);
    }
}
