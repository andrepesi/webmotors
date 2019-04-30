using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.CrossCutting.IoC
{
    public class IoC
    {
        public static IKernel Configure()
        {
            var kernel = new StandardKernel(new IoCModule());
            return kernel;
        }
    }
}
