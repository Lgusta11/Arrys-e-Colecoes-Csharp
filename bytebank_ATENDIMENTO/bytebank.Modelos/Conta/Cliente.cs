namespace bytebank.Modelos.Conta
{
    public class Cliente
    {
        private string? _cpf;
        private string? _nome;
        private string? _profissao;

        public string? Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string? Nome
        {
            get { return _nome; }
            set
            {
                if (value?.Length >= 3)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
                }
            }
        }

        public string? Profissao
        {
            get { return _profissao; }
            set { _profissao = value; }
        }

        public static int TotalClientesCadastrados { get; private set; }

        public Cliente()
        {
            TotalClientesCadastrados++;
        }
    }
}
