using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain;
using WebMotors.Domain.Abstractions;

namespace WebMotors.Infra.Data.Repositories
{
    public class AnuncioRepository : ARepository<Anuncio>, IAnuncioRepository
    {
        public AnuncioRepository(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
