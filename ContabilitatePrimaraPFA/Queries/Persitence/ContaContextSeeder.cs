using System.Data.Entity;
using Queries.Core.Domain;
using System.Collections.Generic;

namespace Queries.Persitence
{
    public class ContaContextSeeder : DropCreateDatabaseIfModelChanges<ContaContext>
    {
        protected override void Seed(ContaContext context)
        {
            List<ReceptionatRespins> rec = new List<ReceptionatRespins>()
            {
                new ReceptionatRespins {StatusRec = "In Lucru"},
                new ReceptionatRespins {StatusRec = "Receptionat" },
                new ReceptionatRespins {StatusRec = "Respins" }

            };

            List<AcceptataRefuzata> accept = new List<AcceptataRefuzata>()
            {
                new AcceptataRefuzata {StatusAccept = "Acceptata"},
                new AcceptataRefuzata {StatusAccept = "Refuzata"}
            };

            List<TipLucrare> tipLucrare = new List<TipLucrare>()
            {
                new TipLucrare {CodLucrare = "0.0.0", Tip_Lucrare = "None"},
                new TipLucrare {CodLucrare = "1.1.1", Tip_Lucrare = "Aviz incepere lucrari" },
                new TipLucrare {CodLucrare = "1.1.2", Tip_Lucrare = "Receptie tehnica pentru lucrari de masuratori terestre" },
                new TipLucrare {CodLucrare = "2.1.1", Tip_Lucrare = "Receptie si infiintare carte funciara" },
                new TipLucrare {CodLucrare = "2.1.2", Tip_Lucrare = "Receptie (nr. cadastral)" },
                new TipLucrare {CodLucrare = "2.1.3", Tip_Lucrare = "Infiintare carte funciara" },
                new TipLucrare {CodLucrare = "2.2.1", Tip_Lucrare = "Receptie dezmembrare / comasare" },
                new TipLucrare {CodLucrare = "2.2.2", Tip_Lucrare = "Inscriere dezmembrare / comasare in cartea funciara" },
                new TipLucrare {CodLucrare = "2.2.3", Tip_Lucrare = "Dezmembrare pentru exproprieri" },
                new TipLucrare {CodLucrare = "2.5.1", Tip_Lucrare = "Indreptare eroare materiala si repozitionare imobil" },
                new TipLucrare {CodLucrare = "2.5.2", Tip_Lucrare = "Rectificare limite imobil si modificare suprafata" },
                new TipLucrare {CodLucrare = "2.5.3", Tip_Lucrare = "Reconstituire carte funciara" },
                new TipLucrare {CodLucrare = "2.6.1", Tip_Lucrare = "Inscriere constructii" },
                new TipLucrare {CodLucrare = "2.6.2", Tip_Lucrare = "Extindere sau desfiintare constructii si actualizare categorie de folosinta, destinatie sau alte informatii tehnice" }
            };

            List<TipAct> tipAct = new List<TipAct>()
            {
                new TipAct {TipAct1 = "B.I."},
                new TipAct {TipAct1 = "C.I."},
                new TipAct {TipAct1 = "Pasaport"}
            };
            foreach (var it in rec)
                context.ReceptionatRespins.Add(it);
            foreach (var it in accept)
                context.AcceptataRefuzata.Add(it);

            foreach (var it in tipLucrare)
                context.TipLucrare.Add(it);

            foreach (var it in tipAct)
                context.TipAct.Add(it);

            base.Seed(context);
        }

    }
}
