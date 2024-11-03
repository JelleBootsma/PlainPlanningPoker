using System.Collections.Concurrent;
using PlainPlanningPoker.Models;

namespace PlainPlanningPoker.Services;

public class SessionService
{
    private readonly ConcurrentDictionary<string, Session> _sessions = new();

    public Session CreateSession()
    {
        var code = GenerateSessionCode();
        var session = new Session { Code = code };
        _sessions[code] = session;
        return session;
    }

    public Session? GetSession(string code) => _sessions.TryGetValue(code, out var session) ? session : null;

    private string GenerateSessionCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        return new string(Enumerable.Repeat(chars, 6)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
