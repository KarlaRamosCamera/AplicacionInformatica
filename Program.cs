using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionInformatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pdestajo[] pdestajo =
            {
             new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);
            new Pdestajo("karla", 45678903456, "ramos", "camera", 12 - 04 - 2004);



        
    } }};

string seleccion = "";

{


do
{
    Console.WriteLine("ingrese tipo de empleado");
    Console.WriteLine("1 - contratado");
    Console.WriteLine("2 - por destajo");
    Console.WriteLine("3 - Salir");
    Console.Write("Seleccione una opción: ");


    int opcion;
    if (int.TryParse(Console.ReadLine(), out opcion))

    {
        switch (opcion)
        {
            case 1:
                seleccion = "contratado";
                break;

            case 2:
                seleccion = "por destajo";
                break;


            case 3:
                Console.WriteLine("Ha seleccionado Salir.");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

    }























        
    
