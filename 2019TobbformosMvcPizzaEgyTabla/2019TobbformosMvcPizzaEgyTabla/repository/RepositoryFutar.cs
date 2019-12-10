using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using TobbbformosPizzaAlkalmazasEgyTabla.Model;

namespace TobbbformosPizzaAlkalmazasEgyTabla.repository
{
    partial class FRepository
    {
        List<Futar> futarok;

        public List<Futar> getFutarok()
        {
            return futarok;
        }

        public void setFutarok(List<Futar> futarok)
        {
            this.futarok = futarok;
        }

    }
}
