using ObraSocial.Domain.Enums;

namespace ObraSocial.Domain.Entities
{
    public class PessoaFisica : BaseEntity<PessoaFisica>
    {
        public PessoaFisica(string nome,
                            string cpf,
                            string rg,
                            string nomeDaMae,
                            string nomeDoPai,
                            DateTime dataNascimento,
                            byte[]? foto,
                            Raca raca,
                            string naturalidade,
                            string nacionalidade,
                            Sexo sexo,
                            List<ClassificacaoPessoaFisica> classificacao)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            NomeDaMae = nomeDaMae;
            NomeDoPai = nomeDoPai;
            DataNascimento = dataNascimento;
            Foto = foto;
            Raca = raca;
            Naturalidade = naturalidade;
            Nacionalidade = nacionalidade;
            Sexo = sexo;
            Classificacao = classificacao;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string NomeDaMae { get; private set; }
        public string NomeDoPai { get; private set; }
        public Raca Raca { get; private set; }
        public Sexo Sexo { get; private set; }
        public List<ClassificacaoPessoaFisica> Classificacao { get; private set; }
        public string Naturalidade { get; private set; }
        public string Nacionalidade { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Idade => CalcularIdade(DataNascimento);
        public byte[]? Foto { get; private set; }
        public List<Contato> Contatos { get; } = new List<Contato>();
        public List<Endereco> Enderecos { get; } = new List<Endereco>();

        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;

            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }

        public void AdicionarContato(Contato contato)
        {
            if (contato == null) return;

            Contatos.Add(contato);
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            if (endereco == null) return;

            Enderecos.Add(endereco);
        }
    }
}