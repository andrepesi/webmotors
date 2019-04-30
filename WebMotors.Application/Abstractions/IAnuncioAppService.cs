using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Application.ViewModels;
using WebMotors.Domain;
using WebMotors.Domain.Abstractions.Service;

namespace WebMotors.Application.Abstractions
{
    public interface IAnuncioAppService: IAppService<AnuncioViewModel,Anuncio, IAnuncioService>
    {
    }
}
