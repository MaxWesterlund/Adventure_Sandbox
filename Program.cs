using Raylib_cs;

// Beskrivning: Main funktion, körs när programmet startar. Skapar ett nytt fönster och kallar på lämpliga funktioner. Stänger fönstret när programet körts klart.
// Return: void

Draw draw = new();

Raylib.InitWindow(1600, 900, "Text Adventure Game TM");

GameManager.ExcecuteActions();

while (!Raylib.WindowShouldClose()) {
    draw.DrawText();
}

Raylib.CloseWindow();