namespace ContaBancaria.Models
{

    //Pilar herança Conta corrente herda de Conta bancaria
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(String numeroConta, String nomeTitular, decimal saldoInicial) : base(numeroConta, nomeTitular, saldoInicial)
        {

        }



        public override bool Sacar(decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                ExtratoTransacoes.Add($"Investimeto: -{valor} | Valor Atual: R$ {Saldo}");
               
            }
            return true;
        }

        //FUNCIONALIDADE DE INVESTIMENTO PARA OS CLIENTES NAO OBRIGATÓRIA

        public void Investir(decimal valor)
        {
            Saldo -= valor;
            decimal rendimento = valor * 1.05m; // Simula investimento com 5% de retorno imediato
            Saldo += rendimento;
            ExtratoTransacoes.Add($"Investimento Aplicado: R$ {valor:F2} (Rendeu para R$ {rendimento:F2}) | Saldo Atual: R$ {Saldo:F2}");

        }
     

       

    }
}


