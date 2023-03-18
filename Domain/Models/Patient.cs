using Domain.Enum;

namespace Domain.Models;
public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RG { get; set; }
    public string CPF { get; set; }
    public string PhoneNumber { get; set; }
    public string Education { get; set; }
    public string Profession { get; set; }
    public Address Address { get; set; }
    public DateTime BirthDate { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public TypeService TypeService { get; set; }
    public bool IsActive { get; set; }
}
