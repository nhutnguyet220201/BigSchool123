using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BigSchool_NhutNguyet.ViewModel
{
    public class FutureDate: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            
            return base.IsValid(value);
        }
    }
}