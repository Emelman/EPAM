﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public interface ILogger
    {
        void WriteSimpleLine(string line);
        string ReadSimpleLine();
        ConsoleKeyInfo ReadSimpleKey();
    }
}
