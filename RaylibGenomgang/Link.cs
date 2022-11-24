public class Link : Gameobjekt
{
    // hp, stamina, possition, bild, speed, hitbox, currentItem

    public Link()
    {   
        color = Color.GREEN;
    }

    public override void Update() 
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x++;
        }
    }
}