using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialDeYagoTorres.Entidades;
namespace ParcialDeYagoTorres.Datos
{

        public static class ManejadorDeArchivo
        {
            private static string archivo = "Cubos.txt";

            public static void GuardarEnArchivo(List<Cubo> lista)
            {
                using (var escritor = new StreamWriter(archivo))
                {
                    foreach (var cubo in lista)
                    {
                        string linea = ConstuirLinea(cubo);
                        escritor.WriteLine(linea);
                    }
                }
            }

            private static string ConstuirLinea(Cubo cubo)
            {
                return $"{cubo.Arista}|{(int)cubo.Relleno}|{(int)cubo.Trazo}";
            }

            public static List<Cubo> LeerDelArchivo()
            {
                List<Cubo> lista = new List<Cubo>();
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Cubo cubo = CrearCubo(linea);
                        lista.Add(cubo);
                    }
                }

                return lista;
            }

            private static Cubo CrearCubo(string linea)
            {
                var campos = linea.Split('|');
                Cubo cubo = new Cubo()
                {
                    Arista = int.Parse(campos[0]),
                    Relleno = (Relleno)int.Parse(campos[1]),
                    Trazo = (Trazo)int.Parse(campos[2])
                };
                return cubo;
            }
            public static List<Cubo> LeerArchivo()
            {
                List<Cubo> lista = new List<Cubo>();
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Cubo cubo = CrearCubo(linea);
                        lista.Add(cubo);
                    }
                }

                return lista;
            }
        }



    
}
