﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Logger
    {
        // default konstruktor
        public Logger()
        {
            LogPosts = new List<string>();
        }

        //metod

        public void Log(string message)
        {
            // med add så adderas all värde från string message i listan LogPosts
            LogPosts.Add(message);
        }        //List property        public List<string> LogPosts { get; private set; }
    }
}
