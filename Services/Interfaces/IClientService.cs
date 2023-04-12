using Domain.Entity;
using Domain.Interfaces;

namespace Services.Interfaces;

public interface IClientService
{
    IBaseResponse<ClientEntity> CreateClient();
}