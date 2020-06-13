using Entities;
using Infrastructure.CRUDInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface ICardRepository : IAddable<Card>, IDelitable<Card>, IReadable<Card>, IUpdatable<Card>
    {

    }
}
