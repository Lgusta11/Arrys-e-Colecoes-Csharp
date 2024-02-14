using bytebank.Modelos.ADM.SistemaInterno;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
            Senha = "SenhaPadrao"; // ou inicialize com um valor apropriado
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
