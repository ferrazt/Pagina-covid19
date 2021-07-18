using COVID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Interface
{
    public interface IVW02_COVID_ONLINE
    {
        IEnumerable<VW02_COVID_ONLINE> Listar();
    }
}
