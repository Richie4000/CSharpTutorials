// Student Class

namespace MyFirstASPNet.Models
{
	public class Student
	{
		public int ID { get; set; }
		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Required]
		[Display(Name = "Student Email")]
		[DataType(DataType.EmailAddress)]
		
		public string email { get; set; }
		public int CourseID { get; set; }
	
	
	}
}