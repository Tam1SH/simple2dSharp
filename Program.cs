// See https://aka.ms/new-console-template for more information


using Simple2d;

var window = new Window("LOL", new Point(x:200, y:200));

var rect = new Rectangle(new Point(50,50), new Point(50,50));

window.OnDraw(() =>
{
    Console.WriteLine("Draw");
});
//window.UnsubscribeAll();

window.Run();
Console.ReadKey();
