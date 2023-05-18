using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasDomain.Domain
{
    public class ChurrasParticipante
    {
        public int Id { get; set; }
        public int ChurrasId { get; set; }
        public virtual Churrasco Churras { get; set; }
        public int ParticipanteId { get; set; }
        public virtual Participante Participante { get; set; }
        public decimal Valor { get; set; }
    }
}
