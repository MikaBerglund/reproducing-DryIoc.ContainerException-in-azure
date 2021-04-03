using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAppWithDI.Configuration
{
    public class AppRootSection
    {

        public DatabaseOptions Data { get; set; }

        public ApplicationOptions Application { get; set; }

    }
}
