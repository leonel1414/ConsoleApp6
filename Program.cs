namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.inicializar();
            triangulo.LadoMayor();
            triangulo.EsEquilatero();
        }
    }
}