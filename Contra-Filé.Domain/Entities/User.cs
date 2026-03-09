using Contra_Filé.Domain.Common;

namespace Contra_Filé.Domain;

public class User : BaseEntity
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    private string PasswordSalt { get; set; }
    private DateOnly SetBirhDate { get;  set; } 
   
}