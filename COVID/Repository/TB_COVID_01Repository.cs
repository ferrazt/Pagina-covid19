using COVID.Context;
using COVID.Interface;
using COVID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Repository
{
    public class TB_COVID_01Repository : ITB_COVID_01
    {
        public COVIDContext _db { get; set; }

        public TB_COVID_01Repository(COVIDContext db) : base()
        {
            _db = db;
        }
        public IEnumerable<TB_COVID_01> Listar()
        {
            var model = _db.TB_COVID_01.ToList();
            return model;
        }


    }
}
