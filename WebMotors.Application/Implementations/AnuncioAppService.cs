using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebMotors.Application.ViewModels;
using WebMotors.Domain;
using WebMotors.Domain.Abstractions.Service;
using WebMotors.Application.Abstractions;

namespace WebMotors.Application.Implementations
{
    public class AnuncioAppService : AAppService<AnuncioViewModel, Anuncio, IAnuncioService>, IAnuncioAppService
    {
        public AnuncioAppService(IAnuncioService service, IMapper mapper) : base(service, mapper)
        {
        }

        public override void ValidateAdd(AnuncioViewModel entity)
        {
            DateTime validYear;
            var year = entity.Ano;
            DateTime.TryParse(string.Format("1/1/{0}", year), out validYear);
            bool isValid = !string.IsNullOrEmpty(entity?.Marca?.Trim())
                && !string.IsNullOrEmpty(entity?.Modelo?.Trim())
                && !string.IsNullOrEmpty(entity?.Versao?.Trim())
                && (entity.Ano > 1900 && (validYear != default(DateTime)));
            if (!isValid)
                throw new ArgumentException("Verfique os dados e tente novamente");
        }

        public override void ValidateDelete(AnuncioViewModel entity)
        {          
            bool isValid = entity.Id > 0;
            if (!isValid)
                throw new ArgumentException("Verfique os dados e tente novamente");
        }

        public override void ValidateUpdate(AnuncioViewModel entity)
        {
            DateTime validYear;
            var year = entity.Ano;
            DateTime.TryParse(string.Format("1/1/{0}", year), out validYear);
            bool isValid = entity.Id > 0 && !string.IsNullOrEmpty(entity?.Marca?.Trim())
                && !string.IsNullOrEmpty(entity?.Modelo?.Trim())
                && !string.IsNullOrEmpty(entity?.Versao?.Trim())
                && (entity.Ano > 1900 && (validYear != default(DateTime)));
            if (!isValid)
                throw new ArgumentException("Verfique os dados e tente novamente");
        }
    }
}
