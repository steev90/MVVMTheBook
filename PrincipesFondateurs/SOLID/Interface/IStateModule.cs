﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SOLID.Interface
{
    interface IStateModule
    {
        void SauvegarderConfiguration();
        void ChargerConfiguration();
    }
}
