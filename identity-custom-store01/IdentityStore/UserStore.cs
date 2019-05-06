using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using IdentityStore.Models;

namespace IdentityStore
{
    public class UserStore
        : UserStoreBase<IdUser, string, IdentityUserClaim<string>, IdentityUserLogin<string>, IdentityUserToken<string>>
    {
        public UserStore(IdentityErrorDescriber describer) : base(describer)
        {
        }

        public override IQueryable<IdUser> Users => throw new NotImplementedException();

        public override Task AddClaimsAsync(IdUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task AddLoginAsync(IdUser user, UserLoginInfo login, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task<IdentityResult> CreateAsync(IdUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            user.Id = user.NormalizedUserName;
            return Task.FromResult(IdentityResult.Success);
        }

        public override Task<IdentityResult> DeleteAsync(IdUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task<IdUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task<IdUser> FindByIdAsync(string userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(new IdUser());
        }

        public override Task<IdUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.FromResult(new IdUser());
        }

        public override Task<IList<Claim>> GetClaimsAsync(IdUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            IList<Claim> claims = new List<Claim>();
            return Task.FromResult(claims);
        }

        public override Task<IList<UserLoginInfo>> GetLoginsAsync(IdUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task<IList<IdUser>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task RemoveClaimsAsync(IdUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task RemoveLoginAsync(IdUser user, string loginProvider, string providerKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task ReplaceClaimAsync(IdUser user, Claim claim, Claim newClaim, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public override Task<IdentityResult> UpdateAsync(IdUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        protected override Task AddUserTokenAsync(IdentityUserToken<string> token)
        {
            throw new NotImplementedException();
        }

        protected override Task<IdentityUserToken<string>> FindTokenAsync(IdUser user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task<IdUser> FindUserAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task<IdentityUserLogin<string>> FindUserLoginAsync(string userId, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task<IdentityUserLogin<string>> FindUserLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task RemoveUserTokenAsync(IdentityUserToken<string> token)
        {
            throw new NotImplementedException();
        }
    }
}
