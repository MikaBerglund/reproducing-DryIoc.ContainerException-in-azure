using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAppWithDI.Configuration
{
    public class DatabaseOptions
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string ContainerName { get; set; }

    }
}
