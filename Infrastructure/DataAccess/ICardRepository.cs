using Cards.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DataAccess
{
    public interface ICardRepository : IAddable<Card>, IDelitable<Card>, IReadable<Card>, IUpdatable<Card>
    {

    }
}
