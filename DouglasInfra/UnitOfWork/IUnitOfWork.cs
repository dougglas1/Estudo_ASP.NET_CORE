using System;
using System.Data;
using System.Data.SqlClient;

namespace DouglasInfra.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDbTransaction Transaction { get; }
        SqlConnection Connection { get; }

        void Begin();
        void Commit();
        void Rollback();
    }
}
