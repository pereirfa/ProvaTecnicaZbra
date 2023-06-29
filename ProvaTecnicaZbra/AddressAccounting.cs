using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zbr.Domain.Enums;

namespace ProvaTecnicaZbra
{
    public class AddressAccounting
    {
        /// <summary>
        /// Calcula o valor da variável Address a partir da importação de arquivo e processamento dos comandos
        /// </summary>
        /// <returns>int Valor da variável Address relacionado a questão 2 do teste.</returns>
        public int CalculateAddress() 
        {
            Console.WriteLine("Type the path to file import, and press Enter");
            string path = Convert.ToString(Console.ReadLine());

            try
            {
                IEnumerable<string> list = File.ReadLines(path).ToList();
                return ProcessAddressCommand(list);
            }
            catch  
            {
                Console.WriteLine("\r\n");
                Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                Console.WriteLine("▒                   Invalid  File                               ▓");
                Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                Console.WriteLine("\r\n");
                Console.WriteLine("\r\n");
                return 0;
            }    
        }

        /// <summary>
        /// Calcula o valor da variavel de endereço a partir de dados de comando incluidos via arquivo.
        /// </summary>
        /// <param name="list">Conjunto de linhas do arquivo importado</param>
        /// <returns>int Valor da variável Address relacionado Question 2.</returns>
        private int ProcessAddressCommand(IEnumerable<string> list) 
        {
            int address = 0;
            int lines = 1;
            int cont = 0;

            foreach (var item in list)
            {
                cont++;
                
                if(cont == lines)
                {
                    if ( int.Parse(item.Substring(0, 2)) == (Int16)EnumCommand.Address)
                    {
                        try
                        {
                            address = address + Int16.Parse(item.Substring(2, item.Length - 2));
                            lines++;
                        }
                        catch (FormatException)
                        {
                            return 0;
                        }
                    }
                    else if ( int.Parse(item.Substring(0, 1)) == (Int16)EnumCommand.Jump)
                    {
                        try
                        {
                            lines = lines + Int32.Parse(item.Substring(1, item.Length - 1)); 
                        }
                        catch (FormatException)
                        {
                            return 0;
                        }
                    }
                    else
                        lines++;
                }

            }
            return address;
        }

    }
}
