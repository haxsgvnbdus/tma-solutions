﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Model
{
    public interface ISoftDeleteable
    {
        bool Deleted { get; set; }
    }
}
