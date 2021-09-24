using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
