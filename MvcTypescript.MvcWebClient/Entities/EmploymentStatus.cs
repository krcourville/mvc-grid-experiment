using System.ComponentModel;

namespace MvcTypescript.MvcWebClient.Entities
{
    public enum EmploymentStatus
    {
        [Description("Active")]
        Active = EmploymentStatusValue.Active,

        [Description("Inactive")]
        Inactive = EmploymentStatusValue.Inactive,

        [Description("Terminated, Retired or Layoff")]
        Terminated = EmploymentStatusValue.Terminated,

        [Description("Leave")]
        Leave = EmploymentStatusValue.Leave
    }
}