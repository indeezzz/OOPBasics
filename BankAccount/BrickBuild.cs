using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BrickBuild : Build
    {
        protected override string TypeBuild => "Кирпичный дом";
        public void Init()
        {

        }
    }
}
