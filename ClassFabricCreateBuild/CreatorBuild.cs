using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFabricCreateBuild
{
    public class CreatorBuild : Creator
    {
        public Hashtable TableBuilds = new Hashtable();
        public override WoodenBuild CreateWoodenBuild()         
        {
            var builder = new WoodenBuild();
            TableBuilds.Add(builder.ID, builder);
            return builder;
        }
        public override BrickBuild CreateBrickBuild()
        {
            var builder = new BrickBuild();
            TableBuilds.Add(builder.ID, builder);
            return builder;
        }

        public override PanelBuild CreatePanelBuild()
        {
            var builder = new PanelBuild() 
            { 

            };
            TableBuilds.Add(builder.ID, builder);
            return builder;
        }
    }
}
