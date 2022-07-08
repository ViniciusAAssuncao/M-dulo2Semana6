using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Módulo2Semana6 {
    internal class Exercício5 {
        Agenda agenda = new Agenda();
        agenda.criarCompromisso("Compromisso 1", new DateTime(2023, 1, 1, 10, 0, 0), new TimeSpan(1, 0, 0));
        agenda.criarCompromisso("Compromisso 2", new DateTime(2023, 1, 1, 10, 0, 0), new TimeSpan(1, 0, 0));
        agenda.criarCompromisso("Compromisso 3", new DateTime(2023, 1, 1, 10, 0, 0), new TimeSpan(1, 0, 0));

        agenda.mostrarCompromissos();
    }
}
