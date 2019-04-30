﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        object GetContext();
        void Save();
    }
}