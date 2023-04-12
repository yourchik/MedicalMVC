namespace Domain.Entity;

public class VisitEntity : BaseEntity<long>
{
    public DateTime Date { get; set; }
    
    public string Diagnosis { get; set; }
    
    public virtual ClientEntity Client { get; set; }
    
    public long ClientId { get; set; }
}