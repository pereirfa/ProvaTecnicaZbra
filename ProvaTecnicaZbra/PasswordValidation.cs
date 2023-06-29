using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Zbr.Domain.Enums;

namespace ProvaTecnicaZbra
{
    public class PasswordValidation
    {
        /// <summary>
        /// Validação das regras de senhas válidas a partir dos modulos definidos - Question 1
        /// </summary>
        /// <param name="password">Senha input</param>
        /// <param name="mod">Definição dos dois módulos apresentados na Question 1 - "part1" / "part2" </param>
        /// <returns>bool Retorno da validação </returns>
        public bool ValidatePassword(string password, string mod)
        {
            if (ValueKey(password) && ValueOrder(password) && ValueGroup(password, mod))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validação das regras de senhas válidas a partir do range de valores apresentados - Question 1
        /// </summary>
        /// <param name="password">Senha input</param>
        /// <returns>bool Retorno da validação </returns>
        private static bool ValueKey(string password)
        {
            try
            {
                int result = Int32.Parse(password);
                
                if ((result >= (Int32)EnumLimitPassword.StartValue && (result <= (Int32)EnumLimitPassword.EndValue)))
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Validação das regras de senhas válidas a partir da definição de ter 2 digitos adjacentes  - Question 1
        /// </summary>
        /// <param name="password">Senha input</param>
        /// <param name="mod">Definição das regras apresentas nos módulos Question 1 - "part1" / "part2" </param>
        /// <returns>bool Retorno da validação </returns>
        private static bool ValueGroup(string password, string mod)
        {
            int tampsw = password.Length - 1;
            int cont = 0;
            int check = 0;
            bool isgroup = false;

            while (cont < tampsw)
            {
                if (mod == "part1")
                {
                    if (password[cont] == password[cont + 1])
                    {
                        return true;
                    }
                }
                else
                {
                    if (password[cont] == password[cont + 1])
                    {
                        check++;
                        isgroup = true;
                    }
                    else
                        check = 0;

                    if (check > 1)
                        isgroup = false;
                }

                cont++;
            }

            return check == 1 || isgroup ? true : false;
        }

        /// <summary>
        /// Validação das regras de senhas válidas a partir da ordenação crescente de valores da esquerda para direita  - Question 1
        /// </summary>
        /// <param name="password">Senha input</param>
        /// <returns>bool Retorno da validação </returns>
        private static bool ValueOrder(string password)
        {
            int tampsw = password.Length - 1;
            int cont = 0;

            while (cont < tampsw)
            {
                if (password[cont] > password[cont + 1])
                    return false;

                cont++;
            }
            return true;
        }

    }
}
