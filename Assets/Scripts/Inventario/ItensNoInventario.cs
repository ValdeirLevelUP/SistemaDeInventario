 using UnityEngine; 
   
[System.Serializable]
public class ItensNoInventario  
{
    [SerializeField] private AbstractItens _item;
    public int _quantidade;

    public AbstractItens Item { get => _item; }

    public  int Quantidade  { get => _quantidade; }


    public void AlterarQuantidade(int quantidade = 1)
    {
        _quantidade += quantidade; 
    }

    public ItensNoInventario( AbstractItens item, int quantidade = 1)
    {
        _item = item;
        _quantidade = quantidade;
    }
}
