using Dependency_Injection.Models;

namespace Dependency_Injection.Services
{
    public class GiftService : IGiftService
    {
        private List<GiftModel> _gifts;
        
        public List<GiftModel> GetGifts()
        {

            return _gifts;
        }

        public int AddGift(GiftModel gift)
        {
            gift.Id = _gifts.Count + 1;
            _gifts.Add(gift);
            return gift.Id;
         
        }
    }
}
