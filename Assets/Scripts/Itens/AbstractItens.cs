using System; 
using UnityEngine;
/// <summary>
/// Script base para criação de itens.
/// </summary>
public abstract class AbstractItens : ScriptableObject
{ 
    #region PRIVATE VARIABLES  

    [SerializeField] private string _id;

    [SerializeField] private Sprite _icone;

    [SerializeField] private int _valorCompra;

    [SerializeField] private int _quantidadeMaximaEmpilhada;

    [SerializeField] private Raridade _raridade;

    [SerializeField] private TipoDeItem _tipo;

    [SerializeField] private bool _empilhavel; 

    [SerializeField] private string _nome;

    [TextArea(minLines: 2, 5)]
    [SerializeField] private string _descricao;

    #endregion 
    #region PROPERTIES

    public string Id{ get => _id; }
    public Sprite Icone { get => _icone; } 
    public int ValorDeCompra { get => _valorCompra; } 
    public int QuantidadeMaximaEmpilhada { get => _quantidadeMaximaEmpilhada; }
    public Raridade Raridade { get => _raridade;}
    public TipoDeItem Tipo { get => _tipo; }
    public  bool Empilhavel { get => _empilhavel; }  
    public String Nome { get => _nome; } 
    public String Descricao { get => _descricao; }

    #endregion 
} 
