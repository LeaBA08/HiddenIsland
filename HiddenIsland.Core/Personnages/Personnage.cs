namespace HiddenIsland.Core.Personnages;

public abstract class Personnage
{
    public string Nom { get; }
    public int PointsDeVie { get; private set; }
    public int PointsDeVieMax { get; protected set; }
    public int ForceAttaque { get; protected set; }
    public int ForceDefense { get; protected set; }
    public bool EstVivant => PointsDeVie > 0;


    protected Personnage(string nom, int pointsDeVieMax, int forceAttaque, int forceDefense)
    {
        Nom = nom;
        PointsDeVieMax = pointsDeVieMax;
        ForceAttaque = forceAttaque;
        ForceDefense = forceDefense;
        PointsDeVie = pointsDeVieMax;
    }

    public void RecevoirDegats(int degats)
    {
        if (degats < 0)
        {
            return;
        }
        PointsDeVie = Math.Max(0, PointsDeVie - degats);
    }

    public virtual void Attaquer(Personnage cible)
    {
        cible.RecevoirDegats(ForceAttaque - cible.ForceDefense);
    }
}