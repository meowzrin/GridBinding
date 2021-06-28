using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace learningCore.Utilities
{
    public class ValidDomainAttribute : ValidationAttribute
    {
        private readonly string allowedDomain;

        public ValidDomainAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }
        public override bool IsValid(object value)
        {
            string[] s = value.ToString().Split("@");
          return this.allowedDomain.ToUpper()==s[1].ToUpper();
        }
    }
}
