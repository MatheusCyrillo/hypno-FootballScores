var n = AskForNumberOfMatches("A");
var teamA = new int[n];

for (int i = 0; i < n; i++)
{
    AskForNumberOfGoals(teamA, i, "A");
}

OrdenedTeam(n, teamA);

var m = AskForNumberOfMatches("B");

var teamB = new int[m];

var result = new int[m];

for (int i = 0; i < m; i++)
{
    AskForNumberOfGoals(teamB, i, "B");
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (teamB[i] >= teamA[j])
        {
            result[i] = n - j;
            break;
        }
    }
}


Console.WriteLine("Resultado: ");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

static int AskForNumberOfMatches(string time)
{
    int n;
    do
    {
        Console.WriteLine($"Digite quantos jogos o time {time} jogou: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    while (n < 2 || n > 105);
    return n;
}

static void AskForNumberOfGoals(int[] team, int i, string teamName)
{
    Console.WriteLine($"Digite quantos gols o time {teamName} fez no jogo {i + 1}: ");
    var gols = Convert.ToInt32(Console.ReadLine());
    team[i] = gols;
}

static void OrdenedTeam(int n, int[] teamA)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (teamA[j] < teamA[j + 1])
            {
                var aux = teamA[j];
                teamA[j] = teamA[j + 1];
                teamA[j + 1] = aux;
            }
        }
    }
}