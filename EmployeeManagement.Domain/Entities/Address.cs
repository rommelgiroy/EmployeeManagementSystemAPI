
using System.Globalization;

namespace EmployeeManagement.Domain.Entitiesl;

internal class Address
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public int BarangayId { get; set; }
    public string HomeAddress { get; set; } = string.Empty;
}
