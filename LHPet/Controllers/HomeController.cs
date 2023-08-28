using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur Ferreira", "001.001.002-93", "arthur.ferreira@xurupingas.com.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Monica Nunes", "002.002.003-23", "monica.nunes@xurupingas.com.br", "Bug");
        Cliente cliente3 = new Cliente(03, "Carlson Bueno", "213.545.543-32", "arthur.ferreira@xurupingas.com.br", "Byron");
        Cliente cliente4 = new Cliente(04, "Madoka Shunshio", "834.434.556-44", "madoka.shunshio@xurupingas.com.br", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Uoxto Antunes", "632.674.232-54", "uoxto.antunes@xurupingas.com.br", "Loboc");
 
        // Lista Clientes
        List<Cliente> listaclientes = new List<Cliente>();
        listaclientes.Add(cliente1);
        listaclientes.Add(cliente2);
        listaclientes.Add(cliente3);
        listaclientes.Add(cliente4);
        listaclientes.Add(cliente5);

        ViewBag.listaclientes = listaclientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C Pet S/A", "23.244.121/0001-32", "cpet@cpet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Mais Dogs", "29.984.984/9093-34", "maisdogs@maisdogs.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Sonho de Cat", "47.892.374/2947-93", "sonho@sonhodecat.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Pet Roliços mas Lindinhos", "48.278.942/0001-43", "rolicos@rolicoslindinhos.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Drogapets", "32.490.932/0001-76", "drogapets01@drogapets.org");

        // Lista Fornecedores
        List<Fornecedor> listafornecedores = new List<Fornecedor>();
        listafornecedores.Add(fornecedor1);
        listafornecedores.Add(fornecedor2);
        listafornecedores.Add(fornecedor3);
        listafornecedores.Add(fornecedor4);
        listafornecedores.Add(fornecedor5);

        ViewBag.listafornecedores = listafornecedores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
