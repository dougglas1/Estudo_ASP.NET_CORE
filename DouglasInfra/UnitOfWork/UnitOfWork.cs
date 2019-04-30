using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DouglasInfra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private SqlConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        public UnitOfWork()
        {
            _connection = new SqlConnection(GetConnectionString("SQLConnection"));
            _connection.Open();
        }

        private String GetConnectionString(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentException(connectionString);

            try
            {
                //return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
                return @"Data Source=DESKTOP-DGNEF60\SQLEXPRESS;Initial Catalog=DOUGLASBD;Integrated Security=True;User Id=UserDouglas;Password=douglas123;";
            }
            catch (Exception)
            {
                //throw new ConfigurationErrorsException($"String de conexão {connectionString} não foi encontrada no arquivo de configuração.");
                throw new ArgumentException("Conexão não encontrada");
            }
        }

        public IDbTransaction Transaction => _transaction;
        public SqlConnection Connection => _connection;


        /// <summary>Inicia uma nova transação</summary
        public void Begin() => _transaction = _connection.BeginTransaction();

        /// <summary>Comita as alterações feitas na transação</summary
        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        /// <summary>Descarta as alterações feitas na transação</summary
        public void Rollback() => _transaction.Rollback();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
