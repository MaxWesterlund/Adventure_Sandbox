using Raylib_cs;

Draw draw = new();

Raylib.InitWindow(1600, 900, "Brane Gamie");

GameManager.ExcecuteActions();

while (!Raylib.WindowShouldClose()) {
    draw.DrawEverything();
}

Raylib.CloseWindow();