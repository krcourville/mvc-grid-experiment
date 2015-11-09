using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcTypescript.MvcWebClient.Entities
{
    public class Employee
    {
        public string EmployeeNumber { get; set; }

        public EmployeeInfo Info { get; set; }

        public JobInfo Job { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                StringBuilder name = new StringBuilder();
                if (!string.IsNullOrWhiteSpace(LastName))
                    name.Append(LastName);
                if (!string.IsNullOrWhiteSpace(FirstName))
                    name.AppendFormat("{0}{1}", name.Length > 0 ? ", " : "", FirstName);
                if (!string.IsNullOrWhiteSpace(MiddleName))
                    name.AppendFormat("{0}{1}", name.Length > 0 ? ", " : "", MiddleName);
                return name.ToString();
            }
        }

        public Gender? Gender { get; set; }

        public DateTime? DoB { get; set; }

        public CryptoString Ssn { get; set; }

        public EmploymentStatus Status { get; set; }

        public double? Salary { get; set; }

        public PayType? PayType { get; set; }

        public WorkType? WorkType { get; set; }

        public string CostCenterCode { get; set; }

        public string JobTitle { get; set; }

        //public List<PriorHours> PriorHours { get; set; }

        public DateTime? ServiceDate { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? RehireDate { get; set; }

        public DateTime? TerminationDate { get; set; }

        public string WorkState { get; set; }

        public string WorkCountry { get; set; }

        //public List<Schedule> WorkSchedules { get; set; }

        public string PayScheduleId { get; set; }
    }
}