using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePratica
{
    public class SP
    {
        public string  Nome { get; set; } = string.Empty;
        public string Cpf { get;  set; } = string.Empty;
        public int Dt { get; set; }
        public double Vd { get; set; }

        public double Sb { get;   set; }
        public double Ir { get;  private set; }
        public double Sl { get; private set; }
  

        public void Calculo()
        {
            Sb = Dt * Vd;

            if ( Sb <= 1903.98) {
                Ir = 0;
            }
            else if (Sb > 1903.98 &&  Sb <= 2826.65){
                Ir = Sb * 0.075;

            } if(Sb > 2826.65 && Sb <= 3751.05)
            {
                Ir = Sb * 0.15;
            } else if  (Sb > 3751.05 && Sb <= 4664.68)
            {
                Ir = Sb * 0.225;
            }

           
            Sl = Sb - Ir;

   
        } 
        
    }
}
