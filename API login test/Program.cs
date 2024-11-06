using System.Text.Json;
using API_login_test;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://dummyjson.com/users/5/");
        Usuarios usuario = JsonSerializer.Deserialize<Usuarios>(resposta);
        usuario.Informacoes();
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}