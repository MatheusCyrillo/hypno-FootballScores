
Console.WriteLine("Digite quantos jogos o time A jogou: ");

var n = Convert.ToInt32(Console.ReadLine());

while(n < 2)
{
    n = Convert.ToInt32(Console.ReadLine());
}

var teamA = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Digite quantos gols o time A fez no jogo {i+1}: ");
    var gols = Convert.ToInt32(Console.ReadLine());
    teamA[i] = gols;
}

Console.WriteLine("Digite quantos jogos o time B jogou: ");

var m = Convert.ToInt32(Console.ReadLine());

while (m > 105)
{
    m = Convert.ToInt32(Console.ReadLine());
}

var teamB = new int[m];
var result = new int[m];

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Digite quantos gols o time B fez no jogo {i+1}: ");
    var gols = Convert.ToInt32(Console.ReadLine());
    teamB[i] = gols;

    var count = 0;
    for (int j = 0; j < n; j++)
    {
        if (teamB[i] >= teamA[j])
        {
            count++;
        }
    }
    result[i] = count;
}

Console.WriteLine("Resultado: ");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}



