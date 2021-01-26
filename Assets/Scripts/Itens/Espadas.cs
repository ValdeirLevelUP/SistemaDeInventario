using UnityEngine;
/// <summary>
/// Scripta base para criação de espadas
/// </summary>
[CreateAssetMenu(fileName ="Espada",menuName ="Prototipo/Itens/Criar itens/Espadas")]
public class Espadas : AbstractItens
{
    #region PRIVATE VARIABLES

    [SerializeField] private AtributoDoPersonagem _dano;

    [SerializeField] private AtributoDoPersonagem _defesa;

    #endregion

    #region PROPERTIES

    public AtributoDoPersonagem Dano { get => _dano; }
    public AtributoDoPersonagem Defesa { get => _defesa; }

    #endregion
}
