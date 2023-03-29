// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;
using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {

        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://www.trabalhabrasil.com.br/");

        // /html/body/section/section/main/devsite-content/article/div[2]/div[1]/table/tbody/tr[1]/td[1]
        //var value = doc.DocumentNode.SelectNodes("//*[@id=\"cphConteudo_pnlUltimasVagas\"]").First().InnerText;
        //var vaga = doc.DocumentNode.SelectSingleNode("//*[@id=\"jobs-wrapper\"]");//a partir desse ponto
        //var titulo = vaga.SelectNodes("//div[contains(@class, 'job__name')]").Select(x => x.InnerText.Trim());
        //var empresa = doc.DocumentNode.SelectNodes("//div[contains(@class, 'job__company')]").Select(x => x.InnerText.Trim());
        //var salario = doc.DocumentNode.SelectNodes("//div[contains(@class, 'job__detail')]").Select(x => x.InnerText.Trim());
        //var descricao = doc.DocumentNode.SelectNodes("//div[contains(@class, 'job__description')]").Select(x => x.InnerText.Trim());

        var body = doc.DocumentNode.SelectSingleNode("/html/body");
        var titulo = body.SelectNodes("//h2[contains(@class, 'job__name')]").Select(x => x.InnerText.Trim());
        var empresa = body.SelectNodes("//h3[contains(@class, 'job__company')]").Select(x => x.InnerText.Trim());
        var descricao = body.SelectNodes("//p[contains(@class, 'job__description')]").Select(x => x.InnerText.Trim());

        Console.WriteLine("Titulo");
        foreach (var item in titulo)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Empresa");
        foreach (var item in empresa)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Descrição");
        foreach (var item in descricao)
        {
            Console.WriteLine(item);
        }




    }
}
