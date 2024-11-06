using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_login_test
{
    internal class Usuarios
    {
        [JsonPropertyName("firstName")]
        public string Nome { get; set; }
        [JsonPropertyName("gender")]
        public string Sexo { get; set; }
        [JsonPropertyName("city")]
        public string Cidade { get; set; }

   public void Informacoes()
        {
            Console.WriteLine($" Nome: {Nome}");
            Console.WriteLine($" Sexo: {Sexo}");
            Console.WriteLine($" Cidade: {Cidade}");
        }
    }


}
