using System;

namespace MonPremierProjet;
public class EventPratique
{
    public event Action<string> OnMessageReçu;

    public EventPratique()
    {
        OnMessageReçu += EcrireBleu;
        OnMessageReçu += EcrireBlanc;
        OnMessageReçu += EcrireRouge;
    }

    public void EcrireMessage(string message)
    {
        Console.Clear();
        OnMessageReçu(message);
    }


    private void EcrireBleu(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private void EcrireBlanc(string message)
    {
        Console.WriteLine(message);
    }

    private void EcrireRouge(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
