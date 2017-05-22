using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeLectura
{
    class Entidad
    {
        private int _intId;
        private string _strNombre;
        private string _strCategoria;
        private string _strPath;

        public int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }

        public string Path
        {
            get { return _strPath; }
            set { _strPath = value; }
        }

        public Entidad(int intId, string strNombre, string strCategoria, string strPath)
        {
            this.Id = intId;
            this.Nombre = strNombre;
            this.Categoria = strCategoria;
            this.Path = strPath;
        }
    }
}
