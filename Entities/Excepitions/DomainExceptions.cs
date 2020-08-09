using System;
using System.Collections.Generic;
using System.Text;

namespace AccountDraw.Entities.Excepitions
{
    class DomainException : ApplicationException
    {
        public DomainException(string massage) : base(massage)
        {

        }
    }
}
