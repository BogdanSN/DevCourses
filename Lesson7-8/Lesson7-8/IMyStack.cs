﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    public interface IMyStack<T> : IBuffer<T>
    {
        void Push(T value);
        T Pop();
      }
}
