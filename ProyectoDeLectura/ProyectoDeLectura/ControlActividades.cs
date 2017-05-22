using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeLectura
{
    class ControlActividades
    {
        private Entidad[] _listEntidades;

        public ControlActividades(List<Entidad> listEntidades)
        {
            _listEntidades = listEntidades.ToArray();
        }

        public Actividad ObtenerSiguienteActividad()
        {

            Actividad miActividad = new Actividad();

            int[] rand = new int[4]; 
                
            for (int i = 0; i < 4; i++)
            {
                rand[i] = new Random().Next(1, _listEntidades.Length);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 4; j++)
                {
                    if (rand[i] == rand[j])
                    {
                        rand[i] = new Random().Next(1, _listEntidades.Length);
                        i = 0;
                        break;
                    }
                }
            }

            for (int i = 0; i < rand.Length; i++)
            {
                miActividad.IDs[i] = _listEntidades[rand[i]].Id;
                miActividad.Nombres[i] = _listEntidades[rand[i]].Nombre;
            }
            miActividad.IdRespuesta = new Random().Next(1, _listEntidades.Length);

            miActividad.Categoria = _listEntidades[miActividad.IdRespuesta - 1].Categoria;

            miActividad.DireccionImagen = _listEntidades[miActividad.IdRespuesta - 1].Path;

            int intIndexOverride = new Random().Next(0,3);
            miActividad.IDs[intIndexOverride] = miActividad.IdRespuesta;
            miActividad.Nombres[intIndexOverride] = _listEntidades[miActividad.IdRespuesta - 1].Nombre;

            return miActividad;
        }

    }
}
