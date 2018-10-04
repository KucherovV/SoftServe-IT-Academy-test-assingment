using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softservetest
{
    interface IAnimal
    {
        string Name { get; set; }
        string Breed { get; set; }

        string Introduce();
    }
}
