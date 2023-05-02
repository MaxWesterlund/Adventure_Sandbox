using Raylib_cs;

Draw draw = new();

Raylib.InitWindow(800, 400, "Text Adventure Game TM");

GameManager.ExcecuteActions();

while (!Raylib.WindowShouldClose()) {
    draw.DrawEverything();
}

Raylib.CloseWindow();