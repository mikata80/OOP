namespace NightlifeEntertainment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CinemaEngine
    {
        private StringBuilder output;

        public CinemaEngine()
        {
            this.output = new StringBuilder();
            this.Venues = new List<IVenue>();
            this.Performances = new List<IPerformance>();
        }

        public StringBuilder Output
        {
            get
            {
                return this.output;
            }
        }

        protected IList<IVenue> Venues { get; private set; }

        protected IList<IPerformance> Performances { get; private set; }

        public void ParseCommand(string command)
        {
            string[] commandWords = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                this.DispatchCommand(commandWords);
            }
            catch (Exception e)
            {
                this.Output.AppendLine(e.Message);
            }
        }

        protected virtual void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "venue":
                    this.ExecuteInsertVenueCommand(commandWords);
                    break;
                case "performance":
                    this.ExecuteInsertPerformanceCommand(commandWords);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteSellTicketCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);
            var type = (TicketType)Enum.Parse(typeof(TicketType), commandWords[2], true);
            this.output.Append(performance.SellTicket(type));
        }

        protected virtual void ExecuteReportCommand(string[] commandWords)
        {
            /*
             * <name>: <tickets_sold> ticket(s), total: $<total_price>
               Venue: <venue_name> (<venue_location>)
               Start time: <start_time>
             */
            var performance = this.GetPerformance(commandWords[1]);
            string res = "";

            var ticketsSold = performance.Tickets.Where(t => t.Status == TicketStatus.Sold);
            decimal totalPrice= 0;
            foreach (var t in ticketsSold)
	        {
		        totalPrice += t.Price;
	        } 
            
            res = String.Format("{0}: {1} ticket(s), total: ${2}\nVenue: {3} ({4})\nStart time: {5}",
                performance.Name,
                ticketsSold.Count(),
                totalPrice,
                performance.Venue.Name,
                performance.Venue.Location,
                performance.StartTime);

            

        }

        protected virtual void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }

                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "cinema":
                    var cinema = new Cinema(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(cinema);
                    break;
                case "opera":
                    var opera = new OperaHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sport = new Sport(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sport);
                    break;
                case "concert_hall":
                    var concert = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concert);
                    break;
                default:
                    break;
            }
        }

        protected virtual void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[5]);
            switch (commandWords[2])
            {
                case "movie":
                    var movie = new Movie(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(movie);
                    break;
                case "theatre":
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var concert = new Concert(
                        commandWords[3], 
                        decimal.Parse(commandWords[4]), 
                        venue, 
                        DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:
                    break;
            }
        }

        protected IVenue GetVenue(string name)
        {
            var venue = this.Venues.FirstOrDefault(v => v.Name == name);
            if (venue == null)
            {
                throw new InvalidOperationException("There is no venue with the given name in the database.");
            }

            return venue;
        }

        protected IPerformance GetPerformance(string name)
        {
            var performance = this.Performances.FirstOrDefault(v => v.Name == name);
            if (performance == null)
            {
                throw new InvalidOperationException("There is no performance with the given name in the database.");
            }

            return performance;
        }

        protected virtual void ExecuteFindCommand(string[] commandWords)
        {
            throw new NotImplementedException();
        }

        private void DispatchCommand(string[] commandWords)
        {
            switch (commandWords[0])
            {
                case "insert":
                    this.ExecuteInsertCommand(commandWords);
                    break;
                case "supply_tickets":
                    this.ExecuteSupplyTicketsCommand(commandWords);
                    break;
                case "sell_ticket":
                    this.ExecuteSellTicketCommand(commandWords);
                    break;
                case "report":
                    this.ExecuteReportCommand(commandWords);
                    break;
                case "find":
                    this.ExecuteFindCommand(commandWords);
                    break;
                default:
                    break;
            }
        }
    }
}
