using System.Text;

bool addNumero = false;
bool addMaiuscula = false;
bool addMinuscula = false;
bool addEspecial = false;


Console.WriteLine("---------Bem vindo ao Gerador de Senhas---------");

Console.WriteLine("Digite o tamanho da senha:");
int tamanho = int.Parse(Console.ReadLine());


Console.WriteLine("Deseja adicionar números? (1 para sim, 2 para não)");
int numero = int.Parse(Console.ReadLine());

addNumero = numero == 1 ? true : false;

Console.WriteLine("Deseja adicionar letras maiusculas? (1 para sim, 2 para não)");
int maiuscusla = int.Parse(Console.ReadLine());

addMaiuscula = maiuscusla == 1 ? true : false;

Console.WriteLine("Deseja adicionar letras minusculas? (1 para sim, 2 para não)");
int minuscula = int.Parse(Console.ReadLine());

addMinuscula = minuscula == 1 ? true : false;

Console.WriteLine("Deseja adicionar caracteres especiais? (1 para sim, 2 para não)");
int especial = int.Parse(Console.ReadLine());

addEspecial = especial == 1 ? true : false;


String numeros = "123456789";
String letraMaiuscula = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
String letraMinuscula = "abcdefghijklmnopqrstuvwxyz";
String caracteresEspeciais = "!@#$%&*()_+-=[]{}|;:,.<>?";

var listaCaracteres = new StringBuilder();

if (addNumero)
{
    listaCaracteres.Append(numeros);
}

if (addMaiuscula)
{
    listaCaracteres.Append(letraMaiuscula);
}

if (addMinuscula)
{
    listaCaracteres.Append(letraMinuscula);
}

if (addEspecial)
{
    listaCaracteres.Append(caracteresEspeciais);
}

var senha = new StringBuilder();
var random = new Random();

for (int i = 0; i < tamanho; i++)
{
    int index = random.Next(0, listaCaracteres.Length);
    senha.Append(listaCaracteres[index]);
}

Console.WriteLine("A senha gerada é: " + senha.ToString());