using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolClub.Administracion.Clases
{
    //Aqui va internal class Equipo
    public class Equipo 
    {
        public string NombreEquipo { get; set; } = null!;
        public int CantidadJugadores { get; set; }
        public string NombreDT { get; set; } = null!;
        public string TipoEquipo { get; set; } = null!;
        public string CapitanEquipo { get; set; } = null!;
        public bool TieneSub21 { get; set; }

        public Equipo() { }

        public Equipo(string nombreequipo, int cantidadjugadores,string nombredt,string tipoequipo,string capitanequipo,bool tienesub21)
        {
            NombreEquipo = nombreequipo;
            CantidadJugadores = cantidadjugadores;
            NombreDT = nombredt;
            TipoEquipo = tipoequipo;
            CapitanEquipo = capitanequipo;
            TieneSub21 = tienesub21;
        }
    }
}
