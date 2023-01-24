using System.Diagnostics;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Nokia(string numero, string modelo, string imei, int memoria): base( numero,  modelo,  imei,  memoria)
        {
            Console.WriteLine($"Criando smartphone Nokia  de número: {numero}, modelo: {modelo}, imei: {imei} e memória: {memoria}" );
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Nokia.");
        }

    }
}