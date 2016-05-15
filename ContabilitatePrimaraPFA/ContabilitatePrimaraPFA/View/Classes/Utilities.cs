namespace ContabilitatePrimaraPFA.View.Classes
{
    using System;

    [Flags]
    public enum SearchDocCriteria : int
    {
        None = 0,
        NrDoc = 1,
        AnDoc = 2,
        TipDoc = 4,
        CnpBeneficiar = 6,
        NrContract = 8,
        NumeBeneficiar = 10,
        Uat = 12,
        Receptionata = 14,
        Respinsa = 16,
        InLucru = 18
    }
    public class Utilities
    {


    }
}
