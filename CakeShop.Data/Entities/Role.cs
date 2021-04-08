using Microsoft.AspNetCore.Identity;
using System;

namespace CakeShop.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        private string describeRole;

        public string DescribeRole { get => describeRole; set => describeRole = value; }
    }
}
