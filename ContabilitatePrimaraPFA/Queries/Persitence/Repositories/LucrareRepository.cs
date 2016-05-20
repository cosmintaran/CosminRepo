namespace Queries.Persitence.Repositories
{
    using Core.Domain;
    using Core.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LucrareRepository : Repository<Lucrare>, ILucrareRepository
    {

        public LucrareRepository(ContaContext context)
            :base(context)
        {

        }


        public IEnumerable<Lucrare> GetLucrariByNumberAndYear(string number, DateTime year)
        {
            return (from l in ContaContext.Lucrare
                where
                    l.NrProiect == number && l.AnProiect == year.Year.ToString()
                orderby l.AnProiect
                select l).ToList();
        }

        public IEnumerable<dynamic> GetLucrariByBeneficiarName(string name)
        {
            var holder = (from l in ContaContext.Lucrare
                         join c in ContaContext.Contract on l.ContractId equals c.ContractId
                         join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                         join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                         join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                         join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                         where b.Nume.StartsWith(name) orderby l.AnProiect
                         select new {l.LucrareId, a.StatusAccept,l.Nr_OCPI,l.DataInregistrare, l.TermenSolutionare, l.AvizatorRegistrator,t.Tip_Lucrare,                         
                                     l.NrProiect,l.AnProiect, b.Nume, l.CadTop, l.UAT,c.NrContract,c.Data.Year, r.StatusRec, l.Observatii}).ToList();

            var returnValue = from h in holder
                select new
                    {
                        h.LucrareId, h.StatusAccept, AceptataRefuzata = String.Format(h.StatusAccept), NrInregOCPI = String.Format("{0}{1}{2}",h.Nr_OCPI,@"-",h.DataInregistrare.Value.ToShortDateString()),
                       TermenSol = h.TermenSolutionare.Value.ToShortDateString(),h.AvizatorRegistrator, TipLucrare = h.Tip_Lucrare, NrProiect = String.Format("{0}{1}{2}",h.NrProiect,@"/",h.AnProiect), Beneficiari = h.Nume,
                        h.CadTop,h.UAT,Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year),ReceptionataRespinsa = String.Format(h.StatusRec),h.Observatii
                    };
                           
                return returnValue;
        }

        public IEnumerable<dynamic> GetLucrareByContract(string nrContract)
        {
            var holder = (from l in ContaContext.Lucrare
                          join c in ContaContext.Contract on l.ContractId equals c.ContractId
                          join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                          join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                          join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where c.NrContract == nrContract
                          select new
                          {
                              l.LucrareId, a.StatusAccept, l.Nr_OCPI, l.DataInregistrare, l.TermenSolutionare, l.AvizatorRegistrator, t.Tip_Lucrare,
                              l.NrProiect, l.AnProiect, b.Nume, l.CadTop, l.UAT, c.NrContract, c.Data.Year, l.Observatii, r.StatusRec }).ToList();

            var retVal = from h in holder
                         select new
                         {h.LucrareId,AceptataRefuzata = String.Format(h.StatusAccept),NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                             TermenSol = h.TermenSolutionare.Value.ToShortDateString(),h.AvizatorRegistrator,TipLucrare = h.Tip_Lucrare,NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect),Beneficiari = h.Nume, 
                             h.CadTop,h.UAT,Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year),ReceptionataRespinsa = String.Format(h.StatusRec),h.Observatii
                         };

            return retVal;
        }

        public IEnumerable<dynamic> GetLucrariByCodLucrare(string codLucrare)
        {
            var holder = (from l in ContaContext.Lucrare
                          join c in ContaContext.Contract on l.ContractId equals c.ContractId
                          join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                          join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                          join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          where t.CodLucrare == codLucrare
                          select new
                          {l.LucrareId, a.StatusAccept, l.Nr_OCPI, l.DataInregistrare, l.TermenSolutionare, l.AvizatorRegistrator, TipLucrare = t.Tip_Lucrare,
                              l.NrProiect, l.AnProiect, b.Nume,  l.CadTop, l.UAT, c.NrContract, c.Data.Year, l.Observatii, r.StatusRec }).ToList();

            var retVal = from h in holder
                         select new
                         {h.LucrareId, AceptataRefuzata = String.Format(h.StatusAccept), NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                             TermenSol = h.TermenSolutionare.Value.ToShortDateString(), h.AvizatorRegistrator, h.TipLucrare, NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect), Beneficiari = h.Nume,
                             h.CadTop, h.UAT, Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year), ReceptionataRespinsa = String.Format(h.StatusRec), h.Observatii
                         };

            return retVal;
        }

        public IEnumerable<dynamic> GetLucrariByYear(string year)
        {
           
               var  holder = (from l in ContaContext.Lucrare
                    join c in ContaContext.Contract on l.ContractId equals c.ContractId
                    join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                    join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                    join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                    join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                    where l.AnProiect == year
                    select new{l.LucrareId,a.StatusAccept, l.Nr_OCPI, l.DataInregistrare, l.TermenSolutionare,l.AvizatorRegistrator,
                        TipLucrare = t.Tip_Lucrare,l.NrProiect, l.AnProiect,b.Nume, l.CadTop,l.UAT,c.NrContract, c.Data.Year, l.Observatii, r.StatusRec}).ToList();

                var retVal = from h in holder
                             select new{h.LucrareId, AceptataRefuzata = String.Format(h.StatusAccept),NrInregOCPI = String.Format("{0}{1}{2}",h.Nr_OCPI, @"-",h.DataInregistrare.Value.ToShortDateString()),
                                        TermenSol = h.TermenSolutionare.Value.ToShortDateString(),h.AvizatorRegistrator, h.TipLucrare, NrProiect = String.Format("{0}{1}{2}",
                                        h.NrProiect, @"/", h.AnProiect),Beneficiari =  h.Nume, h.CadTop, h.UAT, Contracte= String.Format("{0}{1}{2}", h.NrContract,@"/", h.Year),
                                        ReceptionataRespinsa = String.Format(h.StatusRec), h.Observatii}; 
                     
                return retVal;
        }

        public IEnumerable<dynamic> GetLucrariByUat(string uat)
        {
                var holder = (from l in ContaContext.Lucrare
                              join c in ContaContext.Contract on l.ContractId equals c.ContractId
                              join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                              join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                              join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                              join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                              where l.UAT == uat
                              select new
                              {l.LucrareId,a.StatusAccept, l.Nr_OCPI, l.DataInregistrare, l.TermenSolutionare, l.AvizatorRegistrator, TipLucrare = t.Tip_Lucrare,
                                  l.NrProiect, l.AnProiect, b.Nume, l.CadTop, l.UAT, c.NrContract, c.Data.Year, l.Observatii, r.StatusRec }).ToList();

                var retVal = from h in holder
                             select new
                             { h.LucrareId, AceptataRefuzata = String.Format(h.StatusAccept), NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                                 TermenSol = h.TermenSolutionare.Value.ToShortDateString(), h.AvizatorRegistrator, h.TipLucrare, NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect), Beneficiari = h.Nume,
                                 h.CadTop, h.UAT, Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year), ReceptionataRespinsa = String.Format(h.StatusRec), h.Observatii
                             };

                return retVal;
            }

        public IEnumerable<dynamic> GetLucrariByCnp(string cnp)
        {
            var holder = (from l in ContaContext.Lucrare
                          join c in ContaContext.Contract on l.ContractId equals c.ContractId
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                          join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                          join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                          where b.CNP == cnp
                          select new
                          { l.LucrareId,a.StatusAccept,l.Nr_OCPI,l.DataInregistrare,l.TermenSolutionare,l.AvizatorRegistrator,t.Tip_Lucrare,l.NrProiect,
                              l.AnProiect,b.Nume,l.CadTop,l.UAT,c.NrContract,c.Data.Year,r.StatusRec,l.Observatii
                          }).ToList();

            var returnValue = from h in holder
                              select new
                              {
                                  h.LucrareId,h.StatusAccept,AceptataRefuzata = String.Format(h.StatusAccept),NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                                  TermenSol = h.TermenSolutionare.Value.ToShortDateString(),h.AvizatorRegistrator,TipLucrare = h.Tip_Lucrare,NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect),Beneficiari =  h.Nume,
                                  h.CadTop,h.UAT,Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year),ReceptionataRespinsa = String.Format(h.StatusRec),h.Observatii
                              };

            return returnValue;
        }

        public IEnumerable<dynamic> GetLucrariByStatusOcpi(string status)
        {
            var holder = (from l in ContaContext.Lucrare
                          join c in ContaContext.Contract on l.ContractId equals c.ContractId
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                          join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                          join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                          where r.StatusRec == status
                          select new
                          {
                              l.LucrareId,a.StatusAccept,l.Nr_OCPI,l.DataInregistrare,l.TermenSolutionare,l.AvizatorRegistrator,t.Tip_Lucrare,l.NrProiect,l.AnProiect,
                              b.Nume,l.CadTop,l.UAT,c.NrContract,c.Data.Year,r.StatusRec,l.Observatii}).ToList();

            var returnValue = from h in holder
                              select new
                              {
                                  h.LucrareId,h.StatusAccept,AceptataRefuzata = String.Format(h.StatusAccept),NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                                  TermenSol = h.TermenSolutionare.Value.ToShortDateString(), h.AvizatorRegistrator,TipLucrare = h.Tip_Lucrare,NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect),Beneficiari = h.Nume,
                                  h.CadTop,h.UAT,Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year),ReceptionataRespinsa = String.Format(h.StatusRec),h.Observatii
                              };
            return returnValue;
        }

        public IEnumerable<dynamic> GetLucrariByNrDocumentatie(string nrDoc)
        {
            var holder = (from l in ContaContext.Lucrare
                          join c in ContaContext.Contract on l.ContractId equals c.ContractId
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                          join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                          join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                          where l.NrProiect == nrDoc
                          select new
                          {
                              l.LucrareId,a.StatusAccept,l.Nr_OCPI,l.DataInregistrare,l.TermenSolutionare,l.AvizatorRegistrator,t.Tip_Lucrare,l.NrProiect,l.AnProiect,b.Nume,
                             l.CadTop,l.UAT,c.NrContract,c.Data.Year,r.StatusRec,l.Observatii}).ToList();

            var returnValue = from h in holder
                              select new
                              {
                                  h.LucrareId,h.StatusAccept,AceptataRefuzata = String.Format(h.StatusAccept),NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                                  TermenSol = h.TermenSolutionare.Value.ToShortDateString(),h.AvizatorRegistrator,Tiplucrare = h.Tip_Lucrare,NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect),Beneficiari =  h.Nume,
                                  h.CadTop,h.UAT,Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year),ReceptionataRespinsa = String.Format(h.StatusRec),h.Observatii
                              };
            return returnValue;
        }

        public IEnumerable<dynamic> GetLucrari()
        {
            var holder = (from l in ContaContext.Lucrare
                          join c in ContaContext.Contract on l.ContractId equals c.ContractId
                          join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                          join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                          join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                          join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                          select new
                          {l.LucrareId,a.StatusAccept,l.Nr_OCPI,l.DataInregistrare,l.TermenSolutionare,l.AvizatorRegistrator,
                              t.Tip_Lucrare,l.NrProiect,l.AnProiect,b.Nume,l.CadTop,l.UAT,c.NrContract,c.Data.Year,
                              r.StatusRec,l.Observatii}).ToList();

            var returnValue = from h in holder
                              select new
                              { h.LucrareId,h.StatusAccept,AceptataRefuzata = String.Format(h.StatusAccept),
                                  NrInregOCPI = String.Format("{0}{1}{2}", h.Nr_OCPI, @"-", h.DataInregistrare.Value.ToShortDateString()),
                                  TermenSol = h.TermenSolutionare.Value.ToShortDateString(),h.AvizatorRegistrator,
                                  Tiplucrare = h.Tip_Lucrare,NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect),
                                  Beneficiari =  h.Nume, h.CadTop,h.UAT,Contracte = String.Format("{0}{1}{2}", h.NrContract, @"/", h.Year),
                                  ReceptionataRespinsa = String.Format(h.StatusRec),h.Observatii
                              };
            return returnValue;
        }

        public ContaContext ContaContext => Context as ContaContext;
    }
}
