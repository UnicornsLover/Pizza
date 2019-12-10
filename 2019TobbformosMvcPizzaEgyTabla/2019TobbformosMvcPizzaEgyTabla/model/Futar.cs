using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasEgyTabla
{
    partial class Futar
    {
        private int id;
        private string name;
        private string tel;

        public bool isValidName(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            if (!char.IsUpper(name.ElementAt(0)))
            {
                return false;
            }
            for (int i = 1; i < name.Length; i++)
            {
                if ((!char.IsLetter(name.ElementAt(i))) && (!char.IsWhiteSpace(name.ElementAt(i))))
                {
                    return false;
                }
            }
            return true;
        }

        public Futar(int id, string name, string tel)
        {
            this.id = id;
            if (!isValidName(name))
                throw new ModelFutarNotValidNameExeption("A futár neve nem megfelelő!");
            if (!isValidTel(tel))
                throw new ModelFutarNotValidNameExeption("A telefonszám nem megfelelő!");
            this.name = name;
            this.tel = tel;
        }

    }
}
