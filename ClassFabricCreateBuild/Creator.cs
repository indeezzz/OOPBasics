using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFabricCreateBuild
{
    public abstract class Creator
    {
        public abstract WoodenBuild CreateWoodenBuild();

        public abstract BrickBuild CreateBrickBuild();

        public abstract PanelBuild CreatePanelBuild();
    }
}
