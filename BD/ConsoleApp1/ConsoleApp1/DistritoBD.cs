﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DistritoBD
    {
public DistritoBD(int id, string nombre) {
            Id = id;
            Nombre = nombre;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
