using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BancoDeDados : MonoBehaviour
{
    [SerializeField] private ScriptableObjectBancoDeDados _bancoDeDados;

    public AbstractItens BuscarItem(string id)
    {
        AbstractItens itemProcurado = null;
        foreach (AbstractItens item in _bancoDeDados.ItensDoJogo)
        {
            if (item.Id == id)
            {
                itemProcurado = item;
                break;
            }
        }
        return itemProcurado;
    }
}
