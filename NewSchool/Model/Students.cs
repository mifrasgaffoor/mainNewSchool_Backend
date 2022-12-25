using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace NewSchool.Model
{
    public class Students
    {

        [Key]
        public int Id { get; set; }
   
        public string Name { get; set; }
       
        public int Address { get; set; }    

        public string PhoneNumber { get; set; }

    }
}
