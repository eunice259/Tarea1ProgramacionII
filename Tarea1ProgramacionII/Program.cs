using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1ProgramacionII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            int totalOperarios = 0;
            int totalTecnicos = 0;
            int totalProf = 0;

            double acumuladoNetoOp = 0;
            double acumuladoNetoTec = 0;
            double acumuladoNetoProf = 0;

            double promedioNetoOp = 0;
            double promedioNetoTec = 0;
            double promedioNetoProf = 0;

            do
            {
                //Menu principal
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("           ****Menú Principal****\n");
                Console.WriteLine(" Selecione una opcion: \n");
                Console.WriteLine("                       1. Ingresar datos de empleado");
                Console.WriteLine("                       2. Ver estadisticas generales");
                Console.WriteLine("                       3. Salir");
                Console.ResetColor();
                opcion = int.Parse(Console.ReadLine());
                

                switch (opcion)
                {
                    case 1:  //Ingresar datos 
                        {
                            Console.WriteLine("Ingrese el tipo de empleado:  \n  1.Operario\n  2.Tecnico\n  3.Profesional");
                            int tipoEmpleado = int.Parse(Console.ReadLine());


                            if (tipoEmpleado == 1)     //Ingresar datos de Operario
                            {
                                Console.WriteLine("Ingrese el nombre del empleado: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Digite el número de cedula: ");
                                string cedula = Console.ReadLine();
                                Console.WriteLine("Ingrese el precio por hora laborada: ");
                                double precioHora = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la cantidad de horas laboradas: ");
                                double horasLab = double.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n\n");

                                //Calcular datos
                                double salarioBase = precioHora * horasLab;
                                double aumentoOp = salarioBase * 0.15;
                                double salarioBruto = salarioBase + aumentoOp;
                                double deduccion = salarioBruto * 0.0917;
                                double salarioNeto = salarioBruto - deduccion;

                                totalOperarios++;
                                acumuladoNetoOp += salarioNeto;
                                promedioNetoOp = acumuladoNetoOp / totalOperarios;

                                //Estadisticas


                                Console.WriteLine("Los datos del empleado " + nombre + " son: ");
                                Console.WriteLine("* Cedula de identidad: " + cedula);
                                Console.WriteLine("* Tipo de empleado: " + tipoEmpleado);
                                Console.WriteLine("* Salario por hora: " +precioHora);
                                Console.WriteLine("* Cantidad de horas laboradas: " +horasLab);
                                Console.WriteLine("* Salario ordinario: " + salarioBase);
                                Console.WriteLine("* Aumento de salario: " + aumentoOp);
                                Console.WriteLine("* Salario Bruto: " + salarioBruto);
                                Console.WriteLine("* Deducciones de ley (CCSS): " + deduccion);
                                Console.WriteLine("* Salario Neto: " + salarioNeto);
                                Console.WriteLine("\n\n\n");

                            }
                            else if (tipoEmpleado == 2)  //Ingresar datos de Tecnico
                            {
                                Console.WriteLine("Ingrese el nombre del empleado: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Digite el número de cedula: ");
                                string cedula = Console.ReadLine();
                                Console.WriteLine("Ingrese el precio por hora laborada: ");
                                double precioHora = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la cantidad de horas laboradas: ");
                                double horasLab = double.Parse(Console.ReadLine());

                                double salarioBase = precioHora * horasLab;
                                double aumentoTec = salarioBase * 0.10;
                                double salarioBruto = salarioBase + aumentoTec;
                                double deduccion = salarioBruto * 0.0917;
                                double salarioNeto = salarioBruto - deduccion;

                                totalTecnicos++;
                                acumuladoNetoTec += salarioNeto;
                                promedioNetoTec = acumuladoNetoTec / totalTecnicos;

                                Console.WriteLine("Los datos del empleado " + nombre + " son: ");
                                Console.WriteLine("* Cedula de identidad: " + cedula);
                                Console.WriteLine("* Tipo de empleado: " + tipoEmpleado);
                                Console.WriteLine("* Salario por hora: " + precioHora);
                                Console.WriteLine("* Cantidad de horas laboradas: " + horasLab);
                                Console.WriteLine("* Salario ordinario: " + salarioBase);
                                Console.WriteLine("* Aumento de salario: " + aumentoTec);
                                Console.WriteLine("* Salario Bruto: " + salarioBruto);
                                Console.WriteLine("* Deducciones de ley (CCSS): " + deduccion);
                                Console.WriteLine("* Salario Neto: " + salarioNeto);
                                Console.WriteLine("\n\n\n");

                            }
                            else if (tipoEmpleado == 3)  //Ingresar datos de Profesional
                            {
                                Console.WriteLine("Ingrese el nombre del empleado: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Digite el número de cedula: ");
                                string cedula = Console.ReadLine();
                                Console.WriteLine("Ingrese el precio por hora laborada: ");
                                double precioHora = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite la cantidad de horas laboradas: ");
                                double horasLab = double.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n\n");

                                double salarioBase = precioHora * horasLab;
                                double aumentoProf = salarioBase * 0.05;
                                double salarioBruto = salarioBase + aumentoProf;
                                double deduccion = salarioBruto * 0.0917;
                                double salarioNeto = salarioBruto - deduccion;

                                totalProf++;
                                acumuladoNetoProf += salarioNeto;
                                promedioNetoProf = acumuladoNetoProf / totalProf;

                                Console.WriteLine("Los datos del empleado " + nombre + " son: ");
                                Console.WriteLine("* Cedula de identidad: " + cedula);
                                Console.WriteLine("* Tipo de empleado: " + tipoEmpleado);
                                Console.WriteLine("* Salario por hora: " + precioHora);
                                Console.WriteLine("* Cantidad de horas laboradas: " + horasLab);
                                Console.WriteLine("* Salario ordinario: " + salarioBase);
                                Console.WriteLine("* Aumento de salario: " + aumentoProf);
                                Console.WriteLine("* Salario Bruto: " + salarioBruto);
                                Console.WriteLine("* Deducciones de ley (CCSS): " + deduccion);
                                Console.WriteLine("* Salario Neto: " + salarioNeto);
                                Console.WriteLine("\n\n\n");


                            }


                        }
                            break;   //break case 1
                    case 2:

                        // Ver estadisticas generales
                        Console.WriteLine("A continuacion se muestran las estadisticas generales:\n\n");

                        Console.WriteLine("                     OPERARIOS");
                        Console.WriteLine(" *La cantidad total de Operarios es de: " +totalOperarios);
                        Console.WriteLine(" *El acumulado del salario neto de Operarios es: " + acumuladoNetoOp);
                        Console.WriteLine(" *El promedio del salario neto de Operarios es:  " +promedioNetoOp);
                        Console.WriteLine("\n\n");

                        Console.WriteLine("                     TECNICOS");
                        Console.WriteLine(" *La cantidad total de Tecnicos es de: " + totalTecnicos);
                        Console.WriteLine(" *El acumulado del salario neto de Tecnicos es: " + acumuladoNetoTec);
                        Console.WriteLine(" *El promedio del salario neto de Tecnicos es:  " + promedioNetoTec);
                        Console.WriteLine("\n\n");

                        Console.WriteLine("                     PROFESIONALES");
                        Console.WriteLine(" *La cantidad total de Profesionales es de: " +totalProf);
                        Console.WriteLine(" *El acumulado del salario neto de Profesionales es: " + acumuladoNetoProf);
                        Console.WriteLine(" *El promedio del salario neto de Profesionales es:  " + promedioNetoProf);



                        break;  //break case 2

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                        default:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion!=2);

        }
    }
}
