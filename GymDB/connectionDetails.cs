using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDB
{
    class connectionDetails
    {
        public static readonly string
             dbsource = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                       @"Data Source = ../../../Database/" +
                       @"GymDB.accdb";
    }
}
