namespace ContaBancaria.Models
{
    //Classe Abstrata aplicando o Pilar da Abstração
    //uma classe abstrata não ser instanciada
    public abstract class ContaBancaria
    {
        //Pilar Encapsulamnto: Campos privados protegidos por
        //propriedades públicas
        private string _numeroConta;
        private decimal _saldo;

        //propriedde pública Numero Conta
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        //Propriedade pública Saldo
        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }
        // Propriedade´pública Nome titular
        public string NomeTitular { get; set; }

        // Propriedade´pública Histório para gerar extrato de transações
        public List<string> ExtratoTransacoes { get; set; } = new List<string>();

        //Construtor da classe base
        protected ContaBancaria(string numeroConta, decimal saldoInicial, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta criada com saldo de R${saldoInicial:F2}");
        }

        //Método Virtual (Polimorfismo ns classes filhas)
        public virtual void Depositar(decimal valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
                ExtratoTransacoes.Add($"Depósito: +R$ {valor:f2} | Saldo Atual: {Saldo:f2}");
            }
        }
        //Método abstrato obriga suas classes filhas a implementares suas próprias regras

        public abstract bool Sacar(decimal valor);



    }
}