public class Area
{
    private Link link;
    // private Monster monster;
    List<Monster> monsters = new();

    public Area()
    {
        link = new Link();
        monsters.Add(new Monster(30, 75));
        monsters.Add(new Monster(500, 145));

        // monsters[0].
        // monsters[1].


    }

    public void Update()
    {
        link.Update();

        foreach (Monster monster in monsters)
        {
            monster.Update();
        }
    }

    public void Draw()
    {
        link.Draw();
        foreach (Monster monster in monsters)
        {
            monster.Draw();
        }
        
    }
}