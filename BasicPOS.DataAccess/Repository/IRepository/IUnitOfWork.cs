﻿using BasicInventory.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInventory.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        IItemRepository Item { get; }
        IStockRepository Stock { get; }
        Task Save();
    }
}
