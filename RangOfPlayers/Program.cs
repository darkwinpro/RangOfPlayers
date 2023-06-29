using System;

public class Player
{
    public string? Nikcname;
    public int Score;
    
    public Player(string? name, int score)
    {
        Nikcname = name;
        Score = score;

    }
}

public class Program
{
    private static Player[] _players = new Player[10];
    
   
    public static void Main()
    {
        Input(_players);
        
        int repeat = Convert.ToInt32(Console.ReadLine());
        
        while (repeat > 0)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
                    
            switch (inputNumber)
            {
                case 1:
                    var newName = Console.ReadLine();
                    var newScore = Convert.ToInt32(Console.ReadLine());
                    Player newPlayer = new Player(newName, newScore);
                    if (newPlayer.Score > _players[9].Score)
                    {
                        _players[9] = newPlayer;
                        Sort();
                    }
                    break;
                
                case 2 :
                    var newPlayerName = Console.ReadLine();
                    var newPlayerScore = Convert.ToInt32(Console.ReadLine());
                    
                    for (var i = 0; i < _players.Length; i++)
                    {
                        var findName = string.Compare(newPlayerName, _players[i].Nikcname);
                        
                        if (findName == 0)
                        {
                            _players[i].Score += newPlayerScore;
                            Sort();
                            break;
                        }
                    }

                    break;

                default:
                    Sort();
                    var name = Console.ReadLine();
                    for (var i = 0; i < _players.Length; i++)
                    {
                        var findName = string.Compare(name, _players[i].Nikcname);
                        
                        if (findName == 0)
                        {
                            Console.WriteLine(i + 1);
                            break;
                        }
                    }
                    
                    break;
            
            }
            
            repeat--;
        }
        
    }

    private static void Input(Player[] players)
    {
        for (var i = 0; i < players.Length; i++)
        {
            var name = Console.ReadLine();
            var score = Convert.ToInt32(Console.ReadLine());
            players[i] = new Player(name, score);
        }
    }
    
   private static void Sort()
    {

        for (var i = _players.Length - 1; i > 0; i--)
        {
            if (_players[i].Score > _players[i-1].Score)
            {
                (_players[i], _players[i - 1]) = (_players[i - 1], _players[i]);
            }
            
        }
        
    }
   
}