﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public interface IMyQueue<T> : IBuffer<T>
    {
        void Enqueue(T value);
        T Deq();
    }
}
