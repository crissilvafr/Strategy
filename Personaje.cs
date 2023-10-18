public class Personaje
{
    private IAtaqueStrategy _estrategia;

    public void EstrategiaAtaque(IAtaqueStrategy estrategia)
    {
        _estrategia = estrategia;
    }

    public void RealizarAtaque()
    {
        _estrategia.Atacar();
    }
}
