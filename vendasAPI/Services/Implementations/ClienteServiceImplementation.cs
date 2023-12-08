using Microsoft.EntityFrameworkCore;
using vendasAPI.Model;
using vendasAPI.Model.Context;

namespace vendasAPI.Services.Implementations
{
    public class ClienteServiceImplementation : IClienteService
    {
        private SQLserverContext _context;

        public ClienteServiceImplementation(SQLserverContext context)
        {
            this._context = context;
        }

        public Cliente Create(Cliente cliente)
        {
            try
            {
                _context.Add(cliente);
                _context.SaveChanges();

            } catch(Exception ex)
            {
                throw ex;
            }
            return cliente;
        }

        public void Delete(int idCliente)
        {
            if (!Exists(idCliente))
            {
                var retorno = true;
            }
            var resultado = _context.Clientes.SingleOrDefault(c => c.Id.Equals(idCliente));
            if (resultado != null)
            {
                try
                {
                    _context.Clientes.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception ex)

                {
                    throw ex;
                }
            }
        }

        public List<Cliente> FindAll()
        {
            return _context.Clientes.ToList();
        }

        public Cliente FindByID(int idCliente)
        {
           return _context.Clientes.SingleOrDefault(c => c.Id.Equals(idCliente));
        }

        public Cliente Update (Cliente cliente)
        {
            //Verificação do cliente (existe ou não)
            if (!Exists(cliente.Id))
            {
                return new Cliente();
            }
            var resultado = _context.Clientes.SingleOrDefault(c => c.Id.Equals(cliente.Id));
                if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(cliente);
                        _context.SaveChanges();
                }
                catch(Exception ex)
                
                {
                    throw ex;
                }       
            }
            return cliente;
        }

        private bool Exists (int idCliente)
        {
            return _context.Clientes.Any (c=>c.Id.Equals (idCliente));
        }
    }
}
