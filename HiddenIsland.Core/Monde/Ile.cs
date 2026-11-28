namespace HiddenIsland.Core.Monde;
public class Ile
{
    public string Nom {get;}
    public Carte CarteIle {get;} // Pourquoi pas ajouter "private set"? on donne le minimum de droits nécessaires, et on les élargit seulement quand un vrai besoin apparaît.
    public Ile(string nom, Carte carteIle)
    {
        Nom = nom;
        CarteIle = carteIle;
    }
}
