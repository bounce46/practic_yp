﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSoft.Connection
{
    internal class DataBase
    {
        public static ProSoftEntities ProSoftEntities 
        { get; set; } = new ProSoftEntities();
    }
}