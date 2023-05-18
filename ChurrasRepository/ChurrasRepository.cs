using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasRepository
{
    public class ChurrasRepository : RepositoryBase<Churrasco>, IChurrasRepository
    {
        public ChurrasRepository(ChurrasDBContext context) : base(context)
        {
        }

        public async Task<bool> Update(int Id, Churrasco churrasco)
        {
            Churrasco churrasEntity = await GetById(Id);
            churrasEntity.Obeservacao = churrasco.Obeservacao;
            churrasEntity.Descricao = churrasco.Descricao;
            churrasEntity.Data = churrasco.Data;

            _context.Set<Churrasco>().Update(churrasEntity);
            _context.SaveChanges();
            return true;
        }
    }
}
