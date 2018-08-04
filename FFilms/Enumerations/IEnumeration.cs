using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFilms.Enumerations
{
    public interface IEnumeration
    {
        string GetContactMessagePath { get; }

        string GetConfirmationEmailText { get; }
    }
}
