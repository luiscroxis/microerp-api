﻿namespace MicroErp.Domain.Service.Abstract.Dtos.User.ResetPassword;

public class ResetPasswordRequestDto
{
    public string Email { get; set; }
	public string Token { get; set; }
    public string IdU { get; set; }
    public string NovaSenha { get; set; }
	public string ConfirmacaoSenha { get; set; }
}
