namespace CSD.Common.Models
{
    public class Dinheiro
    {
        public double saldo = 0;
        public double alteracao = 0;
        public int mensagemPersonalizada = 0;
        public void exibirDinheiro()
        {
            Console.WriteLine($"\nDINHEIRO DISPONIVEL R${saldo}");

            switch(mensagemPersonalizada)
            {
                case 1:
                Console.WriteLine($"VOCÊ ADICIONOU R${alteracao}!");
                break;

                case 2:
                Console.WriteLine($"VOCÊ REMOVEU R${alteracao}!");
                break;
            }
        }
        public double adicionarDinheiro(double addDinheiro)
        {
            mensagemPersonalizada = 1;
            alteracao = addDinheiro;
            return saldo += addDinheiro;
        }

        public double removerDinheiro(double remDinheiro)
        {
            mensagemPersonalizada = 2;
            alteracao = remDinheiro;
            return saldo-=remDinheiro;
        }
    }
}