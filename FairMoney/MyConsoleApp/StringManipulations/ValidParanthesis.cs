public class ValidParanthesis
{
    public static bool IsValid(string input)
    {
        if (input == null) return true;

        Dictionary<char, char> ps = new() { { '(', ')' }, { '{', '}' }, { '[', ']' } };

        var chars = input.ToCharArray();

        Stack<char> chars1 = [];

        foreach (var c in chars)
        {
            if (ps.Keys.Contains(c))
            {
                chars1.Push(c);
            }
            else
            {
                var p = chars1.Pop();

                if (ps[p] != c) return false;
            }
        }

        return true;

    }
}