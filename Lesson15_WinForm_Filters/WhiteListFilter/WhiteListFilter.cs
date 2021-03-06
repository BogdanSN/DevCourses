﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson15_WinForm_Filters
{
    public class WhiteListFilter : IFilterSpecification
    {
        public string IsSatisfiedBy(string person)
        {
            FileHandler fhandler = new FileHandler();
            List<string> white = fhandler.ReadWhiteList();

            for (int i = 0; i < white.Count; i++)
            {
                if (person == white[i])
                {
                    return person;
                }
            }

            return default(string);

        }
    }
}
