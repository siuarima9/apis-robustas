﻿using System;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome{ get; set; }

        public string Email { get; set; }

        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador v)
        {
            return new AutenticarJogadorResponse()
            {
                Email = v.Email.Endereco,
                PrimeiroNome = v.Nome.PrimeiroNome,
                Status = (int)v.Status
            };
        }
    }
}
