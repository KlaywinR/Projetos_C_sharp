//CRIANDO UMA CLASSE EM C#


namespace PROJETOS_C_SHARP.Models;
public class PessoaFisica // nome da classe, neste caso, o nome desta classe é PessoaFisica.Também, vae ressaltar que sempre no nome de classes se usa "PascalCase"
{
    public string Nome_da_pessoa { get; set; }   // estas são as propiedades da classe! //está sendo usada a "snake_case".
    public int idade { get; set; }
    public string sexo { get; set; }
    public float peso { get; set; }  // o "get" serve para pegar o valor, já quando o valor é atribuido se usa o "set".
    public float altura { get; set; }
    public string cargo_trabalhista { get; set; } // está sendo usada a "snake_case".

    public string Nome_da_empresa { get; set; } // está sendo usada a "snake_case".

    public void Apresentar()   // isto se chama método, justamente o que a classe vai fazer! 
    {
        PessoaFisica.Apresentar($" Ola meu nome e {Nome_da_pessoa}, tenho {idade}, recentemente ocupo o cargo de {cargo_trabalhista} na empresa {Nome_da_empresa}, e sou do sexo {sexo}");
    }
}
