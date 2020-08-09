using System;
using System.Collections.Generic;
using System.Text;

namespace AccountDraw.Entities.Excepitions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string massage) : base(massage)
        {

        }
    }
}
