using Gymlog.Core.Models.CardViews;
using Gymlog.Infrastructure.Data.Models;

namespace Gymlog.Core.Contracts
{
    public interface ICardService
    {
        Task<int> CreateAsync(string firstName,string lastName, DateTime startData, DateTime endDatam, string cardId);
        //Task<MyCardView> MyCard(string userId);
        Task<EditCard> GetViewForEdit(int cardId);

        Task EditAsync(EditCard model);

        Task DeleteCardAsync(int cardId);
        Task<List<MyCardView>> ViewAllCardsAsync(string? searchQuery, string cardStatus); 

        Task<MyCardView> CheckCardAsync(int cardNumber, string cardId, string userId, bool check);
    }
}
