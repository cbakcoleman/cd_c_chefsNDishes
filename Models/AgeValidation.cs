using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace cd_c_chefsNDishes.Models
{
    public class AdultAgeValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime todayDate = Convert.ToDateTime(value);
            return todayDate <= DateTime.Now.AddYears(-18);
        }
    }
}