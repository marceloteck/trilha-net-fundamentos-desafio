namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0.0M;
        private decimal precoPorHora = 0.0M;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        private string ConvertStringReadLine()
        {
            return Convert.ToString(Console.ReadLine());
        }
        private decimal ConvertDecimalReadLine()
        {
            return Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(ConvertStringReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = ConvertStringReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal         

                // corrigindo erro caso o usuario digite um numero flutuante, definindo como decimal       
                decimal horas = ConvertDecimalReadLine();
                decimal valorTotal = this.precoInicial + this.precoPorHora * horas;
                string valorFinal = valorTotal.ToString("0.00");

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorFinal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculosEstacionados in veiculos)
                {
                    string MostrarVeiculos = $" - {veiculosEstacionados}";
                    Console.WriteLine(MostrarVeiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
