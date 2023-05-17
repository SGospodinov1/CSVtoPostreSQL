
using CSVtoPostreSQL.Data;
using CSVtoPostreSQL.Data.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

using (var context = new AppDbContext())
{

    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    List<Offer> offers = new List<Offer>();


    string filePath = "../../../offers.csv";

    bool isFirst = true;


    using (var reader = new StreamReader(filePath))
    {
        while (!reader.EndOfStream)
        {

            var line = reader.ReadLine();

            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var values = line.Split(";");

            Offer offer = new Offer();

            offer.MonthlyFee = decimal.Parse(values[1]);
            offer.NewContractsForMont = int.Parse(values[2]);
            offer.SameContractsForMonth = int.Parse(values[3]);
            offer.CancelledContractsForMonth = int.Parse(values[4]);

            offers.Add(offer);
        }
    }

    context.AddRange(offers);
    context.SaveChanges();
}

Console.WriteLine("Database was created.");
Console.WriteLine("File was import successfully.");