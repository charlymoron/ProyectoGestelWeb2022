using System;
using System.Transactions;
using Dominio.Contracts;
using Dominio.Model;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Impl
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private bool _disposed;
        private GestelWeb2014Context _dbContext;


        public UnitOfWork(GestelWeb2014Context dbContext)
        {
            _dbContext = dbContext;
        }


        protected virtual void Dispose (bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }

            }
            _disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
        }

        public int SaveChanges()
        {
            return SaveChanges(true);
        }

        public int SaveChanges(bool validateOnSaveEnabled)
        {
           
            var c = _dbContext.SaveChanges();
            _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted).Commit();

            return c;

        }
    }
}

