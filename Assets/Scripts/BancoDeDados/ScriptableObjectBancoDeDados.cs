using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script responsavel por armazenar e buscar todos os itens do jogo.
/// </summary>
[CreateAssetMenu(fileName ="Banco De Dados",menuName ="Prototipo/Banco de dados")]
public class ScriptableObjectBancoDeDados : ScriptableObject
{
    [SerializeField] private List<AbstractItens> _itensDoJogo;


    public List<AbstractItens> ItensDoJogo { get => _itensDoJogo; }


}
