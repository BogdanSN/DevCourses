﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Files
{
    public class NewPersonEventArgs : EventArgs
    {
        public string person { set; get; }
        public DateTime genTime { set; get; }

    }
}
