global using Raylib_cs;
//using Raylib_cs.Raylib;

Raylib.InitWindow(800,600, "inte Zelda");
Raylib.SetTargetFPS(60);

//Link link = new Link();
Area map = new Area();

while (!Raylib.WindowShouldClose())
{
    // logik
    //link.Update();
    map.Update();


    // grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

        //link.Update();
        map.Draw();


    Raylib.EndDrawing();
}