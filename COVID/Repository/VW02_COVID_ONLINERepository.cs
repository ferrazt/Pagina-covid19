using COVID.Context;
using COVID.Interface;
using COVID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Repository
{
    public class VW02_COVID_ONLINERepository : IVW02_COVID_ONLINE
    {
        public COVIDContext _db { get; set; }

        public VW02_COVID_ONLINERepository(COVIDContext db) : base()
        {
            _db = db;
        }

        public IEnumerable<VW02_COVID_ONLINE> Listar()
        {
            var model = _db.VW02_COVID_ONLINE.ToList();
            return model;
        }
    }
}
