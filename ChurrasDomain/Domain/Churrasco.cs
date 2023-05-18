﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasDomain.Domain
{
    public class Churrasco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Obeservacao { get; set;}
        public DateTime? Data { get; set; }
        public virtual List<ChurrasParticipante> ChurrasParticipante { get; set; }
    }
}
