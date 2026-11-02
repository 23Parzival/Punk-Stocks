using System;
using System.Linq;

namespace Punk_Stocks.Services
{
    internal static class StockSeeder
    {
        private sealed class Row
        {
            public readonly string Symbol, Name, Sector, Description;
            public readonly decimal Price, Volatility, DividendYield;

            public Row(string symbol, string name, string sector, decimal price, decimal volatility, decimal dividendYield, string description)
            {
                this.Symbol = symbol;
                this.Name = name;
                this.Sector = sector;
                this.Price = price;
                this.Volatility = volatility;
                this.DividendYield = dividendYield;
                this.Description = description;
            }
        }

        //29 default companies
        //price: 142.50 = $142.50 depending on locale
        //volatitly and dividend yield: 0.03 = 3%
        private static readonly Row[] DefaultStocks =
        {
            //tech
            new Row("NEON", "Neon Circuitry Inc.", "Technology", 142.50m, 0.0300m, 0.0000m,
                "Designs and manufactures flexible LED displays, circuit boards and smart-lighting chips used in clubs, signage and consumer electronics."),
            new Row("GLCH", "GlitchWave Systems", "Technology", 88.20m, 0.0450m, 0.0000m,
                "Develops video-processing software and streaming tools, known for a fast-moving product line and a loyal underground creator community."),
            new Row("SYNT", "Synthetic Bytes Corp.", "Technology", 215.00m, 0.0280m, 0.0050m,
                "Sells cloud storage, data analytics and cybersecurity services to mid-size and large businesses on yearly subscriptions."),
            new Row("ZINE", "ZineSoft Interactive", "Technology", 36.75m, 0.0500m, 0.0000m,
                "Small indie studio that publishes experimental games and interactive stories, with a few hits driving most of its revenue."),
            new Row("ZETA", "Zetatech", "Technology",  109.90m, 0.0310m, 0.0060m,
                "Computer hardware and software maker supplying cyberdecks, networking gear and data-security systems to businesses and individuals."),
            //energy
            new Row("VOLT", "Voltage Riot Energy", "Energy", 64.30m, 0.0220m, 0.0350m,
                "Builds and operates wind farms and battery storage sites, selling electricity to regional power grids."),
            new Row("SOLR", "Solar Mohawk Ltd.", "Energy", 27.90m, 0.0350m, 0.0100m,
                "Manufactures solar panels and installs rooftop systems for homes and small businesses."),
            new Row("GRIM", "Grimy Gas & Oil", "Energy", 52.10m, 0.0200m, 0.0450m,
                "Drills for oil and natural gas and runs a network of refineries and fuel stations. A mature business with a steady payout."),
            new Row("PTRC", "Petrochem", "Energy", 83.50m, 0.0210m, 0.0400m,
                "Oil and chemical conglomerate producing fuel, plastics and industrial compounds that power much of the city."),
            //healthcare
            new Row("PILL", "Pillpusher Pharma", "Healthcare", 118.40m, 0.0250m, 0.0150m,
                "Develops and sells prescription medications, mainly for pain management, allergies and heart conditions."),
            new Row("HELX", "Helix Hardcore Biotech", "Healthcare", 73.60m, 0.0480m, 0.0000m,
                "Research-focused biotech working on gene therapies. High potential reward, but it has no sales yet and its results are uncertain."),
            new Row("MEND", "Mender Medical", "Healthcare", 95.00m, 0.0180m, 0.0200m,
                "Makes hospital equipment, surgical tools and mobility aids, with steady demand from hospitals and clinics."),
            new Row("BTCH", "Biotechnica", "Healthcare", 96.70m, 0.0300m, 0.0120m,
                "Agricultural biotech giant producing genetically engineered crops and synthetic food for a large share of the world's population."),
            new Row("TRMA", "Trauma Team International", "Healthcare", 137.20m, 0.0170m, 0.0180m,
                "Premium medical insurance company that dispatches armed ambulance teams to its subscribers in emergencies."),
            //finance
            new Row("LOAN", "Loan Shark Capital", "Finance", 156.80m, 0.0240m, 0.0300m,
                "Provides personal and small-business loans, credit lines and debt refinancing, earning most of its money from interest."),
            new Row("ANRK", "Anarchy National Bank", "Finance", 78.25m, 0.0200m, 0.0380m,
                "A traditional retail bank offering chequing, savings, mortgages and credit cards across the country."),
            new Row("DEBT", "Debt Collective Trust", "Finance", 41.15m, 0.0260m, 0.0280m,
                "Buys overdue debts from other lenders and collects on them, and also offers payment plans and credit counselling."),
            //consumer
            new Row("SKTR", "Skate or Buy Retail", "Consumer", 33.40m, 0.0320m, 0.0120m,
                "Retail chain selling skateboards, streetwear and accessories in stores and online."),
            new Row("DISC", "Distortion Pedals Co.", "Consumer", 61.90m, 0.0300m, 0.0080m,
                "Makes handmade guitar pedals and audio gear for musicians, sold directly and through music shops."),
            new Row("BRGR", "Bleeding Burger Chain", "Consumer", 47.55m, 0.0220m, 0.0250m,
                "Fast-food chain serving burgers, fries and shakes through company-owned and franchised locations."),
            new Row("DENM", "Denim & Safety Pins", "Consumer", 19.80m, 0.0400m, 0.0000m,
                "Clothing brand known for jackets, jeans and customizable patches and pins. Popular, but its sales depend heavily on fashion trends."),
            //industrial
            new Row("RIOT", "Riot Steelworks", "Industrial", 102.30m, 0.0210m, 0.0220m,
                "Produces steel beams, pipes and sheet metal for construction and heavy industry."),
            new Row("SCRP", "Scrapyard Logistics", "Industrial",  58.70m, 0.0190m, 0.0270m,
                "Collects, sorts and recycles scrap metal, and runs the freight trucks that move it to steel mills."),
            new Row("ARSK", "Arasaka Corporation", "Industrial", 310.00m, 0.0250m, 0.0200m,
                "Japanese megacorporation spanning corporate security, banking and cybernetic implants, with a private military force protecting its global operations."),
            new Row("MLTC", "Militech", "Industrial", 188.40m, 0.0280m, 0.0300m,
                "American arms maker and military contractor selling weapons, vehicles and combat systems to governments and private armies."),
            new Row("KGTO", "Kang Tao", "Industrial", 124.10m, 0.0340m, 0.0100m,
                "Chinese weapons manufacturer known for smart guns and targeting systems that link directly to a user's cyberware."),
            new Row("ORBT", "Orbital Air", "Industrial", 67.40m, 0.0260m, 0.0150m,
                "Airline and spaceflight operator running passenger shuttles, cargo flights and orbital transport."),
            //utilities
            new Row("AMPS", "Amped Utilities", "Utilities", 71.00m, 0.0100m, 0.0420m,
                "Regulated electricity and natural gas utility serving homes and businesses, with stable and predictable earnings."),
            new Row("AQUA", "Gutter Water Co.", "Utilities", 44.25m, 0.0090m, 0.0400m,
                "Treats and delivers drinking water and manages wastewater for several cities.")
        };

        public static void SeedIfEmpty()
        {
            using (var db = new PunkStocksDBEntities())
            {
                if (db.Stocks.Any())
                    return;

                DateTime now = DateTime.Now;
                foreach (Row r in DefaultStocks)
                {
                    var stock = new Stock
                    {
                        Symbol = r.Symbol,
                        CompanyName = r.Name,
                        Sector = r.Sector,
                        Description = r.Description,
                        CurrentPrice = r.Price,
                        Volatility = r.Volatility,
                        DividendYield = r.DividendYield
                    };

                    //first point of the price history
                    stock.PriceHistories.Add(new PriceHistory { Price = r.Price, RecordedAt = now });
                    db.Stocks.Add(stock);
                }
                db.SaveChanges();
            }
        }
    }
}