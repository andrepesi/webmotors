using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain.Abstractions;

namespace WebMotors.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebMotorsContext _context;        
        public UnitOfWork(WebMotorsContext context)
        {
            _context = context;
        }

        public object GetContext()
        {
            return this._context;
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Erro ao Salvar tente novamente");
            }
        }
    }
}
