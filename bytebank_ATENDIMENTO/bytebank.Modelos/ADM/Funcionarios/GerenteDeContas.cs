﻿namespace bytebank.Modelos.ADM.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double GetBonificacao() // Correção aqui: mudar para GetBonificacao
        {
            return this.Salario * 0.25;
        }
    }
}
