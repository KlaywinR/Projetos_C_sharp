namespace PROJETOS_C_SHARP.Models;

public class Animal
{
    public float Nome_do_animal { get; set; }
    public int Idade { get; set; }
    public float Peso { get; set; }

    public void Apresentar()
    {
        Animal.Apresentar($"O nome do animal eh{Nome_do_animal}, ele tem {idade} anos, possui{Peso} kilos.");

    }
} 
 