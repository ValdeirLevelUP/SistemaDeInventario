 using System.Collections.Generic;
/// <summary>
/// Script que representa os atributos dos personagem e equipamentos
/// </summary>
[System.Serializable]
public struct AtributoDoPersonagem 
{
    public int ValorBase;

    private readonly List<ModificadorDeAtributo> _modificadores; 
    public AtributoDoPersonagem(int ValorBase)
    {
        this.ValorBase = ValorBase;

        _modificadores = new List<ModificadorDeAtributo>();
    }  
    /// <summary>
    /// Método que retorna valor final do atributo.
    /// </summary>
    /// <returns></returns>
    public int GetValorFinalAtributo()
    {
        return ValorBase + SomaModificadores();
    }
    /// <summary>
    /// Método que retorna valor somados de todos os modificadores do atual atributo.
    /// </summary>
    /// <returns></returns>
    private int SomaModificadores()
    {
        int Mod = 0;

        foreach (ModificadorDeAtributo mod in _modificadores)
        {
            Mod += mod.ValorBase;
        }

        return Mod;
    }
}
/// <summary>
/// Script para componente dos atrivutos
/// </summary>
[System.Serializable]
public struct ModificadorDeAtributo
{
    public readonly int ValorBase;

    public ModificadorDeAtributo(int ValorBase)
    {
        this.ValorBase = ValorBase;
    }
}
