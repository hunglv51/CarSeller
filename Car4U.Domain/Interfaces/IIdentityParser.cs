using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Car4U.Domain.Interfaces
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
