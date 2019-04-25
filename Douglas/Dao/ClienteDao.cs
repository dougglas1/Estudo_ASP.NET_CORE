using Dapper;
using Douglas.Dao.Interfaces;
using Douglas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Douglas.UnitOfWork;

namespace Douglas.Dao
{
    public class ClienteDao : IClienteDao
    {
        private UnitOfWorkPattern _unitOfWork;

        public ClienteDao(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            _unitOfWork = unitOfWork as UnitOfWorkPattern;

            if (_unitOfWork == null)
                throw new NotSupportedException("UnitOfWork Factory está nulo.");
        }
        
        public int Inserir(Cliente obj)
        {
            try
            {
                return _unitOfWork._connection.Execute("INSERT INTO CLIENTE (ID, NOME, GENERO, DATA_NASCIMENTO, TELEFONE, DATA_CRIACAO, DATA_ATUALIZACAO) " +
                                       "VALUES (@ID, @NOME, @GENERO, @DATA_NASCIMENTO, @TELEFONE, @DATA_CRIACAO, @DATA_ATUALIZACAO)", obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        public int Atualizar(Cliente obj)
        {
            try
            {
                return _unitOfWork._connection.Execute("UPDATE CLIENTE SET NOME = @NOME, GENERO = @GENERO, DATA_NASCIMENTO = @DATA_NASCIMENTO, TELEFONE = @TELEFONE " +
                                       ",DATA_CRIACAO = @DATA_CRIACAO, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID = @ID", obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        public int ExcluirPorId(double id)
        {
            try
            {
                return _unitOfWork._connection.Execute("DELETE FROM CLIENTE WHERE ID = @ID", 
                    new
                    {
                        ID = id
                    });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        public List<Cliente> BuscarTodos()
        {
            try
            {
                return _unitOfWork._connection.Query<Cliente>("SELECT * FROM CLIENTE").ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        public Cliente BuscarPorId(double id)
        {
            try
            {
                return _unitOfWork._connection.Query<Cliente>("SELECT * FROM CLIENTE WHERE ID = @ID ",
                        new
                        {
                            ID = id
                        }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
    }
}
