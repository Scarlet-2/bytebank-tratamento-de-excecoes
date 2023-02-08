﻿using csharp_exception;
using csharp_exception.Contas;

try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
    /*
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
    */


}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    // Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
    throw new OperacaoFinanceiraException("Problema", ex);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente");
    Console.WriteLine(ex.Message);
}