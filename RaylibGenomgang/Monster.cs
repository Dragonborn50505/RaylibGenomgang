public class Monster : Gameobjekt
{
    public Monster()
    {
        color = Color.BLUE;
        rect.x = 100;
    }
    public override void Update()
    {
        rect.y++;
    }
}