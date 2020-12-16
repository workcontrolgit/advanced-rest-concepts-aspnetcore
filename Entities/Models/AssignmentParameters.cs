namespace Entities.Models
{
	public class AssignmentParameters : QueryStringParameters
	{
		public AssignmentParameters()
		{
			OrderBy = "DateCreated";
		}
	}
}