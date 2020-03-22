using System;

public static class Program
{
    public static void Main(string[] args)
    {
        string message = "Welcome to using a .NET Core global tool!";

        if (Console.IsInputRedirected)
        {
            message = Console.In.ReadToEnd();
        }
        else if (args.Length > 0)
        {
            message = string.Join(" ", args);
        }
        var connectionString = "mongodb+srv://gurdian-db:eYRGu3MOgdcb3F26@gurdian-com-g4rrm.mongodb.net/gurdian?retryWrites=true&w=majority";   

        Console.WriteLine(GetBot(message));
    }

    public static string GetBot(string message)
    {
        string bot = $"\n        {message}";
        bot += @"
    __________________
                      \
                       \
                          ....
                          ....'
                           ....
                        ..........
                    .............'..'..
                 ................'..'.....
               .......'..........'..'..'....
              ........'..........'..'..'.....
             .'....'..'..........'..'.......'.
             .'..................'...   ......
             .  ......'.........         .....
             .                           ......
            ..    .            ..        ......
           ....       .                 .......
           ......  .......          ............
            ................  ......................
            ........................'................
           ......................'..'......    .......
        .........................'..'.....       .......
     ........    ..'.............'..'....      ..........
   ..'..'...      ...............'.......      ..........
  ...'......     ...... ..........  ......         .......
 ...........   .......              ........        ......
.......        '...'.'.              '.'.'.'         ....
.......       .....'..               ..'.....
   ..       ..........               ..'........
          ............               ..............
         .............               '..............
        ...........'..              .'.'............
       ...............              .'.'.............
      .............'..               ..'..'...........
      ...............                 .'..............
       .........                        ..............
        .....
";
        return bot;
    }
}
