using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace View.View.Classes
{
    [Flags]
    public enum Currency 
    {
        None = 0,
        AED = 1 << 0,
        AUD = 1 << 1,
        BGN = 1 << 2,
        BRL = 1 << 3,
        CAD = 1 << 4,
        CHF = 1 << 5,
        CNY = 1 << 6,
        CZK = 1 << 7,
        DKK = 1 << 8,
        EGP = 1 << 9,
        EUR = 1 << 10,
        GBP = 1 << 11,
        HRK = 1 << 12,
        HUF = 1 << 13,
        INR = 1 << 14,
        JPY = 1 << 15,
        KRW = 1 << 16,
        MDL = 1 << 17,
        MXN = 1 << 18,
        NOK = 1 << 19,
        NZD = 1 << 20,
        PLN = 1 << 21,
        RSD = 1 << 22,
        RUB = 1 << 23,
        SEK = 1 << 24,
        TRY = 1 << 25,
        UAH = 1 << 26,
        USD = 1 << 27,
        XAU = 1 << 28,
        XDR = 1 << 29,
        ZAR = 1 << 30
    }
    public class CursBNR
    {
        private readonly string _downloadPath;
        private readonly string _fileName;
        private readonly DateTime _updateHour;
        //private readonly string tempPath; 
        public CursBNR(string downloadPath)
        {
            _downloadPath = downloadPath;
            _fileName = Environment.GetEnvironmentVariable("TEMP") + @"CursBnr.xml";
            _updateHour = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 30, 00);
        }
        public CursBNR(string downloadPath, string fileName)
        {
            _downloadPath = downloadPath;
            _fileName = fileName;
            _updateHour = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 30, 00);
        }

        public Dictionary<string, string> GetCurrentExchangeRate(Currency currency)
        {
            var curs = new Dictionary<string, string>();
            if (NeedToBeDownload())
                DownloadXML();
            List<string> lista = GetCurrency(currency);

            XmlReader xmlReader = XmlReader.Create(_fileName);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType != XmlNodeType.Element) || (xmlReader.Name != "Rate")) continue;
                foreach (var item in lista)
                {
                    if ((xmlReader.HasAttributes) && xmlReader.GetAttribute("currency") == item)
                    {
                        if (item != null) curs.Add(item, xmlReader.ReadElementContentAsString());
                    }
                }
            }

            return curs;
        }


        private void DownloadXML()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_downloadPath);
            xmlDoc.Save(_fileName);
        }

        private bool NeedToBeDownload()
        {
            bool status = true;
            try
            {
                if (!File.Exists(_fileName)) return true;
                DateTime creationTime = File.GetLastWriteTime(_fileName);
                if (creationTime > _updateHour || DateTime.Now < _updateHour)
                    status = false;

            }
            catch (Exception) { return true; }
            return status;
        }

        private List<string> GetCurrency(Currency curency)
        {
            var list = new List<string>();
            if ((curency & Currency.AED) == Currency.AED)
                list.Add("AED");
            if ((curency & Currency.AUD) == Currency.AUD)
                list.Add("AUD");
            if ((curency & Currency.BGN) == Currency.BGN)
                list.Add("BGN");
            if ((curency & Currency.BRL) == Currency.BRL)
                list.Add("BRL");
            if ((curency & Currency.CAD) == Currency.CAD)
                list.Add("CAD");
            if ((curency & Currency.CHF) == Currency.CHF)
                list.Add("CHF");
            if ((curency & Currency.CNY) == Currency.CNY)
                list.Add("CNY");
            if ((curency & Currency.CZK) == Currency.CZK)
                list.Add("CZK");
            if ((curency & Currency.DKK) == Currency.DKK)
                list.Add("DKK");
            if ((curency & Currency.EGP) == Currency.EGP)
                list.Add("EGP");
            if ((curency & Currency.EUR) == Currency.EUR)
                list.Add("EUR");
            if ((curency & Currency.GBP) == Currency.GBP)
                list.Add("GBP");
            if ((curency & Currency.HRK) == Currency.HRK)
                list.Add("HRK");
            if ((curency & Currency.HUF) == Currency.HUF)
                list.Add("HUF");
            if ((curency & Currency.INR) == Currency.INR)
                list.Add("INR");
            if ((curency & Currency.JPY) == Currency.JPY)
                list.Add("JPY");
            if ((curency & Currency.KRW) == Currency.KRW)
                list.Add("KRW");
            if ((curency & Currency.MDL) == Currency.MDL)
                list.Add("MDL");
            if ((curency & Currency.MXN) == Currency.MXN)
                list.Add("MXN");
            if ((curency & Currency.NOK) == Currency.NOK)
                list.Add("NOK");
            if ((curency & Currency.NZD) == Currency.NZD)
                list.Add("NZD");
            if ((curency & Currency.PLN) == Currency.PLN)
                list.Add("PLN");
            if ((curency & Currency.RSD) == Currency.RSD)
                list.Add("RSD");
            if ((curency & Currency.RUB) == Currency.RUB)
                list.Add("RUB");
            if ((curency & Currency.SEK) == Currency.SEK)
                list.Add("SEK");
            if ((curency & Currency.TRY) == Currency.TRY)
                list.Add("TRY");
            if ((curency & Currency.UAH) == Currency.UAH)
                list.Add("UAH");
            if ((curency & Currency.USD) == Currency.USD)
                list.Add("USD");
            if ((curency & Currency.XAU) == Currency.XAU)
                list.Add("XAU");
            if ((curency & Currency.XDR) == Currency.XDR)
                list.Add("XDR");
            if ((curency & Currency.ZAR) == Currency.ZAR)
                list.Add("ZAR");

            return list;
        }
    }
}
