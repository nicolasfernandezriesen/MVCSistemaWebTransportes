using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSistemaWebTransportes.Validations
{
    public class CheckValidYear : ValidationAttribute
    {
        public CheckValidYear()
        {
            ErrorMessage = ("El año debe ser mayor a 1998.");
        }

        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year > 1998)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}