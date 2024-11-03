using System.Collections.Generic;

namespace PlainPlanningPoker.Models;

public class Session
{
    public string Code { get; set; }
    public List<Player> Players { get; set; } = new();
    public bool CardsRevealed { get; set; } = false;
}
