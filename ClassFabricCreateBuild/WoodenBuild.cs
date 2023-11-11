using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFabricCreateBuild
{
    public class WoodenBuild : Build
    {
        protected override string TypeBuild => "Деревянный дом";

        public WoodenBuild() : base()
        {

        }
    }
}
