using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeLectura
{
    class Actividad
    {
        private string _strDireccionImagen;
        private string _strCategoria;
        private int _intIDRespuesta;
        private string[] _strNombres = new string[4];
        private int[] _intIDs = new int[4];

        public Actividad()
        {

        }

        public string DireccionImagen
        { 
            get { return _strDireccionImagen; }
            set { _strDireccionImagen = value; }
        }

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }


        public int IdRespuesta
        { 
            get { return _intIDRespuesta; }
            set { _intIDRespuesta = value; }
        }

        public string[] Nombres
        {
            get { return _strNombres; }
            set { _strNombres = value; }
        }

        public int[] IDs
        {
            get { return _intIDs; }
            set { _intIDs = value; }
        }

    }
}
