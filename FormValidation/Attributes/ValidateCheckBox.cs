﻿
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation.Attributes
{
    public class ValidateCheckBox:ValidationAttribute,IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context) 
        { 
            context.Attributes.Add("data-val-validatecheckbox", ErrorMessage); 
        }
        public override bool IsValid(object? value) 
        { 
            return Convert.ToBoolean(value); 
        }
    }
}
