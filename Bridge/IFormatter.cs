﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
