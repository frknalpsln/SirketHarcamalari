using Harcama.Business.Features.Login;
using Harcama.DataAccess.Services;
using Harcama.Entities.Concrete;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

internal class LoginCommandHandler(
    UserManager<AppUser> userManager,
    IJwtProvider jwtProvider) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
{
    public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser appUser = await userManager.Users.FirstOrDefaultAsync(p=>p.UserName == request.UserNameOrEmail || p.Email == request.UserNameOrEmail, cancellationToken );

        if(appUser is null)
        {
            return Result<LoginCommandResponse>.Failure("Kullanıcı Bulunamadı");
        }

        bool isPasswordCorrect = await userManager.CheckPasswordAsync(appUser, request.Password);

        if(!isPasswordCorrect) 
        {
            return Result<LoginCommandResponse>.Failure("Şifre Yanlış");
        }
        string token = jwtProvider.CreateToken(appUser);
        LoginCommandResponse response = new(token);

        return Result<LoginCommandResponse>.Succeed(response);
    }
}
