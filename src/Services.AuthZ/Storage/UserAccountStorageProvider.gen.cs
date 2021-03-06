﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Common.Storage;
using Services.AuthZ.Storage.DataEntities;
using Services.DataContracts;

namespace Services.AuthZ.Storage
{
    /// <summary>
    /// A storage provider for <see cref="IUserAccount"/>
    /// </summary>
    internal partial class UserAccountStorageProvider : BaseStorageProvider<IUserAccount, UserAccountEntity>
    {
        /// <summary>
        /// Converts the <see cref="UserAccountEntity"/> to a DTO of <see cref="IUserAccount"/>
        /// </summary>
        protected override IUserAccount ToDto(UserAccountEntity entity)
        {
            return entity.ToDto();
        }

        /// <summary>
        /// Converts the DTO <see cref="IUserAccount"/> to a entity of <see cref="UserAccountEntity"/>
        /// </summary>
        protected override UserAccountEntity FromDto(IUserAccount contract)
        {
            return UserAccountEntity.FromDto(contract);
        }

        /// <summary>
        /// Creates a new identity for the new entity
        /// </summary>
        protected override string CreateIdentity(UserAccountEntity entity)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
