using System.Net;
using System.Text.Json;
using TP1Taller2.Clases;

namespace TP1Taller2.Problemas{
    class Punto2{
        static public void Problema1(){
            int num;
            bool continuar = true;

            Console.WriteLine("Ingrese un número: ");
            while(continuar){
                try{
                    num = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"El cuadrado de {num} es {num * num}");
                    continuar = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Se produjo un error: " + ex.Message);
                }
            }
        }

        static public void Problema2(){
            int num1, num2;
            bool continuar = true;

            Console.WriteLine("Ingrese dos números: ");
            while(continuar){
                try{
                    num1 = Int32.Parse(Console.ReadLine());
                    num2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"La división entre {num1} y {num2} es {num1 / num2}");
                    continuar = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Se produjo un error: " + ex.Message);
                }
            }
        }

        static public void Problema3(){
            int km, litros;
            bool continuar = true;

            while(continuar){
                try{
                    Console.WriteLine("Ingrese los kilometros: ");
                    km = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese los litros: ");
                    litros = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Los kilometros por litros son {km / litros}");
                    continuar = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Se produjo un error: " + ex.Message);
                }
            }
        }

        static public void Problema4(){
        string url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
        var request = (HttpWebRequest)WebRequest.Create(url);
        Root listaProvincias;
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "applicacion/json";

        try{
            WebResponse respuesta = request.GetResponse();
            Stream strReader = respuesta.GetResponseStream();
            StreamReader objReader = new StreamReader(strReader);
            string responseBody = objReader.ReadToEnd();
            listaProvincias = JsonSerializer.Deserialize<Root>(responseBody);

            foreach(var i in listaProvincias.Provincias){
                Console.WriteLine($"ID: {i.Id}");
                Console.WriteLine($"Nombre: {i.Nombre}\n");
            }
        }
        catch(WebException error){
            Console.WriteLine("Ha ocurrido un problema: " + error.Message);
        }
        }
    }
}