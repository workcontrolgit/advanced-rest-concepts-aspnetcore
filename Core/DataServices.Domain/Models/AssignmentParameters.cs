namespace DataServices.Domain.Models
{
	public class AssignmentParameters : QueryStringParameters
	{
		public AssignmentParameters()
		{
			OrderBy = "DateCreated";
		}
	}
}