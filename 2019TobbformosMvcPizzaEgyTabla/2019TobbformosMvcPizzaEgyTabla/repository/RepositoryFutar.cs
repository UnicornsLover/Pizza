using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasEgyTabla.repository
{
    partial class RepositoryFutar
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
