using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFabricCreateBuild
{
    public class CreatorBuild : Creator
    {
        public override WoodenBuild CreateWoodenBuild()         
        {
            var builder = new WoodenBuild();
            return builder;
        }
        public override BrickBuild CreateBrickBuild()
        {
            var builder = new BrickBuild();
            return builder;
        }

        public override PanelBuild CreatePanelBuild()
        {
            var builder = new PanelBuild() 
            { 

            };
            return builder;
        }
    }
}
