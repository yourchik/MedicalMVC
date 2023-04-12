namespace Domain.Entity;

public class ClientEntity : BaseEntity<long>
{
    public string  FirstName { get; set; }
    
    public string  LastName { get; set; }
    
    public string  Patronymic { get; set; }
    
    public string Phone { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public virtual IEnumerable<VisitEntity> Visits { get; set; }
}
