using vendasAPI.Model;

namespace vendasAPI.Services.Implementations
{
    public interface IClienteService
    {
        Cliente Create(Cliente cliente);
        Cliente Update(Cliente cliente);
        void Delete(int idCliente);
        Cliente FindByID(int idCliente);
        List<Cliente> FindAll();
    }
}
