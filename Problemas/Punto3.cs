using TP1Taller2.Control;
using TP1Taller2.Clases;

namespace TP1Taller2.Problemas{
    class Punto3{
        static public void ApartadoA(){
            int cantidad;
            bool error;
            Empleado empleado = new();
            List<Empleado> listaEmpleados = new();

            Console.WriteLine("Ingrese una cantidad de trabajadores: ");
            do{
                cantidad = ControlErrores.IngresarNumero();
            }while(cantidad < 0);

            for(int i = 0; i < cantidad; i++){
                error = true;
                Console.WriteLine("Ingrese el nombre: ");
                empleado.Nombre = ControlErrores.IngresarString();

                Console.WriteLine("Ingrese el apellido: ");
                empleado.Apellido = ControlErrores.IngresarString();

                Console.WriteLine("Ingrese la fecha de nacimiento: ");
                empleado.FechaNac = DateOnly.FromDateTime(ControlErrores.IngresarFecha());
                while(empleado.Edad() < 18){
                    Console.WriteLine("Debe ingresar una fecha de nacimiento mayor a 18 años");
                    empleado.FechaNac = DateOnly.FromDateTime(ControlErrores.IngresarFecha());
                }

                Console.WriteLine("Ingrese la dirección: ");
                empleado.Direccion = ControlErrores.IngresarString();

                Console.WriteLine("Ingrese la fecha de ingreso: ");
                empleado.FechaIng = DateOnly.FromDateTime(ControlErrores.IngresarFecha());
                while(DateTime.Compare(empleado.FechaIng.ToDateTime(new TimeOnly(0)), DateTime.Now) > 0){
                    Console.WriteLine("Ingrese una fecha de ingreso válida: ");
                    empleado.FechaIng = DateOnly.FromDateTime(ControlErrores.IngresarFecha());
                }

                Console.WriteLine("Ingrese el salario: ");
                empleado.SalarioBasico = ControlErrores.IngresarNumero();

                Console.WriteLine("Ingrese la cantidad de hijos: ");
                empleado.CantHijos = ControlErrores.IngresarNumero();
                while(empleado.CantHijos < 0){
                    Console.WriteLine("Ingrese una cantidad válida de hijos: ");
                    empleado.CantHijos = ControlErrores.IngresarNumero();
                }

                Console.WriteLine("Ingrese el estado civil (C: casado, D: divorciado, S: soltero): ");
                while(error){
                    try{
                        empleado.EstadoCivil = Console.ReadLine()[0];
                        if(empleado.EstadoCivil != 'C' && empleado.EstadoCivil != 'D' && empleado.EstadoCivil != 'S') throw new Exception("Opción inválida");
                        error = false;
                    }
                    catch(Exception ex){
                        Console.WriteLine("Ocurrió un error: " + ex.Message);
                    }
                }

                if(empleado.EstadoCivil == 'D'){
                    Console.WriteLine("Ingrese la fecha de divorcio");
                    empleado.FechaDiv = DateOnly.FromDateTime(ControlErrores.IngresarFecha());
                    while(DateTime.Compare(empleado.FechaDiv.ToDateTime(new TimeOnly()), DateTime.Now) > 0){
                        Console.WriteLine("Ingrese una fecha de ingreso válida: ");
                        empleado.FechaDiv = DateOnly.FromDateTime(ControlErrores.IngresarFecha());
                    }
                }

                Console.WriteLine("Ingrese si el empleado tiene título (S: si, N: no): ");
                char t;
                t = ControlErrores.IngresarLetra();
                while(t != 'S' && t != 'N'){
                    Console.WriteLine("Ingrese una opción válida: ");
                    t = ControlErrores.IngresarLetra();
                }
                if(t == 'S') empleado.TieneTitulo = true;
                else empleado.TieneTitulo = false;

                if(empleado.TieneTitulo){
                    Console.WriteLine("Ingrese el título: ");
                    empleado.Titulo = ControlErrores.IngresarString();

                    Console.WriteLine("Ingrese la universidad: ");
                    empleado.Universidad = ControlErrores.IngresarString();
                }
                
                listaEmpleados.Add(empleado);
            }

            foreach(var emp in listaEmpleados){
                Console.WriteLine(emp);
            }
        }
    }
}