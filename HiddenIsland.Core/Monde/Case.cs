//"public" class est important pour que la classe soit visible dans .Web aussi
namespace HiddenIsland.Core.Monde;
public class Case {
    public TypeCase Terrain {get; private set;}

    public Case(TypeCase terrain)
    {
        Terrain = terrain;
    }

    public bool EstFranchissable()
    {
        return Terrain == TypeCase.Herbe;
    }
}