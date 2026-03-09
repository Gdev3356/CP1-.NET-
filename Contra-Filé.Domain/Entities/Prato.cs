using Contra_Filé.Domain.Common;

namespace Contra_Filé.Domain;

public class Prato : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    
    public int TempoPreparoMinutos { get; set; } 
}