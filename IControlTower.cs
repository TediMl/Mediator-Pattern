using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator1
{
    public interface IControlTower
    {
        void RegisterRunway(Runway runway);
        bool RequestLandingPermission(Airplane airplane);

        void ReleaseRunway(Runway runway);
    }
}
