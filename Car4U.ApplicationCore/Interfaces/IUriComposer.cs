using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.ApplicationCore.Interfaces
{
   public interface IUriComposer
    {
        string ComposeUri(string uriTemplate);
    }
}
