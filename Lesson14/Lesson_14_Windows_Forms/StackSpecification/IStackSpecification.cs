﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_Windows_Forms
{
    public interface IStackSpecification
    {
        long Start();
        bool IsFull();
        bool IsEmpty();
        void Push();
        void Pop();
    }
}
