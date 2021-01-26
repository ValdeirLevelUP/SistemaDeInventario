using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script para gerenciamento do inventario.
/// </summary>
public class Inventario : MonoBehaviour
{
    #region PRIVATE VARIABLES

    [SerializeField] private List<ItensNoInventario> _inventario;

    [SerializeField] private int _quantidadeDeSlot;

    #endregion

    #region PROPERTIES

    public List<ItensNoInventario> InventarioAtivo { get => _inventario; }

    #endregion

    #region UNITY METHODS
    private void Start()
    {
        /// Teste de inventario
        AbstractItens espada = FindObjectOfType<BancoDeDados>().BuscarItem("ESP01");
        AbstractItens pocao = FindObjectOfType<BancoDeDados>().BuscarItem("POC01");
        try
        {
            AdicionarItemNoInventario(espada, 3);
            AdicionarItemNoInventario(pocao, 10);
            RemoverItemDoInventario(pocao, 5);
        }catch(Exception e)
        {
            Debug.Log(e.Message);
        }
    }
    #endregion

    #region OWN METHODS

    /// <summary>
    /// Método responsavel gerenciar a adicao de novos itens no inventario.
    /// </summary>
    /// <param name="novoItem"> Item a ser adicionado ao inventário</param>
    /// <param name="quantidade">Quantidade de itens a serem adicionados</param>
    public void AdicionarItemNoInventario(AbstractItens novoItem, int quantidade = 1)
    {
        if (_quantidadeDeSlot == _inventario.Count)
        {
            throw new Exception("Inventário cheiro");
        }

        if(novoItem.Empilhavel == true)
        {
            foreach(ItensNoInventario itemNoInventario in _inventario)
            {
                if(itemNoInventario.Item.Nome == novoItem.Nome)
                {
                    if(itemNoInventario.Quantidade + quantidade > novoItem.QuantidadeMaximaEmpilhada)
                    {
                        if(_quantidadeDeSlot == _inventario.Count + 1)
                        {
                            throw new Exception("Inventario cheio");
                        }
                        ///remover redundancia.
                        int novaQuantidade = quantidade - (itemNoInventario.Item.QuantidadeMaximaEmpilhada - itemNoInventario.Quantidade);

                        itemNoInventario.AlterarQuantidade(itemNoInventario.Item.QuantidadeMaximaEmpilhada - itemNoInventario.Quantidade);   
                        
                        AdicionarItem(novoItem, novaQuantidade); 
                    }
                    else
                    {
                        itemNoInventario.AlterarQuantidade(quantidade);
                    }
                    return;
                }
            }
            AdicionarItem(novoItem, quantidade);
        }
        else
        {
            for (int i = 0; i < quantidade; i++)
            {
                AdicionarItem(novoItem,1);
            }
        }
    }
    /// <summary>
    /// Método responsavel por adicionar um novo item no inventario;
    /// </summary>
    /// <param name="item"></param>
    /// <param name="quantidade"></param>
    private void AdicionarItem(AbstractItens item, int quantidade)
    {
        _inventario.Add(new ItensNoInventario(item, quantidade));
    }
    /// <summary>
    /// Método responsavel por retirar itens do inventário.
    /// </summary>
    /// <param name="item">Item a ser removido do invetario</param>
    /// <param name="quantidade">Quantidade a ser removida</param>
    public void RemoverItemDoInventario(AbstractItens item, int quantidade = 1)
    {
        foreach (ItensNoInventario itemNoInventario in _inventario)
        {
            if(itemNoInventario.Item.Id == item.Id)
            {
                if(itemNoInventario.Quantidade - quantidade >= 0)
                {
                    itemNoInventario.AlterarQuantidade(-quantidade);
                    return;
                }
                else
                {
                    throw new Exception("A quantidade a ser retirada é maior que a quantidade excistente");
                }
            }
        }
        throw new Exception("O item indicado nao é um dos itens do inventario");
    }
    #endregion
}
