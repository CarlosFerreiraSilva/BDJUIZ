// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;
using HtmlAgilityPack;

//var html = @"";
//HtmlWeb web = new HtmlWeb();
//var htmlDoc = web.Load(html);
//var tableComissionados = htmlDoc.GetElementbyId("heading");
//var linhas = tableComissionados.SelectNodes(".//h3");
//Console.WriteLine(linhas);

// See https://aka.ms/new-console-template for more information
//using HtmlAgilityPack;
//using System.Reflection.Metadata;

HtmlWeb web = new HtmlWeb();
HtmlDocument glassdoorSite = web.Load("https://tecnologia.vagas.com.br/");

var glassdoorTitulo = glassdoorSite.DocumentNode.SelectNodes("//*[@id=\"gatsby-focus-wrapper\"]/div[2]/main/section[2]/div/div").First().InnerText;

HtmlDocument trabalhabrasilSite = web.Load("https://www.trabalhabrasil.com.br/");

var trabalhabrasilVagas = trabalhabrasilSite.DocumentNode.SelectNodes("//*[@id=\"jobs-wrapper\"]").First().InnerText;

HtmlDocument cathoSite = web.Load("https://www.catho.com.br/vagas/se/estancia/");

var cathoVagas = cathoSite.DocumentNode.SelectNodes("//*[@id=\"search-result\"]/ul").First().InnerText;

Console.WriteLine(glassdoorTitulo);
Console.WriteLine(trabalhabrasilVagas);
Console.WriteLine(cathoVagas);




//*[@id="input"]