using Dependency_Injection.Models;

namespace Dependency_Injection.Services
{
    public interface IGiftService
    {
       
        List<GiftModel> GetGifts();
        int AddGift(GiftModel gift);
     

    }
}
