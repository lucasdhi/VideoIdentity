using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CPF { get; set; }
        public string endereço { get; set; }
    }
}
