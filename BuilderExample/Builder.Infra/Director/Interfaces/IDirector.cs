using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Builder.Director.Interfaces
{
    public interface IDirector
    {
        public Director SetBuilder();
        public Director InicializeBuilder();
    }
}
