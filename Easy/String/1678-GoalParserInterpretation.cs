
public class Problem1678
{
    public string Solution(string command)
    {
        return command.Replace("()", "o").Replace("(al)", "al");
    }
}

