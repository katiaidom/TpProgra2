using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_KATIADOMINGUES_PROGRAII
{
    public class BALDE
    {
        public long key;
        public Usuario usuario;
        public bool borrado; //si esta borrado es true, si no es false

        public BALDE(long k, Usuario usu, bool b)
        {
            this.key = k;
            this.usuario = usu;
            this.borrado = b;
        }

    }


}
