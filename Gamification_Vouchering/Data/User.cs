using System;
using System.Collections.Generic;

namespace Gamification_Vouchering.Data;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;
}
