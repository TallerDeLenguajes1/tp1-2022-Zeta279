using TP1Taller2.Problemas;
using TP1Taller2.Control;

namespace TP1Taller2{
    class Program{
        static void Main(string[] args){
            int opcion;
            bool error = true;

            Console.WriteLine("Ingrese un punto: ");
            opcion = ControlErrores.IngresarNumero();

            if(opcion == 2){
                Console.WriteLine("Ingrese un problema: ");
                opcion = ControlErrores.IngresarNumero();
                if(opcion == 1) Punto2.Problema1();
                if(opcion == 2) Punto2.Problema2();
                if(opcion == 3) Punto2.Problema3();
                if(opcion == 4) Punto2.Problema4();
            }
            else if(opcion == 3){
                Console.WriteLine("Ingrese un problema: ");
                opcion = ControlErrores.IngresarNumero();
                if(opcion == 1) Punto3.ApartadoA();
            }
        }

        
    }
}