using MvcTypescript.MvcWebClient.Entities;
using MvcTypescript.MvcWebClient.FormDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient.Models.Forms
{
    public class EmployeeUpsertViewModel
    {
        [Display(Name = "Employee Info")]
        [Icon("~/Content/images/btn-icon-employee-info-reverse.png")]
        public EmployeeInfoViewModel EmployeeInfo { get; set; }
    }

    public class EmployeeInfoViewModelMetaProvider : IFormSectionMetaProvider
    {
        public int GetTotalColumns()
        {
            return 2;
        }
    }


    [FormSectionMetaProvider(typeof(EmployeeInfoViewModelMetaProvider))]
    public class EmployeeInfoViewModel
    {
        // ROW 1

        [Required(AllowEmptyStrings = false)]
        [FormGridMeta(Row = 1, Column = 1)]
        public string FirstName { get; set; }

        [FormGridMeta(Row = 1, Column = 2)]
        public string MiddleName { get; set; }

        // ROW 2

        [Required(AllowEmptyStrings = false)]
        [FormGridMeta(Row = 2, Column = 1)]
        public string LastName { get; set; }

        [Display(Name = "Employee ID")]
        [Required(AllowEmptyStrings = false)]
        [FormGridMeta(Row = 2, Column = 2)]
        public string EmployeeNumber { get; set; }

        // ROW 3

        [DataType(DataType.Date)]
        [Display(Name = "DOB")]
        [FormGridMeta(Row = 3, Column = 1)]
        public DateTime? DoB { get; set; }

        [FormGridMeta(Row = 3, Column = 2)]
        public MilitaryStatus? MilitaryStatus { get; set; }

        // ROW 4
        [FormGridMeta(Row = 4, Column = 1)]
        public Gender? Gender { get; set; }

    }
}