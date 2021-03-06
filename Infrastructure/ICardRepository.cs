﻿using Entities;
using Infrastructure.CRUDInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface ICardRepository : IAddable<Card>, IRemovable<Card>, IUpdatable<Card>, IReadable<Card> 
    {

    }
}
