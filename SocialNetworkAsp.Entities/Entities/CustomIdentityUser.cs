using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkAsp.Entities.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        public string ImageUrl { get; set; }

        public bool IsOnline { get; set; }


    }
}
