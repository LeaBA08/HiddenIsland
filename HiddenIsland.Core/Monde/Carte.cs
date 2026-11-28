namespace HiddenIsland.Core.Monde;
public class Carte
{
    private Case[,] Grille;
    public Carte(Case[,] grille)
    {
        Grille = grille;
    }
    public bool EstDansLaLimite(int x, int y)
    {
        return (x >= 0 && x<= Grille.GetLength(0)-1 && y>= 0 && y <= Grille.GetLength(1)- 1);
    }
}