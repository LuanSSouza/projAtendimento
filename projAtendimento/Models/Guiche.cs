using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento.Models
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public Guiche() {
            id = 0;
            atendimentos = new Queue<Senha>();
        }
        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }
        public bool chamar(Queue<Senha> filaSenhas) {
            if (filaSenhas.Count == 0) return false;
            Senha aux = filaSenhas.Dequeue();
            // Arrumar : Chamar setter dataAtend e horaAtend
            return true;
        }
    }
}
