using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PanelBuild : Build
    {
        protected override string TypeBuild => "Панельный дом";
        public void Init()
        {

        }
    }
}
