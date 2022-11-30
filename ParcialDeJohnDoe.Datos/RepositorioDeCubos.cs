using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeYagoTorres.Entidades;
namespace ParcialDeYagoTorres.Datos
{
   public class RepositorioDeCubos
   {
        private List<Cubo> listaCubos;
        private bool hayCambios = false;

        public RepositorioDeCubos()
        {
            listaCubos = new List<Cubo>();
            listaCubos = ManejadorDeArchivo.LeerArchivo();
        }

        public void Agregar(Cubo cubo)
        {
            listaCubos.Add(cubo);
            hayCambios = true;
        }

        public void Borrar(Cubo cubo)
        {
            listaCubos.Remove(cubo);
            hayCambios = true;
        }

        public void Editar(Cubo cubo)
        {
            hayCambios = true;
        }

        public List<Cubo> GetLista()
        {
            return listaCubos;
        }

        public int GetCantidad()
        {
            return listaCubos.Count;
        }

        public void GuardarEnArchivo()
        {
            if (hayCambios)
            {
                ManejadorDeArchivo.GuardarEnArchivo(listaCubos);
            }
        }


        public List<Cubo> GetListaOrdenadaAsc()
        {
            return listaCubos.OrderBy(e => e.Arista).ToList();
        }

        public List<Cubo> GetListaOrdenadaDesc()
        {
            return listaCubos.OrderByDescending(e => e.Arista).ToList();
        }

        public List<Cubo> FiltrarPorTrazo(Trazo trazoFiltrar)
        {
            return listaCubos.Where(e => e.Trazo == trazoFiltrar).ToList();
        }



    }
}
