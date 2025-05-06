using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tpRazorPages.Pages.TP11
{
    public class StringPipelineModel : PageModel
    {
        public string ResultadoFinal { get; set; }

        public void OnGet()
        {
            Func<string, string, string> pipeline = Concatenar;

            pipeline += ParaMaiusculas;
            pipeline += RemoverEspacos;

            ResultadoFinal = pipeline("Jo�o", "Silva");
        }

        string Concatenar(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}";
            Console.WriteLine($"[Concatenar] => {resultado}");
            return resultado;
        }

        string ParaMaiusculas(string nomeCompleto, string _)
        {
            string resultado = nomeCompleto.ToUpper();
            Console.WriteLine($"[Mai�sculas] => {resultado}");
            return resultado;
        }

        string RemoverEspacos(string texto, string _)
        {
            string resultado = texto.Replace(" ", "");
            Console.WriteLine($"[Sem Espa�os] => {resultado}");
            return resultado;
        }
    }
}
