namespace csharp_exception;

public class OperacaoFinanceiraException : Exception
{
    public OperacaoFinanceiraException(string mensagem) : base(mensagem)
    {
        
    }
    
    public OperacaoFinanceiraException(string mensagem, Exception execaoInterna) : base(mensagem, execaoInterna)
    {
        
    }
}