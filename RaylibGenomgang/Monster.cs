public class Monster : Gameobjekt
{
    public Monster(float x, float y)
    {
        color = Color.BLUE;
        Random generator = new();

        rect.x = x;
        rect.y = y;

        // rect.x = generator.Next(700);
        // rect.y = generator.Next(500);
    }
    public override void Update()
    {
        rect.y++;
    }
}