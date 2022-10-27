using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Infra.Interfaces
{
    public interface IBuilderProtocol
    {
        public void Reset();

        public void MakePrincipal();
        public void MakeIntermediare();
        public void MakeFinale();
    }
}
