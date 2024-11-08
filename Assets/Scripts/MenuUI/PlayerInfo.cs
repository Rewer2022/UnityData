using System;

public static class PlayerInfo
{
    private static string _name;

    static PlayerInfo()
    {
        _name = "Player";
    }

    public static string Name { get => _name; }

    public static void ChangeName(string name)
    {
        if (name != null)
        {
            _name = name;
        }
        else
        {
            throw new ArgumentNullException("Name cannot be null!");
        }
    }
}
