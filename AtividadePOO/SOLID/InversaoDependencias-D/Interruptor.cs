using System.Threading.Tasks.Sources;

namespace InversaoDependencias_D
{
    public class Interruptor
    {
        // Privada soment  leitura, variavel criada como dispositivo
        private readonly IDispositivo variavel_dispositivo_que_vem_da_interface;


        //Jeito ERRADO
        /*
        public Interruptor {
         ar = new ArCondicionado();
        }
        
        public void Acionar(){
            ar.Ligar();        
        }
        */


        //Jeito CORRETO
        public Interruptor(IDispositivo parametro_dispositivo) // _dispositivo
        {
            // This.dispositivo para nao confundir as variaveis
            this.variavel_dispositivo_que_vem_da_interface = parametro_dispositivo;
        }

        public void Acionar() => variavel_dispositivo_que_vem_da_interface.Ligar();

    }
}
