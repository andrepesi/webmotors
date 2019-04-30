using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain.Abstractions;
using WebMotors.Domain.Abstractions.Service;
using WebMotors.Domain.Implementations;

namespace WebMotors.Domain.Implementations
{
    public class AnuncioService : AService<Anuncio, IAnuncioRepository>, IAnuncioService
    {
        public AnuncioService(IAnuncioRepository repository) : base(repository)
        {
        }
    }
}
