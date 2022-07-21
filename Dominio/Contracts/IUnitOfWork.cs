using System;
namespace Dominio.Contracts
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        int SaveChanges(bool validateOnSaveEnabled);
    }
}

