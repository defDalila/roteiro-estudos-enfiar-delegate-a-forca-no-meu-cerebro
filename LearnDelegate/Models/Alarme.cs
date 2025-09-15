namespace LearnDelegate.Models;
public delegate void Notificacao(string msg);

public class Alarme
{
    // Evento baseado em delegate
    public event Notificacao AoDisparar;

    public void Disparar()
    {
        Console.WriteLine(">>> O alarme foi disparado!");

        // Invoca o evento (se houver inscritos)
        AoDisparar?.Invoke("Acorda, Dalila!");
    }
}
