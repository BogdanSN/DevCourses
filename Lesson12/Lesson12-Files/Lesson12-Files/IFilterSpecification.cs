﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    public interface IFilterSpecification
    {
        string IsSatisfiedBy(string personal);
    }
}
