namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
        public Nokia(string nome, string numero, string modelo, string imei, int memoria) : base(nome, numero, modelo, imei, memoria)
        {

        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O app {nomeApp} foi instalado com sucesso");
        }

    }
}
