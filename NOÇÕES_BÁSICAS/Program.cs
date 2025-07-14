using Projetos_C_SHARP.Models;
PessoaFisica PESSOA01 = new PessoaFisica(); //neste caso, o namespace está appontando para a pasta Models, que é onde a classe pessoa está alocada.  

PESSOA01.Nome_da_pessoa = "BUA";
PESSOA01.Nome_da_empresa = "brisanet";
PESSOA01.idade = 34;
PESSOA01.sexo = "masculino";

PESSOA01.Apresentar();
