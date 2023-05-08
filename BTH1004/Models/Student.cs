using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTH1004.Models
{
    [Table("Student")] 
    public class Student
    {
        [Key]
        public string StudentID {get; set;}
        public string StudentName {get; set;}
       public string FacultyID {get; set;}
       [ForeignKey("FacultyID")]
       public Faculty? Faculty {get; set;}

    }    
}       