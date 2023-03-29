// See https://aka.ms/new-console-template for more information

using HtmlAgilityPack;
Console.WriteLine("Qual o ano deseja verificar: ");
string ano = Console.ReadLine();

int totalPessoas = 0;
int valorMaiorMes = 0;
int numeroMes = 1;
for (int i = 1; i <= 12; i++)
{
    var html = @"https://www.transparencia.se.gov.br/Pessoal/VencimentoCargo.xhtml?codigo=4&ano=" + ano + "&mes=" + i.ToString();
    HtmlWeb web = new HtmlWeb();
    var htmlDoc = web.Load(html);
    var valorMes = 0;
    var tableComissionados = htmlDoc.GetElementbyId("frmPrincipal:Tabela1_data");
    var linhas = tableComissionados.SelectNodes(".//tr");

    foreach (var item in linhas)
    {
        try
        {
            var colunas = item.SelectNodes(".//td");
            totalPessoas = totalPessoas + Convert.ToInt32(colunas[2].InnerText);
            valorMes = valorMes + Convert.ToInt32(colunas[2].InnerText);
        }
        catch (Exception)
        {

            continue;
        }

    }
    Console.WriteLine("Quantidade no mês {0} é de: {1} ", i, valorMes);
    if (valorMes > valorMaiorMes)
    {
        numeroMes = i;
        valorMaiorMes = valorMes;
    }
}

Console.WriteLine("O Total Preeenchido é: {0} ", totalPessoas / 12);
Console.WriteLine("Mês com maior número de Pessos é: {0} ", numeroMes);
Console.WriteLine("Total de pessoa no mes maior é: {0} ", valorMaiorMes);


Console.ReadKey();
