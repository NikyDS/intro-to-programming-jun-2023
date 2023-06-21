namespace Games
{
    public class BowlingGame
    {
        private readonly Dictionary<string, int> _scores = new(); 
        public void AddPlayer(string name, int score)
        {
            _scores.Add(name, score);
            //score some kind of list of players and their scores 
            //unless a player with that same name already exists. 
            //in that case, punch them in the nose. 
        }
    }
}