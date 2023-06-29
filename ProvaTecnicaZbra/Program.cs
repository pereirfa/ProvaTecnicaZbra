using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnicaZbra
{
    internal class Program
    {
        /// <summary>
        /// Processo executor principal via console
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
            Console.WriteLine("▒                  Technical Test Zbra                          ▒");
            Console.WriteLine("▒               Candidate: Fábio Sarmento Pereira               ▒");
            Console.WriteLine("▒███████████████████████████████████████████████████████████████▒");
            Console.WriteLine("\r\n");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MenuPrincipal();
            }
        }

        /// <summary>
        /// Montagem do menu com as opções dos testes via console
        /// </summary>
        /// <returns>bool Processamento das entradas </returns>
        private static bool MenuPrincipal()
        {
            int rulestot = 0;
            int address = 0;
            var validate = new PasswordValidation();
            var estatistics = new Estatistics();
            var addressaccount = new AddressAccounting();
            
            //Console.Clear();
            Console.WriteLine("Type desired option:");
            Console.WriteLine("0) Password Validate - Part1");
            Console.WriteLine("1) Password Validate - Part2");
            Console.WriteLine("2) Accounting Validated Passwords - Part1");
            Console.WriteLine("3) Accounting Validated Passwords - Part2");
            Console.WriteLine("4) Calculate Address Value");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nType option: ");

            switch (Console.ReadLine())
            {
                case "0":
                    Console.WriteLine("Type password for validation and press Enter:");
                    if (validate.ValidatePassword(Convert.ToString(Console.ReadLine()),"part1")) 
                    {
                        Console.WriteLine("\r\n");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("▒                     Login ok                                  ▓");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("\r\n");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("\r\n");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("▒                     Login Failed                              ▓");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("\r\n");
                        return true;
                    }

                case "1":
                    Console.WriteLine("Type password for validation and press Enter:");
                    if (validate.ValidatePassword(Convert.ToString(Console.ReadLine()),"part2"))
                    {
                        Console.WriteLine("\r\n");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("▒                     Login ok                                  ▓");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("\r\n");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("\r\n");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("▒                     Login Failed                              ▓");
                        Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                        Console.WriteLine("\r\n");
                        return true;
                    }

                case "2":
                    rulestot = estatistics.RulesAccount("part1");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("▒ Number of validated passwords = " + rulestot.ToString() + "                          ▓");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("\r\n");
                    return true;

                case "3":
                    rulestot = estatistics.RulesAccount("part2");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("▒ Number of validated passwords = " + rulestot.ToString() +"                           ▓");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("\r\n");
                    return true;

                case "4":
                    address = addressaccount.CalculateAddress();
                    Console.WriteLine("\r\n");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("▒ Address Value = " + address.ToString() +"                                           ▓");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("\r\n");
                    return true;

                case "5":
                    return false;
                default:
                    Console.WriteLine("\r\n");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("▒                     Invalid Option                            ▓");
                    Console.WriteLine("▓███████████████████████████████████████████████████████████████▓");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("\r\n");
                    return true;
            }
        }


    }
}
