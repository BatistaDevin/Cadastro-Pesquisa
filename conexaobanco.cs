using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace cadastroEmpresas
{
    static class ConexaoBanco
    {

        private const string servidor ="localhost";
        private const string bancoDados = "cadastroempresas";
        private const string usuario ="root";
        private const string senha ="";

        static public string bancoServidor = $"server={servidor};user id={usuario};database={bancoDados};password={senha};";


    }

}
