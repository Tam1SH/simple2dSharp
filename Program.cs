// See https://aka.ms/new-console-template for more information


using Simple2d;

var window = new Window("LOL", new Point(x:600, y:600));

var rect = new Rectangle(new Point(50,50), new Point(50,50));

var point = new Point(50, 50);

window.OnDraw(() =>
{
    point.X += 1;

    rect.MoveTo(point);

});
//window.UnsubscribeAll();

window.Run();
Console.ReadKey();
