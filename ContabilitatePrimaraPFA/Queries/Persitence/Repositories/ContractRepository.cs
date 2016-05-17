using System;

namespace Queries.Persitence.Repositories
{
    using Core.Domain;
    using Core.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class ContractRepository : Repository<Contract>, IContractRepository
    {
       // ReSharper disable once SuggestBaseTypeForParameter
       public ContractRepository(ContaContext context)
           :base(context)
       { }

       
        public IEnumerable<Contract> GetContractByYear(int year)
        {
            return (from c in ContaContext.Contract where c.Data.Year == year
                    select c).ToList() ;
        }
        public IEnumerable<Contract> GetContractByNumberAndYear(string number, DateTime year)
        {
            return (from c in ContaContext.Contract
                    where  c.NrContract == number && c.Data.Year == year.Year
                    select c).ToList();
        }

        public IEnumerable<dynamic> GetGridViewContractByYear(int year)
        {
            var holder = (from c in ContaContext.Contract
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where c.Data.Year == year
                          select new { c.ContractId, c.NrContract, c.Data, b.Nume, b.Prenume, c.Suma, c.ObiectulContractului, c.Observatii })
                .ToList();

            var returnVal = from h in holder
                            select new
                            {
                                h.ContractId,
                                h.NrContract,
                                Data = h.Data.ToShortDateString(),
                                Titular = string.Format("{0} {1}", h.Nume, h.Prenume),
                                h.Suma,
                                h.ObiectulContractului,
                                h.Observatii
                            };

            return returnVal;
        }

        public IEnumerable<dynamic> GetContractByNumber(string nrContract)
       {
            var holder = (from c in ContaContext.Contract
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where c.NrContract == nrContract
                          select new { c.ContractId, c.NrContract, c.Data, b.Nume, b.Prenume, c.Suma, c.ObiectulContractului, c.Observatii, c.Factura }).ToList();

            var returnVal = from h in holder
                            select new{h.ContractId,h.NrContract,Data = h.Data.ToShortDateString(),Titular = string.Format("{0} {1}", h.Nume, h.Prenume),h.Suma,
                                h.Factura,h.Observatii};
            return returnVal;
        }

       public IEnumerable<dynamic> GetContractByBeneficiar(string name)
       {
            var holder = (from c in ContaContext.Contract
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where b.Nume.StartsWith(name) orderby c.Data.Year
                          select new { c.ContractId, c.NrContract, c.Data, b.Nume, b.Prenume, c.Suma, c.ObiectulContractului, c.Observatii, c.Factura }).ToList();

            var returnVal = from h in holder
                            select new{h.ContractId, h.NrContract,Data = h.Data.ToShortDateString(),Titular = string.Format("{0} {1}", h.Nume, h.Prenume),
                                h.Suma,h.Factura,h.Observatii};
            return returnVal;
        }

        public IEnumerable<dynamic> GetContractByAmount(decimal val)
        {
            var holder = (from c in ContaContext.Contract
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where c.Suma == val orderby c.Data.Year
                          select new { c.ContractId, c.NrContract, c.Data, b.Nume, b.Prenume, c.Suma, c.ObiectulContractului, c.Observatii, c.Factura }).ToList();

            var returnVal = from h in holder
                            select new{h.ContractId,h.NrContract,Data = h.Data.ToShortDateString(),Titular = string.Format("{0} {1}", h.Nume, h.Prenume),
                                h.Suma,h.Factura,h.Observatii};
            return returnVal;
        }

        public IEnumerable<dynamic> GetContractByNumberAndYear(string number, int year)
        {
            var holder = (from c in ContaContext.Contract
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where c.NrContract == number && c.Data.Year == year
                          select new { c.ContractId, c.NrContract, c.Data, b.Nume, b.Prenume, c.Suma, c.ObiectulContractului, c.Observatii, c.Factura }).ToList();

            var returnVal = from h in holder
                            select new
                            {h.ContractId, h.NrContract,Data = h.Data.ToShortDateString(),Titular = string.Format("{0} {1}", h.Nume, h.Prenume),
                                h.Suma,h.Factura,h.Observatii};
            return returnVal;
        }

        public IEnumerable<dynamic> GetContracts()
        {
            var holder = (from c in ContaContext.Contract
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId                          
                          select new { c.ContractId, c.NrContract, c.Data, b.Nume, b.Prenume, c.Suma, c.ObiectulContractului, c.Observatii, c.Factura }).ToList();

            var returnVal = from h in holder
                            select new
                            {h.ContractId, h.NrContract,Data = h.Data.ToShortDateString(),Titular = string.Format("{0} {1}", h.Nume, h.Prenume),
                                h.Suma,h.Factura,h.Observatii};
            return returnVal;
        }


        public ContaContext ContaContext => Context as ContaContext;
    }
}
