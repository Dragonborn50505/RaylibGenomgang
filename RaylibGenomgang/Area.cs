public class Area
{
    private Link link;
    private Monster monster;

    public Area()
    {
        link = new Link();
        monster = new Monster();
    }

    public void Update()
    {
        link.Update();
        monster.Update();
    }

    public void Draw()
    {
        link.Draw();
        monster.Draw();
    }
}