using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasRepository
{
    public class ChurrascoRepository : RepositoryBase<Churrasco>, IChurrasRepository
    {
        private readonly ChurrasDBContext _context;
        public ChurrascoRepository(ChurrasDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> Update(int Id, Churrasco churrasco)
        {
            Churrasco churrasEntity = await GetById(Id);
            churrasEntity.Observacoes = churrasco.Observacoes;
            churrasEntity.Descricao = churrasco.Descricao;
            churrasEntity.Data = churrasco.Data;

            _context.Set<Churrasco>().Update(churrasEntity);
            _context.SaveChanges();
            return true;
        }


        public override async Task<Churrasco> GetById(int Id)
        {
            var result = _context.Set<Churrasco>().Include(x => x.ChurrasParticipante);
            return result.FirstOrDefault(x=>x.Id == Id);
        }
    }
}
