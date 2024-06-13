using AutoMapper;
using Harcama.Business.Abstract;
using Harcama.Entities.Concrete;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace Harcama.Business.Features.Register
{
    internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<RegisterCommandResponse>>
    {
        readonly UserManager<AppUser> _userManager;
        readonly IMapper _mapper;
        readonly IKullaniciSirketleriServices _kullaniciSirketleriServices ;
        readonly IKullaniciBirimYetkileriServices _kullaniciBirimYetkileriServices ;


        public RegisterCommandHandler(UserManager<AppUser> userManager, IMapper mapper, IKullaniciSirketleriServices kullaniciSirketleriServices, IKullaniciBirimYetkileriServices kullaniciBirimYetkileriServices)
        {
            _userManager = userManager;
            _mapper = mapper;
            _kullaniciSirketleriServices = kullaniciSirketleriServices;
            _kullaniciBirimYetkileriServices = kullaniciBirimYetkileriServices;
        }

        public async Task<Result<RegisterCommandResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            AppUser appUser = _mapper.Map<AppUser>(request);
         IdentityResult result =   await _userManager.CreateAsync(appUser, request.Sifre);
            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, "Personel");
                await _kullaniciSirketleriServices.AddRangeAsync(appUser.Id, request.SirketId);
                await _kullaniciBirimYetkileriServices.AddRangeAsync(appUser.Id, request.BirimId);
                await _kullaniciBirimYetkileriServices.SaveAsync();
                await _kullaniciSirketleriServices.SaveAsync();

                return Result<RegisterCommandResponse>.Succeed(new RegisterCommandResponse("Kayıt Başarılı"));
            }

            return Result<RegisterCommandResponse>.Failure("Kayıt Başarısız");
        }
    }
}
