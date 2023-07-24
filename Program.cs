static void Calcular(){

Console.Clear();

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine($"Bem Vindo {nome}, Vamos calcular IMC");

Console.WriteLine("Digite seu peso: (Exemplo 85)") ;
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura: (Exemplo 1,80)");
float alt = float.Parse(Console.ReadLine());

var resultado = peso / (alt * alt);
var nform = float.Parse(resultado.ToString("0.00"));


if(nform < 18){
    Console.WriteLine($"{nome}, você esta no estado de magreza");
}else if(nform > 18.1 && nform < 25){
    Console.WriteLine($"{nome}, você esta no peso normal");
}else if(nform > 25.1 && nform < 30){
    Console.WriteLine($"{nome}, você esta no estado de sobrepeso");
}else if(nform > 30.1 && nform < 40){
    Console.WriteLine($"{nome}, você esta no estado de obesidade");
}else{
    Console.WriteLine($"{nome} Procure um médico, seu estado é grave");
}


}

Calcular();