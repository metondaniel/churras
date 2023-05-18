using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasDomain.Domain
{
    public class Participante
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set;}
        public virtual List<ChurrasParticipante> ChurrasParticipante { get; set;}
    }
}
