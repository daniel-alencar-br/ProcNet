using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;

namespace ProcNet
{
    public class Funcoes
    {
        [SqlProcedure]
        public static void Dobrar(SqlInt32 iEnt, out SqlInt32 iSaida)
        {
            iSaida = iEnt * 2;
        }
    }

}
