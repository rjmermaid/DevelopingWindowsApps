using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManagementSystem
{
    public class Team
    {
        public string TeamId { get; set; }
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public string DirectorName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CreatedBy { get; set; }
    }
}
