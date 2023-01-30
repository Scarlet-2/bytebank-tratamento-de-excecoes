namespace csharp_exception;

public class SaldoInsuficienteException : Exception
{
    // Base e usado para criar uma instancia de Exception com uma mensagem customizada
    public SaldoInsuficienteException(string mensagem) : base(mensagem)
    {
    }
}