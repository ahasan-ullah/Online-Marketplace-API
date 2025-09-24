﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RET>
    {
        RET Create(CLASS obj);
      
        RET Update(CLASS obj);

        List<CLASS> Get();

        CLASS Get(ID id);

        bool Delete(ID id);
    }
}