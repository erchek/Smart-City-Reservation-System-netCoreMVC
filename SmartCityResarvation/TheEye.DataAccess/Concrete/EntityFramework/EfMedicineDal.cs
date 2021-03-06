﻿using TheEye.Core.DataAccess.EntityFramework;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Concrete.EntityFramework
{
    public class EfMedicineDal : EfEntityRepositoryBase<Medicine, TheEyeContext>,IMedicineDal
    {
    }
}
