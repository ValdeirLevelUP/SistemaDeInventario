using UnityEngine;
/// <summary>
/// Script base para criação de pocoes
/// </summary>
public abstract class AbstractPocoes : AbstractItens
{
    [SerializeField] private int _valorBase;
    public int Valor { get => _valorBase; } 

    /// <summary>
    /// Método abstrato para implementacao da pocao.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="personagem">Objeto que representa o personagem que vai utilizar a pocao.</param>
    public abstract void Usar<T>(T personagem);
}
