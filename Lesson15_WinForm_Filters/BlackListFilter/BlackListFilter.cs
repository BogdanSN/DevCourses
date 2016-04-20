﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson15_WinForm_Filters
{
    public class BlackListFilter : IFilterSpecification
    {
        public string IsSatisfiedBy(string person)
        {
            FileHandler fhandler = new FileHandler();
            List<string> black = fhandler.ReadBlackList();

            for (int i = 0; i < black.Count; i++)
            {
                if (person == black[i])
                {
                    return person = null;
                }
            }
            return person;
        }
    }
}
