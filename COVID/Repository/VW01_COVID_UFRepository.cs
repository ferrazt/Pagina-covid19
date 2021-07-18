using COVID.Context;
using COVID.Interface;
using COVID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Repository
{
    public class VW01_COVID_UFRepository : IVW01_COVID_UF
    {
        public COVIDContext _db { get; set; }

        public VW01_COVID_UFRepository(COVIDContext db) : base()
        {
            _db = db;
        }

        public IEnumerable<VW01_COVID_UF> Listar()
        {
            var model = _db.VW01_COVID_UF.ToList();
            return model;
        }
    }
}
