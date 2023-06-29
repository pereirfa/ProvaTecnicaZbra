using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zbr.Domain.Enums;

namespace ProvaTecnicaZbra
{
    public class Estatistics
    {
        /// <summary>
        /// Contagem das senhas validas a partir das regras definidas nos modulos - Question 1
        /// </summary>
        /// <param name="mod">Definição dos dois módulos apresentados na Question 1 - "part1" / "part2" </param>
        /// <returns>int Quantidade de senhas válidas a partir do range apresentado - Question 1 </returns>
        public int RulesAccount(string mod) 
        {
            int cont = (Int32)EnumLimitPassword.StartValue;
            int result = 0;
            var validate = new PasswordValidation();

            while (cont <= (Int32)EnumLimitPassword.EndValue)
            {
               if (validate.ValidatePassword(cont.ToString(), mod))
               {
                    Console.WriteLine("▒ Password = " + cont.ToString() + "▓");
                    result++;
               }

                cont++;
            }
          return result;
        }
    }
}
