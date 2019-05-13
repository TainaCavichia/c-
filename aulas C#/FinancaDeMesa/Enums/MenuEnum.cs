namespace FinancaDeMesa.Enums
{
    public enum MenuEnum : uint
    {
        CADASTRO_DE_USUÁRIO,
        LOGIN,
        SAIR
        
    }
    public enum MenuLogadoEnum: uint
    {
        CADASTRAR_TRANSAÇÕES,
        EXTRATO_DE_TRANSAÇÕES,
        FAZER_RELATÓRIO_NO_WORD,
        EXPORTAR_BANCO_DE_DADOS,
        SAIR
    }

    public enum TipoTransacaoEnum: uint
    {
        DESPESA,
        RECEITA
    }
}