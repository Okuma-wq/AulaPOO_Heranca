using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.cpf = "427.264.400-96";

            pf.nome = "Rodrigo";

            PessoaJuridica pj = new PessoaJuridica();

            pj.nome = "Palacio do Pão";

            pj.cnpj = "62.350.517/0001-68";

            pj.inscricaoEstadual = "99.999.9999-9";

            Console.WriteLine("Seja bem-vindo!");
            Console.WriteLine("Qual serviço deseja utilizar?");
            Console.WriteLine("[1] - Pessoa Física");
            Console.WriteLine("[2] - Pessoa Jurídica");
            string resposta = Console.ReadLine();

            switch (resposta){
                case "1":
                    Console.WriteLine("Digite seu CPF: 427.264.400-96");
                    Console.WriteLine(pf.ValidarCPF(pf.cpf));
                    Console.WriteLine(pf.IsCpf(pf.cpf));
                    Console.WriteLine(pf.DarBoasVindas(pf.nome));
                    break;
                case "2":
                    Console.WriteLine("Digite seu CNPJ: 62.350.517/0001-68");
                    Console.WriteLine(pj.ValidarCNPJ(pj.cnpj));
                    Console.WriteLine(pj.IsCnpj(pj.cnpj));
                    Console.WriteLine(pj.DarBoasVindas(pj.nome));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            
        }
    }
}
