using BlockRenderer.Core;

public static class Program {
    public static ScreenWindow Swindow;

    public static void Main(string[] args) {

        Swindow = new ScreenWindow("Seagull Blocks");
        
        Swindow.Run();
        
    }
}