using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IGiftCard
    {
        Task<IEnumerable<GiftCard>> GetGiftCards();
        Task<GiftCard> GetGiftCardId(int GiftCardid);
        Task<GiftCard> AddGiftCard(GiftCard Giftcard);
        Task<GiftCard> UpdateGiftCard(GiftCard Giftcard);
        Task DeleteGiftCard(int GiftCardid);
    }
}
