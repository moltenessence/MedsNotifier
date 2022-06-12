using MedsNotifier.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.CustomModelAttributes
{
    public class DosageAmountValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var meds = (MedsModel)validationContext.ObjectInstance;
            var singleDosage = meds?.SingleDosage;
            var amountOfDoses = meds?.DosesPerDayAmount;

            if (singleDosage<=0 || amountOfDoses <=0) return new ValidationResult("The data about dosage isn't valid!");

            return ValidationResult.Success;
        }
    }
}
