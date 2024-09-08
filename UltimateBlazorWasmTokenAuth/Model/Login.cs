﻿using System.ComponentModel.DataAnnotations;

namespace UltimateBlazorWasmTokenAuth.Model;

public class Login
{
    [Required]
    public string? username { get; set; }

    [Required]
    public string? password { get; set; }
}
