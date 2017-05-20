using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeLectura
{
    class Actividad:IEquatable<Actividad>,IComparable<Actividad>
    {
        private String _strOpcion1;
        public String Opcion1
        {
            get { return _strOpcion1; }
            set { _strOpcion1 = value; }
        }
        private String _strOpcion2;
        public String Opcion2
        {
            get { return _strOpcion2; }
            set { _strOpcion2 = value; }
        }
        private String _strOpcion3;
        public String Opcion3
        {
            get { return _strOpcion3; }
            set { _strOpcion3 = value; }
        }
        private String _strOpcion4;
        public String Opcion4
        {
            get { return _strOpcion4; }
            set { _strOpcion4 = value; }
        }
        private String _strPregunta;
        public String Pregunta
        {
            get { return _strPregunta; }
            set { _strPregunta = value; }
        }
        private int _intRespuesta;
        public int Respuesta
        {
            get { return _intRespuesta; }
            set { _intRespuesta = value; }
        }
        private int _intNumeroDeActiviada;
        public int NumeroDeActividad
        {
            get { return _intNumeroDeActiviada; }
            set { _intNumeroDeActiviada = value; }
        }


        int IComparable<Actividad>.CompareTo(Actividad miActividad)
        {
            if (this.NumeroDeActividad > miActividad.NumeroDeActividad)
                return 1;
            else if (this.NumeroDeActividad < miActividad.NumeroDeActividad)
                return -1;
            else
                return 0;
        }
        public bool Equals(Actividad miActividad)
        {
            if (this.Opcion1 == miActividad.Opcion1 && this.Opcion2 == miActividad.Opcion2 && this.Opcion3 == miActividad.Opcion3 && this.Opcion4 == miActividad.Opcion4 && this.Pregunta == miActividad.Pregunta && this.Respuesta == miActividad.Respuesta&&this.NumeroDeActividad==miActividad.NumeroDeActividad)
                return true;
            else
                return false;
            
        }
    }
}
