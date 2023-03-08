using System;
using System.Collections.Generic;

namespace containers_101.DataModel;

public partial class Employee
{
    public Guid? EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }
}
