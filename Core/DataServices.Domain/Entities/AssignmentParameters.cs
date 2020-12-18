namespace DataServices.Core.Domain.Entities
{
	public class AssignmentParameters : QueryStringParameters
	{
		public AssignmentParameters()
		{
			OrderBy = "DateCreated";
		}
	}
}