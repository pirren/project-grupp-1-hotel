using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Server.Interfaces
{
    public interface IDatabaseSettings
    {
        public string DatabaseName { get; set; }

        public string Connectionstring { get; set; }
    }
}
