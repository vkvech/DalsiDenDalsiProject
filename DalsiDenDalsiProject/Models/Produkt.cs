namespace DalsiDenDalsiProject.Models
{
    public class Produkt
    {
        public string Nazev { get; set; } = "";
        private decimal cenaBezDph ;
        private decimal dph ;
        public decimal CenaSdpH => CenaBezDph + (CenaBezDph * dph/100);
        private decimal mnozstvi ;
        public decimal CenaNaSklade => CenaSdpH * Mnozstvi;
        public string ChybaDph = "";
        public string ChybaCenaBezDph = "";
        public string ChybaMnozstvi = "";

        public decimal CenaBezDph
        {
            get
            {
                return cenaBezDph;
            }

            set
            {
                if (value > 0)
                {
                    cenaBezDph = value;
                    ChybaCenaBezDph = "";
                }
                    
                else
                {
                    cenaBezDph = 0;
                    ChybaCenaBezDph = "cena musí být větší než 0";
                }
                    
                    
                
            }
        }

        public decimal Dph
        {
            get => dph;
            set
            {
                if (value > 0 && value < 100)
                {
                    dph = value;
                    ChybaDph = "";
                }
                else
                {    
                    dph = 0;
                    ChybaDph = "rozmezí DPH je 0-100";
                }
            }
        }

        public decimal Mnozstvi
        {
            get => mnozstvi;
            set
            {
                if (value > 0)
                {
                    mnozstvi = value;
                    ChybaMnozstvi = "";
                }

                else
                {
                    mnozstvi = 0;
                    ChybaMnozstvi = "Množství musí být větší než 0";
                }
            }
        }
    }
}
