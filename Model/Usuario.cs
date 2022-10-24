using System;
using System.Collections.Generic;

namespace sqlQueryExample.Model
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Senha { get; set; }
    }
}
