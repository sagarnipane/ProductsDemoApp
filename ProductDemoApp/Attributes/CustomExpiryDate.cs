using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemoApp.Attributes
{
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class CustomExpiryDate: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dtDate = Convert.ToDateTime(value);
            // DateTime dtToday = DateTime.Today;
            if (dtDate >= DateTime.Today)
                return true;
            else
                return false;
        }
    }
}
