namespace TP1Taller2.Control{
    class ControlErrores{
        static public int IngresarNumero(){
            int num = 0;
            bool error = true;
            
            while(error){
                try{
                    num = Int32.Parse(Console.ReadLine());
                    error = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }

            return num;
        }

        static public char IngresarLetra(){
            char letra = ' ';
            bool error = true;
            
            while(error){
                try{
                    letra = Char.Parse(Console.ReadLine());
                    error = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }

            return letra;
        }

        static public string IngresarString(){
            string str = "";
            bool error = true;

            while(error){
                try{
                    str = Console.ReadLine();
                    if(str == "" || str == null) throw new ArgumentNullException(nameof(str));
                    error = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }

            return str;
        }

        static public DateTime IngresarFecha(){
            int dia, mes, anio;
            DateTime fecha = new();
            bool error = true;

            while(error){
                Console.WriteLine("Ingrese un día: ");
                dia = IngresarNumero();

                Console.WriteLine("Ingrese un mes: ");
                mes = IngresarNumero();

                Console.WriteLine("Ingrese un año: ");
                anio = IngresarNumero();

                try{
                    fecha = new DateTime(anio, mes, dia);
                    error = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Ocurrió un error al establecer la fecha: " + ex.Message);
                }
            }

            return fecha;
            
        }
    }
}