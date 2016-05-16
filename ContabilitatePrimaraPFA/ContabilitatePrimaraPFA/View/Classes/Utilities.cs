namespace ContabilitatePrimaraPFA.View.Classes
{
    using System;

    [Flags]
    public enum SearchCriteria : int
    {
        None            = 0 << 0, //0000
        NrDoc           = 1 << 0, //0001
        An              = 1 << 1, //0010
        TipDoc          = 1 << 2, //0100
        CnpBeneficiar   = 1 << 3, //1000
        NrContract      = 1 << 4,
        NumeBeneficiar  = 1 << 5,
        Uat             = 1 << 6,
        Receptionata    = 1 << 7,
        Respinsa        = 1 << 8,
        InLucru         = 1 << 9,
        Suma            = 1 << 10,

       
    }
  }
