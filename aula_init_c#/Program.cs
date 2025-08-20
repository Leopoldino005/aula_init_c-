//Calculadora de reajuste IRPF e tratativas de erro do usuário

try
{
    decimal salario, irpfDevido;
    Console.Write("Informe o seu salário: ");
    salario = decimal.Parse(Console.ReadLine());

    if (salario <= 2428.8m)
        irpfDevido = 0;
    else if (salario <= 2826.6m)
        irpfDevido = salario * 0.075m - 182.16m;
    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 394.16m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 675.49m;
    else
        irpfDevido = salario * 0.275m - 908.73m;
    Console.WriteLine($"Para o salário {salario:C2} o IRPF a ser pago é {irpfDevido:C2}.");

}
catch(FormatException) //Trata o erro de forma~ção de entreda para o valor do "salário"
{
    Console.WriteLine("Use apenas valores númericos");
}
catch(Exception e) //Trata qualquer tipo de erro
{
    Console.WriteLine("Ocorreu um erro entre em contato com o suporte");
    Console.WriteLine(e.ToString()); //Imprime na tela o erro momentâneo
}
