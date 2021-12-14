public class GameData 
{
    private static GameData instance;
    public int test { get; set; }
    private GameData()
    {
        if (instance != null)
            return;
        instance = this;
    }
    public static GameData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameData();
            }
            return instance;
        }
    }

    //private variable score
    private int score = 0;
    //first way to write a get/set function to your private variables
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    //second way to write a get/set function to your private variables
    public int Lives
    {
        get;
        set;
    }
}
