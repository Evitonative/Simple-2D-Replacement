using System.Text;

public class Simple2DReplace{
    public static void Main(string[] args){
        if(args.Length < 2) return;
        int rad = int.Parse(args[0]);
        
        StringBuilder replaceInBuilder = new StringBuilder();
        for (int i = 1; i < args.Length; i++)
        {
            replaceInBuilder.Append(args[i]);
        }
        string replaceIn = replaceInBuilder.ToString();

        
                for (int i = -rad; i <= rad; i++)
        {
            for (int j = -rad; j <= rad; j++)
            {
                StringBuilder builder = new StringBuilder(replaceIn);
                builder.Replace("%1", i.ToString());
                builder.Replace("%2", j.ToString());
                Console.WriteLine(builder.ToString());
            }
        }
    }
}