﻿using System;
using System.Collections.Generic;
using System.Text;
using MediHawker.Data;
using MediHawker.Data.Custom_Models;

namespace MediHawker.Services.ConsumerSpace.Interface
{
    public interface IConsumerService
    {
        bool Save(ConsumerRegisterModel conModel);
        bool Update(ConsumerRegisterModel conModel);
        bool CheckEmail(string email);
        
        bool CheckUsername(string username);
    }
}
