﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAtendimento.Models;

namespace projAtendimento.Controllers
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches() {
            listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche) {
            listaGuiches.Add(new Guiche());
        }
    }
}
