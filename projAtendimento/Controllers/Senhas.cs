using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAtendimento.Models;

namespace projAtendimento.Controllers
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas() {
            proximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }

        public void gerar() {
            filaSenhas.Enqueue(new Senha(proximoAtendimento));
            proximoAtendimento++;
        }
    }
}
