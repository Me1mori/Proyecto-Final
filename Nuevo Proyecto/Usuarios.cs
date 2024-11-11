using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

namespace Nuevo_Proyecto
{
    internal class Usuarios
    {
        public string usuario = string.Empty, contraseña = string.Empty, C_Contraseña = string.Empty;
        public int N_D;
        public bool N_U = false;

        private void Confirmar(){
            if(contraseña == ""){
            }
            else{
                if (contraseña == C_Contraseña){
                    N_U = true;
                }
                else{
                    N_U = false;
                }
            }
        }

        public string Registrado(){
            Confirmar();

            if (!N_U){
                return "Confirmación incorrecta";
            }
            else{
                N_D++;
                return "Nuevo usuario: " + N_D;
            }
        }
    }
}
