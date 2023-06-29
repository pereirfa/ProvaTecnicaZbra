using System;
using System.Collections.Generic;
using System.Text;

namespace Zbr.Domain.Enums
{
    public enum EnumCommand
    {
        Address = 20 , /// Variável para incremento do calculo 
        Jump = 5 /// Variável para ser feito o avanço do processamento das linhas do arquivo
    }

    public enum EnumLimitPassword
    {
        StartValue = 184759, /// Variável definido como range inicial para valores permissiveis de senha
        EndValue = 856920  ///Variável definido como range final para valores permissiveis de senha
    }


}
