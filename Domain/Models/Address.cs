namespace Domain.Models;
public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public int Number { get; set; }
    public string Complement { get; set; }
    public string Neighboorhour { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string CEP { get; set; }
}