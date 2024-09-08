using Gymlog.Core.Contracts;
using Gymlog.Infrastructure.Data.Common;
using Gymlog.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Gymlog.Core.Models.CardViews;
using System.Security.Claims;
using Gymlog.Infrastructure.Data.SeedDb;

namespace Gymlog.Core.Service
{
    public class CardService : ICardService
    {

        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;

        public CardService(IRepository _repository, UserManager<ApplicationUser> _userManager)
        {
            repository = _repository;
            userManager = _userManager;

        }

        public async Task<MyCardView> CheckCardAsync(int cardNumber, string cardId, string userId, bool check)
        {
            string valid = string.Empty;
            var user = await userManager.FindByIdAsync(userId);
            bool isAdmin = await userManager.IsInRoleAsync(user, "Administrator");

            var card = cardNumber != 0
                ? await repository.All<Card>().FirstOrDefaultAsync(c => c.Id == cardNumber)
                : await repository.All<Card>().FirstOrDefaultAsync(c => c.CardId == cardId);

            if (card == null)
            {
                return null;
            }

            if (card.DailyCounting.Date == DateTime.Today && check)
            {
                card.Daily++;
            }
            else if(card.DailyCounting.Date != DateTime.Today)
            {
                card.Daily = 1;
                card.DailyCounting = DateTime.Today;
            }

            if (card.МonthCounting.Month == DateTime.Today.Month && card.МonthCounting.Year == DateTime.Today.Year && check)
            {
                card.Мonth++;
            }
            else if(card.МonthCounting.Month != DateTime.Today.Month)
            {
                card.Мonth = 1;
                card.МonthCounting = DateTime.Today;
            }

            var currentDate = DateTime.Now;
            

            if (card.Start <= currentDate && card.End >= currentDate)
            {
                valid = "Да";
            }
            else
            {
                valid = "Не";
            }


            await repository.SaveChangesAsync();

            var model = new MyCardView
            {
                Id = card.Id,
                FirstName = card.FirstName,
                LastName = card.LastName,
                Start = card.Start,
                End = card.End,
                CardId = card.CardId,
                Daily = card.Daily,
                Мonth = card.Мonth,
                Valid = valid,
            };

            // Return the model if user is admin or matches the card details
            if (isAdmin || (card.FirstName == user.FirstName && card.LastName == user.LastName))
            {
                return model;
            }

            return null;
        }


        public async Task<int> CreateAsync(string firstName, string lastName, DateTime startData, DateTime endData, string cardId)
        {
            var card = new Card()
            {
                FirstName = firstName,
                LastName = firstName,
                Start = startData,
                End = endData,
                CardId = cardId,
                МonthCounting = startData,
                DailyCounting = startData,
            };

            await repository.AddAsync(card);
            await repository.SaveChangesAsync();

            return card.Id;
        }

        //public async Task<MyCardView> MyCard(string userId)
        //{
        //    var model = new MyCardView();
        //    var user = await userManager.FindByIdAsync(userId);
        //    var card = await repository.AllReadOnly<Card>().FirstOrDefaultAsync(c => c.User.Id == userId);
        //    if (card == null)
        //    {
        //        model = new MyCardView
        //        {
        //            Id = -1,
        //            FirstName = "",
        //            LastName = "",
        //            End = DateTime.MinValue,
        //        };

        //        return model;
        //    };

        //    model = new MyCardView
        //    {
        //        Id = card.Id,
        //        FirstName = card.FirstName,
        //        LastName = card.LastName,
        //        End = card.End,
        //    };

        //    return model;
        //}

        public async Task<EditCard> GetViewForEdit(int cardId)
        {
            var card = await repository.AllReadOnly<Card>().FirstOrDefaultAsync(c => c.Id == cardId);

            if (card == null)
            {
                return null;
            }

            var model = new EditCard
            {
                Id = card.Id,
                FirstName = card.FirstName,
                LastName = card.LastName,
                End = card.End,
                CardId= card.CardId,
            };

            return model;
        }

        public async Task EditAsync(EditCard model)
        {
            var card = await repository.All<Card>().FirstOrDefaultAsync(c => c.Id == model.Id);
            if (card == null)
            {
                return;
            }

            if (card != null)
            {
                card.FirstName = model.FirstName;
                card.LastName = model.LastName;
                card.End = model.End;
                card.CardId = model.CardId;

                await repository.SaveChangesAsync();
            }
        }

        public async Task DeleteCardAsync(int cardId)
        {
            await repository.DeleteAsync<Card>(cardId);
            await repository.SaveChangesAsync();
        }

        public async Task<List<MyCardView>> ViewAllCardsAsync(string? searchQuery, string cardStatus)
        {
            var cardsQuery = repository.All<Card>().AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                cardsQuery = cardsQuery.Where(card => (card.FirstName + " " + card.LastName)
                                                      .Contains(searchQuery));
            }

            var currentDate = DateTime.Now;
            switch (cardStatus)
            {
                case "valid":
                    cardsQuery = cardsQuery.Where(card => card.Start <= currentDate && card.End >= currentDate); 
                    break;
                case "invalid":
                    cardsQuery = cardsQuery.Where(card => card.Start > currentDate || card.End < currentDate); 
                    break;
                case "all":
                default:
                    break;
            }

            var cardsModels = await cardsQuery.ToListAsync();
            var cards = new List<MyCardView>();

            foreach (var card in cardsModels)
            {
                var model = new MyCardView
                {
                    Id = card.Id,
                    FirstName = card.FirstName,
                    LastName = card.LastName,
                    End = card.End,
                    Start = card.Start,
                    CardId = card.CardId,
                    Daily = card.Daily,
                    Мonth = card.Мonth,
                };

                cards.Add(model);
            }

            return cards;
        }

    }
}
