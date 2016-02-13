﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.MVVM.Model
{
 public sealed    class ClienteModel
    {
        public String Nome { get; set; }
        public String  Email { get; set; }
        public String Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }

    }
}
