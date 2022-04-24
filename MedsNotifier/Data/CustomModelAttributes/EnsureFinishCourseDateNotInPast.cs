using MedsNotifier.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.CustomModelAttributes
{
    public class EnsureFinishCourseDateNotInPast : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var meds = (MedsModel)validationContext.ObjectInstance;
            var finishDate = meds?.FinishMedsDateTime;

            if (finishDate != null && DateTime.Compare((DateTime)finishDate, DateTime.Now) < 0)
                return new ValidationResult("You can't choose the past date.");

            return ValidationResult.Success;
        }
    }
}
