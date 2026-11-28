namespace HiddenIsland.Core.Monde;
public class Carte
{
    private Case[,] Grille;
    public Carte(Case[,] grille)
    {
        Grille = grille;
    }
    public int Largeur => Grille.GetLength(0);
    public int Hauteur => Grille.GetLength(1);
    public bool EstDansLaLimite(int x, int y)
    {
        return (x >= 0 && x<= Grille.GetLength(0)-1 && y>= 0 && y <= Grille.GetLength(1)- 1);
    }
    public Case? ObtenirCase(int x, int y)
    {
        if (!EstDansLaLimite(x, y))
        {
            return null; //car c'est à un joueur d'essayer de sortir de la limite
        }
        return Grille[x,y];
    }
}