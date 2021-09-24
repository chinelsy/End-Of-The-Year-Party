using System.Collections.Generic;

namespace EndOfTheYearParty.Models
{
    public class Repository
    {
        private static List<PartyGuestResponse> responses = new List<PartyGuestResponse>();
        public static IEnumerable<PartyGuestResponse> Responses => responses;
        public static void AddResponse(PartyGuestResponse response)
        {
            responses.Add(response);
        }
    }
}
