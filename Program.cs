int primeiro, segundo, maiornumero;

Console.Write("Digite o primeiro número..: ");
primeiro = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número...: ");
segundo= Convert.ToInt32(Console.ReadLine());

if (primeiro > segundo)
{
    maiornumero = primeiro;
}
else
{
    maiornumero = segundo;
}

Console.WriteLine($"O maior número é {maiorNumero}");

