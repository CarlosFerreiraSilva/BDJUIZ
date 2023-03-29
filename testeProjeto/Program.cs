// See https://aka.ms/new-console-template for more information


using HtmlAgilityPack;

var html = @"https://www.trabalhabrasil.com.br/";
HtmlWeb web = new HtmlWeb();
var doc = web.Load(html);
var titulo = doc.DocumentNode.SelectNodes("//*[@id=\"jobs-wrapper\"]").First().InnerText;
var tableComissionados = doc.GetElementbyId("//*[@id=\"jobs-wrapper\"]");
Console.WriteLine(tableComissionados);
Console.WriteLine(titulo);

var res = doc.DocumentNode
    .SelectNodes(".//div[@class='jg__container jg__job']");
Console.WriteLine("res",res);

var innerContent = doc.DocumentNode.SelectNodes("//div[contains(@class, 'jg__job')]").Select(x => x.InnerText.Trim());

foreach (var item in innerContent)
{
    Console.WriteLine(item.Trim());
    Console.WriteLine("");
}
  

Console.ReadLine();
    
