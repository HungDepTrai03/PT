﻿using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IDatLichrepo
    {
        public bool Adddate(DatLich1 dl);
        public bool Deletedate(DatLich1 dl);

        public List<DatLich1> GetAllDatlich();
    }
}
