namespace RockPaperScissors
{
    public class ShortAttentionSpanAI : IPlayer
    {
        int SaveResultNextMove;
        public int NextMove()
        {
            if (SaveResultNextMove == 0)
            { 
                return 1;
            }
            else if (SaveResultNextMove == 1)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public void SaveResult(int myMove, int otherMove)
        {
            SaveResultNextMove = otherMove;
        }
    }
}