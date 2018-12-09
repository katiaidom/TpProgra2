using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINAL_KATIADOMINGUES_PROGRAII
{
    public class HASH
    {
        public const long tam = 100;
        public const long nprimo = 97;

        public BALDE[] HL;

        public HASH()
        {
            HL = new BALDE[tam];

            for (long i = 0; i < tam; i++)
            {
                HL[i] = null;
            }
        }

        public long AplicarFuncionHash(long key)
        {
            return (key % nprimo);
        }

        public long EncontrarPosicion(long key)
        {
            long k;
            k = AplicarFuncionHash(key);

            if (HL[k] == null || HL[k].borrado == true)
                return k;
            else
            {
                for (long i = (k + 1); i < tam; i++)
                {
                    if (HL[i] == null || HL[i].borrado == true)
                    {
                        return i;
                    }
                }

                for (long j = 0; j < k; j++)
                {
                    if (HL[j] == null || HL[j].borrado == true)
                    {
                        return j;

                    }
                }
            }

            return -1;
        }

        public void Agregar(long key, Usuario usu)
        {
            long posicion = EncontrarPosicion(key);
            if (posicion != -1)
            {
                HL[posicion] = new BALDE(key, usu, false);

            }

        }

        public void Quitar(long key)
        {
            if (Buscar(key) != -1)
            {
                HL[Buscar(key)].borrado = true;

            }
        }

        public long Buscar(long key)
        {
            long k = AplicarFuncionHash(key);

            if (HL[k].key == key || HL[k].borrado == false)
            {
                return k;
            }
            else
            {
                for (long i = (k + 1); i < tam; i++)
                {
                    if (HL[i].key == key || HL[i].borrado == false)
                    {
                        return i;
                    }
                }

                for (long j = 0; j < k; j++)
                {
                    if (HL[j].key == key || HL[j].borrado == false)
                    {
                        return j;

                    }
                }
            }
            return -1;
        }



    }


}
