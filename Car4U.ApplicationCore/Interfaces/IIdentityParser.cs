﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
