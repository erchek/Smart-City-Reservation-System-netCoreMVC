﻿using TheEye.Core.DataAccess;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
