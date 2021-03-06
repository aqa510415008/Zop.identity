﻿using AutoMapper;
using Orleans.Providers;
using System;
using System.Threading.Tasks;
using Zop.Domain.Entities;
using Zop.DTO;
using Zop.Identity;
using Zop.Identity.DTO;
using Zop.Repositories;

namespace Zop.Application.Services
{
    [StorageProvider(ProviderName = RepositoryStorage.DefaultName)]
    public class IdentityTokenService : ApplicationService<IdentityToken>, IIdentityTokenService
    {
        public Task<IdentityTokenDto> GetAsync()
        {
            if (base.State == null)
                return Task.FromResult<IdentityTokenDto>(null);
            if (base.State.ValidityTime < DateTime.Now)
                return Task.FromResult<IdentityTokenDto>(null);
            return Task.FromResult(
                Mapper.Map<IdentityTokenDto>(base.State));
        }

        public async Task<IdentityTokenAddResponseDto> StoreAsync(IdentityTokenAddRequestDto dto)
        {
            var result = dto.ValidResult();
            if (!result.Success)
                return Result.ReFailure<IdentityTokenAddResponseDto>(result);

            //生成Token Key
            //string key = base.ServiceProvider.GetRequiredService<IIDGenerated>().NextId().ToString();
            string key = Guid.NewGuid().ToString("N");
            IdentityToken token = new IdentityToken(key, dto.SubjectId)
            {
                ClientId = dto.ClientId,
                Data = dto.Claims.ToJsonString(),
                IdentityIP4 = dto.IdentityIP4,
                Type = dto.Type,
                ValidityTime = dto.ValidityTime,
                ReturnUrl = dto.ReturnUrl
            };
            base.State = token;
            await base.WriteStateAsync();
            base.DeactivateOnIdle();
            return new IdentityTokenAddResponseDto(token.Id);
        }
    }
}
