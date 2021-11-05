using System.Collections.Generic;

namespace EndOfTheYearParty.Models
{
    public static class Repository 
    {
        private static  readonly List<PartyGuestResponse> responses = new List<PartyGuestResponse>();
        public static IEnumerable<PartyGuestResponse> Responses => responses;
        public static void AddResponse(PartyGuestResponse response)
        {
            responses.Add(response);
        }
    }
}
