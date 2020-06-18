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
        Student GetStudent(string id);

        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="employee")]
        void Add(Student student);
        
        [OperationContract]
        [WebInvoke(Method ="PUT", UriTemplate ="employee")]
        void Edit(Student student);
        
        [OperationContract]
        [WebInvoke(Method ="DELETE", UriTemplate ="employee/{id}")]
        void Delete(string id);
    }
}
