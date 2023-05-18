using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Segundo_Semestre
{
    internal class AllPrecios
    {
        //variables del valor de la guitarras acusticas
        public Int64 precioGAMartin { get; set; } = 1500;
        public Int64 precioGAGibson { get; set; } = 2000;
        public Int64 precioGATaylor { get; set; } = 2500;
        //variables del valor de las guiarras eléctricas
        public Int64 precioGEFender { get; set; } = 4000;
        public Int64 precioGEIbanez { get; set; } = 4500;
        public Int64 precioGEGibson { get; set; } = 3500;
        //Variables del valor de los bajos eléctricos
        public Int64 precioBEYamaha { get; set; } = 5000;
        public Int64 precioBEFender { get; set; } = 4500;
        public Int64 precioBERedSub { get; set; } = 3500;
        //Variables del valor de las arpas
        public Int64 precioAPSelvi { get; set; } = 7000;
        public Int64 precioAPSelta { get; set; } = 6000;
        //Variables del valor de las arpas
        public Int64 precioVStenorStudent { get; set; } = 8000;
        public Int64 precioVSinfonie24 { get; set; } = 10000;
        //Variables del valor de las Baterias Acusticas
        public Int64 precioBACrush { get; set; } = 10000;
        public Int64 precioBAYamaha { get; set; } = 13000;
        public Int64 precioBAMapex { get; set; } = 12000;
        public Int64 precioBATama { get; set; } = 14000;
        //Variables del valor de las Baterias Eléctricas
        public Int64 precioBELYamaha { get; set; } = 14000;
        public Int64 precioBELRonald { get; set; } = 14500;
        //Variables del valor de los Timbales
        public Int64 precioTAdams32 { get; set; } = 3000;
        public Int64 precioTMajestic32 { get; set; } = 4000;
        //Variables del valor de los Triangulos
        public Int64 precioTACharls { get; set; } = 500;
        public Int64 precioTAXO { get; set; } = 400;
        //Variables del valor de los Bombos
        public Int64 precioBAudiotek { get; set; } = 1500;
        //Variables del valor de los Instrumentos de Aire
        public Int64 precioATrompeta { get; set; } = 3500;
        public Int64 precioAXilófono { get; set; } = 3000;
        public Int64 precioAAcordeón { get; set; } = 2500;
        public Int64 precioAFlauta { get; set; } = 300;
        //The AllPrecios class contains variables that represent the prices of different
        //instruments.These variables are used in the calculation of the total price of the
        //selected instruments in their respective add to cart events.

        //Calcular Precio Total de cada cosa
        public long CalcularprecioGA(int cantidad, long precio)
        {
            return cantidad* precio;
        }
        public long CalcularprecioGE(int cantidad, long precio)
        {
            return cantidad * precio;
        }
        public long CalcularprecioBE(int cantidad, long precio)
        {
            return cantidad * precio;
        }
        //These methods can be used to calculate the total price of the instruments in
        //different parts of the code.
    }
}
