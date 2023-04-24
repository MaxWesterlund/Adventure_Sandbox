using Raylib_cs;

Draw draw = new();

Raylib.InitWindow(800, 480, "Hello World");

GameManager.ExcecuteActions();

while (!Raylib.WindowShouldClose()) {
    draw.DrawEverything();
}

Raylib.CloseWindow();