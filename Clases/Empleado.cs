namespace TP1Taller2.Clases{
    class Empleado{
        private string nombre;
        private string apellido;
        private DateOnly fechaNac;
        private string direccion;
        private DateOnly fechaIng;
        private string cargo;
        private int salarioBasico;
        private char estadoCivil;
        private int cantHijos = 0;
        private DateOnly fechaDiv;
        private bool tieneTitulo = false;
        private string? titulo = null;
        private string? universidad = null;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateOnly FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateOnly FechaIng { get => fechaIng; set => fechaIng = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int SalarioBasico { get => salarioBasico; set => salarioBasico = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public int CantHijos { get => cantHijos; set => cantHijos = value; }
        public DateOnly FechaDiv { get => fechaDiv; set => fechaDiv = value; }
        public bool TieneTitulo { get => tieneTitulo; set => tieneTitulo = value; }
        public string? Titulo { get => titulo; set => titulo = value; }
        public string? Universidad { get => universidad; set => universidad = value; }

        public Empleado() {}

        public int Antiguedad(){
            return DateTime.Now.Year - fechaIng.Year;
        }

        public int Edad(){
            return DateTime.Now.Year - fechaNac.Year;
        }

        public float Salario(){
            float salario = (float)salarioBasico;

            if(Antiguedad() == 1) salario += (float)(salario * 0.01) - (float)(salario * 0.15);
            else if(Antiguedad() == 2) salario += (float)(salario * 0.02) - (float)(salario * 0.15);
            else if(Antiguedad() <= 20) salario += (float)(salario * 0.15) - (float)(salario * 0.15);
            else salario += (float)(salario * 0.25) - (float)(salario * 0.15);

            return salario;
        }

        public override string ToString()
        {
            return $"Apellido: {Apellido}\nNombre: {Nombre}\nAntiguedad: {Antiguedad()}\nSalario: {Salario()}";
        }
    }
}