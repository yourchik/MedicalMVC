using Domain.Enum;

namespace Domain.Interfaces;

public interface IBaseResponse<T>
{
    string Description { get; }
    
    StatusCode StatusCode { get; }
    
    T Data { get; }
    
}