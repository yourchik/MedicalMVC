using Domain.Entity;
using Domain.Interfaces;
using Services.Interfaces;

namespace Services.Implementation;

public class ClientService : IClientService
{
    public IBaseResponse<ClientEntity> CreateClient()
    {
        throw new System.NotImplementedException();
    }
}