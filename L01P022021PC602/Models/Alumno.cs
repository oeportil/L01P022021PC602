using System;
using System.Collections.Generic;

namespace L01P022021PC602.Models;

public partial class Alumno
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Apellidos { get; set; }

    public int? Dui { get; set; }

    public int? Estado { get; set; }
}
