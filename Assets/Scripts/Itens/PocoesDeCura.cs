using UnityEngine;

/// <summary>
/// Script que implementa uma pocao de cura.
/// </summary>
[CreateAssetMenu(fileName ="PocaoDeCura",menuName = "Prototipo/Itens/Poções/Poção de cura")]
public class PocoesDeCura : AbstractPocoes
{
    public override void Usar<T>(T personagem)
    {
        ///Exemplo de implentacao de funcao de cura.
        ///personagem.Vida += Valor;
    }
}
