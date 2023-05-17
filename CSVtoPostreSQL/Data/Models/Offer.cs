

namespace CSVtoPostreSQL.Data.Models
{
    public class Offer
    {
        public int OfferId { get; set; }

        public decimal MonthlyFee { get; set; }

        public int NewContractsForMont { get; set; }

        public int SameContractsForMonth { get; set; }

        public  int CancelledContractsForMonth { get; set; }
    }
}
